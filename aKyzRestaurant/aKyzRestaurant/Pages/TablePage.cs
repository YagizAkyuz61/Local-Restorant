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
    public partial class TablePage : Form
    {
        static String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\VS Forms\aKyzRestaurant\aKyzRestaurant\Pages\aKyzRestaurantDB.mdf;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public TablePage()
        {
            InitializeComponent();
        }

        private void TablePage_Load(object sender, EventArgs e)
        {
            timer1.Start();

            orderDGV.ColumnCount = 3;
            orderDGV.Columns[0].Name = "Food Name";
            orderDGV.Columns[1].Name = "Table";
            orderDGV.Columns[2].Name = "Price";

            connection.Open();
            SqlCommand command = new SqlCommand("Select * From Tables", connection);
            SqlDataReader sdr;
            sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                tableCB.Items.Add(sdr["TableName"]);
            }
            connection.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToShortDateString();
            timeLABEL.Text = " - " + DateTime.Now.ToShortTimeString();
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

        private void foodDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in foodDGV.SelectedRows)
            {
                object[] rowData = new object[row.Cells.Count];
                for (int i = 0; i < rowData.Length; ++i)
                {
                    rowData[0] = row.Cells[1].Value;
                    rowData[1] = tableCB.Text;
                    rowData[2] = row.Cells[3].Value;
                }
                this.orderDGV.Rows.Add(rowData);
            }
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            orderDGV.Rows.Clear();
        }

        private void oaBTN_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < orderDGV.Rows.Count-1; i++) 
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insert into OrderTable(FoodName, Tables, Price, Opens, Date)values(@ff, @t, @p, 1, '"+dateLabel.Text+"')", connection);
                command.Parameters.AddWithValue("@ff", orderDGV.Rows[i].Cells["Food Name"].Value.ToString());
                command.Parameters.AddWithValue("@t", orderDGV.Rows[i].Cells["Table"].Value.ToString());
                command.Parameters.AddWithValue("@p", orderDGV.Rows[i].Cells["Price"].Value.ToString());
                command.ExecuteNonQuery();
                connection.Close();
            }
            orderDGV.Rows.Clear();
        }

        private void table1BTN_Click(object sender, EventArgs e)
        {
            SqlDataAdapter food = new SqlDataAdapter("Select FoodName, Price From OrderTable where Tables='Table-1' and Opens=1", connection);
            DataSet fds = new DataSet();
            food.Fill(fds);
            DGV.DataSource = fds.Tables[0];

            int toplam = 0;
            for (int i = 0; i < DGV.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(DGV.Rows[i].Cells[1].Value);
            }
            priceLBL.Text = toplam.ToString();

            tableNameLabel.Text = table1BTN.Text;
        }

        private void table2BTN_Click(object sender, EventArgs e)
        {
            SqlDataAdapter food = new SqlDataAdapter("Select FoodName, Price From OrderTable where Tables='Table-2' and Opens=1", connection);
            DataSet fds = new DataSet();
            food.Fill(fds);
            DGV.DataSource = fds.Tables[0];

            int toplam = 0;
            for (int i = 0; i < DGV.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(DGV.Rows[i].Cells[1].Value);
            }
            priceLBL.Text = toplam.ToString();

            tableNameLabel.Text = table2BTN.Text;
        }

        private void table3BTN_Click(object sender, EventArgs e)
        {
            SqlDataAdapter food = new SqlDataAdapter("Select FoodName, Price From OrderTable where Tables='Table-3' and Opens=1", connection);
            DataSet fds = new DataSet();
            food.Fill(fds);
            DGV.DataSource = fds.Tables[0];

            int toplam = 0;
            for (int i = 0; i < DGV.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(DGV.Rows[i].Cells[1].Value);
            }
            priceLBL.Text = toplam.ToString();
            tableNameLabel.Text = table3BTN.Text;
        }

        private void table4BTN_Click(object sender, EventArgs e)
        {
            SqlDataAdapter food = new SqlDataAdapter("Select FoodName, Price From OrderTable where Tables='Table-4' and Opens=1", connection);
            DataSet fds = new DataSet();
            food.Fill(fds);
            DGV.DataSource = fds.Tables[0];

            int toplam = 0;
            for (int i = 0; i < DGV.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(DGV.Rows[i].Cells[1].Value);
            }
            priceLBL.Text = toplam.ToString();
            tableNameLabel.Text = table4BTN.Text;
        }

        private void table5BTN_Click(object sender, EventArgs e)
        {
            SqlDataAdapter food = new SqlDataAdapter("Select FoodName, Price From OrderTable where Tables='Table-5' and Opens=1", connection);
            DataSet fds = new DataSet();
            food.Fill(fds);
            DGV.DataSource = fds.Tables[0];

            int toplam = 0;
            for (int i = 0; i < DGV.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(DGV.Rows[i].Cells[1].Value);
            }
            priceLBL.Text = toplam.ToString();
            tableNameLabel.Text = table5BTN.Text;
        }

        private void table6BTN_Click(object sender, EventArgs e)
        {
            SqlDataAdapter food = new SqlDataAdapter("Select FoodName, Price From OrderTable where Tables='Table-6' and Opens=1", connection);
            DataSet fds = new DataSet();
            food.Fill(fds);
            DGV.DataSource = fds.Tables[0];

            int toplam = 0;
            for (int i = 0; i < DGV.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(DGV.Rows[i].Cells[1].Value);
            }
            priceLBL.Text = toplam.ToString();
            tableNameLabel.Text = table6BTN.Text;
        }

        private void table7BTN_Click(object sender, EventArgs e)
        {
            SqlDataAdapter food = new SqlDataAdapter("Select FoodName, Price From OrderTable where Tables='Table-7' and Opens=1", connection);
            DataSet fds = new DataSet();
            food.Fill(fds);
            DGV.DataSource = fds.Tables[0];

            int toplam = 0;
            for (int i = 0; i < DGV.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(DGV.Rows[i].Cells[1].Value);
            }
            priceLBL.Text = toplam.ToString();
            tableNameLabel.Text = table7BTN.Text;
        }

        private void table8BTN_Click(object sender, EventArgs e)
        {
            SqlDataAdapter food = new SqlDataAdapter("Select FoodName, Price From OrderTable where Tables='Table-8' and Opens=1", connection);
            DataSet fds = new DataSet();
            food.Fill(fds);
            DGV.DataSource = fds.Tables[0];

            int toplam = 0;
            for (int i = 0; i < DGV.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(DGV.Rows[i].Cells[1].Value);
            }
            priceLBL.Text = toplam.ToString();
            tableNameLabel.Text = table8BTN.Text;
        }

        private void table9BTN_Click(object sender, EventArgs e)
        {
            SqlDataAdapter food = new SqlDataAdapter("Select FoodName, Price From OrderTable where Tables='Table-9' and Opens=1", connection);
            DataSet fds = new DataSet();
            food.Fill(fds);
            DGV.DataSource = fds.Tables[0];

            int toplam = 0;
            for (int i = 0; i < DGV.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(DGV.Rows[i].Cells[1].Value);
            }
            priceLBL.Text = toplam.ToString();
            tableNameLabel.Text = table9BTN.Text;
        }

        private void finisfBTN_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TotalPriceTable (Price, Date)values('"+priceLBL.Text+"', '"+dateLabel.Text+"')", connection);
            command.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            SqlCommand commandd = new SqlCommand("update OrderTable set Opens=0 where Tables='"+tableNameLabel.Text+"'", connection);
            commandd.ExecuteNonQuery();
            connection.Close();
        }

        private void menuBTN_Click(object sender, EventArgs e)
        {
            HomePage page = new HomePage();
            page.Show();
            this.Hide();
        }
    }
}
