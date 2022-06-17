using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aKyzRestaurant.Pages
{
    public partial class TakeawayPage : Form
    {
        static String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\VS Forms\aKyzRestaurant\aKyzRestaurant\Pages\aKyzRestaurantDB.mdf;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public TakeawayPage()
        {
            InitializeComponent();
        }

        private void TakeawayPage_Load(object sender, EventArgs e)
        {
            timer1.Start();

            orderDGV.ColumnCount = 2;
            orderDGV.Columns[0].Name = "Food Name";
            orderDGV.Columns[1].Name = "Price";

            SqlDataAdapter food = new SqlDataAdapter("SELECT * FROM TakeawayTable", connection);
            DataSet fds = new DataSet();
            food.Fill(fds);
            dataGridView1.DataSource = fds.Tables[0];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToShortDateString()+ " - " + DateTime.Now.ToShortTimeString();
            dateLabel2.Text = DateTime.Now.ToShortDateString();
        }

        private void showBTN_Click(object sender, EventArgs e)
        {
            if (soupRB.Checked)
            {
                SqlDataAdapter food = new SqlDataAdapter("Select * From FoodTable where CategoryId=2", connection);
                DataSet fds = new DataSet();
                food.Fill(fds);
                foodDGV.DataSource = fds.Tables[0];
            }

            if (ffRB.Checked)
            {
                SqlDataAdapter food = new SqlDataAdapter("Select * From FoodTable where CategoryId=1", connection);
                DataSet fds = new DataSet();
                food.Fill(fds);
                foodDGV.DataSource = fds.Tables[0];
            }

            if (beverageRB.Checked)
            {
                SqlDataAdapter food = new SqlDataAdapter("Select * From FoodTable where CategoryId=3", connection);
                DataSet fds = new DataSet();
                food.Fill(fds);
                foodDGV.DataSource = fds.Tables[0];
            }
        }

        private void oaBTN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < orderDGV.Rows.Count - 1; i++)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insert into TakeawayTable(OrderNO, CName, FName, Adress, CPhoneNumber, Explantion, Price, Date)values(52, '"+cnTXT.Text+"', @ff, '"+addressTXT.Text+"', '" + pnTXT.Text + "', '" + explantionTXT.Text + "', '"+priceLabel.Text+"','" + dateLabel.Text + "')", connection);
                command.Parameters.AddWithValue("@ff", orderDGV.Rows[i].Cells["Food Name"].Value.ToString());
                command.ExecuteNonQuery();
                connection.Close();
            }
            orderDGV.Rows.Clear();
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            orderDGV.Rows.Clear();
        }

        private void foodDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in foodDGV.SelectedRows)
            {
                object[] rowData = new object[row.Cells.Count];
                for (int i = 0; i < rowData.Length; ++i)
                {
                    rowData[0] = row.Cells[1].Value;
                    rowData[1] = row.Cells[3].Value;
                }
                this.orderDGV.Rows.Add(rowData);
            }
        }

        private void calculatorBTN_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 0; i < orderDGV.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(orderDGV.Rows[i].Cells[1].Value);
            }
            priceLabel.Text = toplam.ToString();
        }

        private void menuBTN_Click(object sender, EventArgs e)
        {
            HomePage page = new HomePage();
            page.Show();
            this.Hide();
        }
    }
}
