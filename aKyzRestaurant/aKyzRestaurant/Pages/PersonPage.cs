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
    public partial class PersonPage : Form
    {
        public PersonPage()
        {
            InitializeComponent();
        }

        static String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\VS Forms\aKyzRestaurant\aKyzRestaurant\Pages\aKyzRestaurantDB.mdf;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);

        private void PersonPage_Load(object sender, EventArgs e)
        {
            List();

            timer1.Start();
        }

        public void List()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from PersonTable", connection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString();
        }

        private void insertBTN_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into PersonTable(Name, Surname, Role)values('" + nameTXT.Text + "', '" + surnameTXT.Text + "', '" + roleCB.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            List();
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update PersonTable set Name='" + nameTXT.Text + "', Surname='" + surnameTXT.Text + "', Role='" + roleCB.Text + "' where Id='" + idTXT.Text + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            List();
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete PersonTable where Id='" + idTXT.Text + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            List();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selected];
            idTXT.Text = selectedRow.Cells[0].Value.ToString();
            nameTXT.Text = selectedRow.Cells[1].Value.ToString();
            surnameTXT.Text = selectedRow.Cells[2].Value.ToString();
            roleCB.Text = selectedRow.Cells[3].Value.ToString();
        }

        private void menuBTN_Click(object sender, EventArgs e)
        {
            HomePage page = new HomePage();
            page.Show();
            this.Hide();
        }
    }
}
