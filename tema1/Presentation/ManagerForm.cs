using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tema1.BusinessLogic;

namespace tema1.Presentation
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void CreateCashier_Click(object sender, EventArgs e)
        {
            string name = CashierName.Text;
            string password = CashierPassword.Text;

            Boolean result;

            CashierService cashier = new CashierService();
            result = cashier.addCashier(name, password);

            if (result == true )
            {
                MessageBox.Show("Cashier created successfully.");
            }
            else 
            {
                MessageBox.Show("Something went rong.");
            }
        }

        private void UpdateCashier_Click(object sender, EventArgs e)
        {
            int id = int.Parse(CashierId.Text);
            string name = CashierName.Text;
            string password = CashierPassword.Text;

            Boolean result;

            CashierService cashier = new CashierService();
            result = cashier.updateCashier(id, name, password);

            if (result == true)
            {
                MessageBox.Show("Cashier updated successfully");
            }
            else
            {
                MessageBox.Show("Something went rong :(");
            }
           
        }

        private void CreateEvent_Click(object sender, EventArgs e)
        {
            DateTime date = this.ShowDate.Value.Date;
            string artists = (string)ShowArtists.Text;
            int seats = int.Parse(ShowSeats.Text);

            Boolean result;

            EventService show = new EventService();
            result = show.createEvent(date, artists, seats);

            if (result == true)
            {
                MessageBox.Show("Event created successfully");
            }
            else
            {
                MessageBox.Show("Something went rong :(");
            }
        }

        private void UpdateEvent_Click(object sender, EventArgs e)
        {
            DateTime date = this.ShowDate.Value.Date;
            string artists = ShowArtists.Text;
            int seats = int.Parse(ShowSeats.Text);
            int Id = int.Parse(EventId.Text);

            Boolean result;

            EventService show = new EventService();
            result = show.updateEvent(Id, date, artists, seats);

            if (result == true)
            {
                MessageBox.Show("Event updated successfully");
            }
            else
            {
                MessageBox.Show("Something went rong :(");
            }
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
