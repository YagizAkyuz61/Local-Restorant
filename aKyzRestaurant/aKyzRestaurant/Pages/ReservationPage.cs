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
    public partial class ReservationPage : Form
    {
        public ReservationPage()
        {
            InitializeComponent();
        }
        static String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\VS Forms\aKyzRestaurant\aKyzRestaurant\Pages\aKyzRestaurantDB.mdf;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        private void ReservationPage_Load(object sender, EventArgs e)
        {
            timer1.Start();

            List();

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

        public void List()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * From ReservationTable", connection);
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
            SqlCommand command = new SqlCommand("insert into ReservationTable (CName, PhoneNumber, Tables, Date, Explanation)values('"+cNameTXT.Text+ "', '" + pnTXT.Text + "', '" + tableCB.Text + "', '" + dateTXT.Text + "', '" + explanationTXT.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            List();
        }

        private void menuBTN_Click(object sender, EventArgs e)
        {
            HomePage page = new HomePage();
            page.Show();
            this.Hide();
        }
    }
}
