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
    public partial class OrderPage : Form
    {
        static String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\VS Forms\aKyzRestaurant\aKyzRestaurant\Pages\aKyzRestaurantDB.mdf;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public OrderPage()
        {
            InitializeComponent();
        }

        private void OrderPage_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToShortDateString();
            timeLABEL.Text = " - " + DateTime.Now.ToShortTimeString();
        }

        public void List()
        {
            if (todayRB.Checked)
            {
                SqlDataAdapter order = new SqlDataAdapter("Select * from OrderTable where Date='" + dateLabel.Text + "'", connection);
                DataSet ods = new DataSet();
                order.Fill(ods);
                dataGridView1.DataSource = ods.Tables[0];

                int toplam = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                }
                priceLabel.Text = toplam.ToString();
            }

            if (everydayRB.Checked)
            {
                SqlDataAdapter everyday = new SqlDataAdapter("Select * from OrderTable", connection);
                DataSet eds = new DataSet();
                everyday.Fill(eds);
                dataGridView1.DataSource = eds.Tables[0];
                priceLabel.Text = "0";
            }
        }

        private void todayRB_CheckedChanged(object sender, EventArgs e)
        {
            List();
        }

        private void everydayRB_CheckedChanged(object sender, EventArgs e)
        {
            List();
        }

        private void showBTN_Click(object sender, EventArgs e)
        {
            SqlDataAdapter order = new SqlDataAdapter("Select * from OrderTable where Date='" + maskedTextBox1.Text + "'", connection);
            DataSet ods = new DataSet();
            order.Fill(ods);
            dataGridView1.DataSource = ods.Tables[0];

            todayRB.Checked = false;
            everydayRB.Checked = false;
        }

        private void countBTN_Click(object sender, EventArgs e)
        {
            if (todayRB.Checked)
            {
                SqlDataAdapter order = new SqlDataAdapter("select FoodName, count(FoodName) as'Sales' from OrderTable where Date='"+dateLabel.Text+"' group by FoodName ", connection);
                DataSet ods = new DataSet();
                order.Fill(ods);
                dataGridView1.DataSource = ods.Tables[0];
                priceLabel.Text = "0";
            }

            if (everydayRB.Checked)
            {
                SqlDataAdapter everyday = new SqlDataAdapter("select FoodName, count(FoodName) as'Sales' from OrderTable group by FoodName", connection);
                DataSet eds = new DataSet();
                everyday.Fill(eds);
                dataGridView1.DataSource = eds.Tables[0];
                priceLabel.Text = "0";
            }
        }

        private void menuBTN_Click(object sender, EventArgs e)
        {
            HomePage page = new HomePage();
            page.Show();
            this.Hide();
        }
    }
}
