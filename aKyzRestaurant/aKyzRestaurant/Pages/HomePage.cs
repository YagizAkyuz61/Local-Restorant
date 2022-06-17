using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aKyzRestaurant.Pages
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToShortDateString()+ " - " + DateTime.Now.ToShortTimeString();
        }

        private void reservationBTN_Click(object sender, EventArgs e)
        {
            ReservationPage page = new ReservationPage();
            page.Show();
            this.Hide();
        }

        private void foodBTN_Click(object sender, EventArgs e)
        {
            FoodPage page = new FoodPage();
            page.Show();
            this.Hide();
        }

        private void tableBTN_Click(object sender, EventArgs e)
        {
            TablePage page = new TablePage();
            page.Show();
            this.Hide();
        }

        private void orderBTN_Click(object sender, EventArgs e)
        {
            OrderPage page = new OrderPage();
            page.Show();
            this.Hide();
        }

        private void personBTN_Click(object sender, EventArgs e)
        {
            PersonPage page = new PersonPage();
            page.Show();
            this.Hide();
        }

        private void tekeawayBTN_Click(object sender, EventArgs e)
        {
            TakeawayPage page = new TakeawayPage();
            page.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }
    }
}
