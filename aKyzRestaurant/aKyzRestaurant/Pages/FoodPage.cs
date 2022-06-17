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
    public partial class FoodPage : Form
    {
        static String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\VS Forms\aKyzRestaurant\aKyzRestaurant\Pages\aKyzRestaurantDB.mdf;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public FoodPage()
        {
            InitializeComponent();
        }

        private void FoodPage_Load(object sender, EventArgs e)
        {
            List();
            timer1.Start();
        }

        public void List()
        {
            SqlDataAdapter food = new SqlDataAdapter("Select * From FoodTable", connection);
            SqlDataAdapter category = new SqlDataAdapter("Select * From CategoryTable", connection);

            DataSet fds = new DataSet();
            DataSet cds = new DataSet();

            food.Fill(fds);
            category.Fill(cds);

            fDGV.DataSource = fds.Tables[0];
            cDGV.DataSource = cds.Tables[0];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString();
        }

        private void fInsertBTN_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into FoodTable(FoodName, CategoryId, Price)values('"+fFoodTXT.Text+ "', '" + fCategoryTXT.Text + "', '" + fPriceTXT.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            List();
        }

        private void fUpdateBTN_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update FoodTable set FoodName='" + fFoodTXT.Text + "', CategoryId='" + fCategoryTXT.Text + "', Price='" + fPriceTXT.Text + "' where Id='" + fIdTXT.Text+"'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            List();
        }

        private void fDeleteBTN_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete FoodTable where Id='" + fIdTXT.Text + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            List();
        }

        private void cInsertBTN_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into CategoryTable(Category)values('" + cCategoryTXT.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            List();
        }

        private void cUpdateBTN_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update CategoryTable set Category='" + cCategoryTXT.Text + "' where Id='" + cIdTXT.Text + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            List();
        }

        private void cDeleteBTN_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete CategoryTable where Id='" + cIdTXT.Text + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            List();
        }

        private void fDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = e.RowIndex;
            DataGridViewRow selectedRow = fDGV.Rows[selected];
            fIdTXT.Text = selectedRow.Cells[0].Value.ToString();
            fFoodTXT.Text = selectedRow.Cells[1].Value.ToString();
            fCategoryTXT.Text = selectedRow.Cells[2].Value.ToString();
            fPriceTXT.Text = selectedRow.Cells[3].Value.ToString();
        }

        private void cDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = e.RowIndex;
            DataGridViewRow selectedRow = cDGV.Rows[selected];
            cIdTXT.Text = selectedRow.Cells[0].Value.ToString();
            fCategoryTXT.Text = selectedRow.Cells[0].Value.ToString();
            cCategoryTXT.Text = selectedRow.Cells[1].Value.ToString();
        }

        private void menuBTN_Click(object sender, EventArgs e)
        {
            HomePage page = new HomePage();
            page.Show();
            this.Hide();
        }
    }
}
