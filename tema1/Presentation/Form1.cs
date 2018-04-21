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
using tema1.Presentation;

namespace tema1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            string ussername = userTextBox.Text;
            string password = passTextBox.Text;
            Boolean result;

            ussername = ussername.Trim();
            password = password.Trim();

            CashierService cashier = new CashierService();
            result = cashier.checkCashier(ussername, password);

            if(result == true)
            {
                CashierForm cashierForm = new CashierForm();
                cashierForm.Show();
            }
            if(result == false)
            {
                ManagerService manager = new ManagerService();
                Boolean ifManager = manager.checkManagaer(ussername, password);

                if(ifManager == true)
                {
                    ManagerForm managerForm = new ManagerForm();
                    managerForm.Show();
                }
                else
                {
                    MessageBox.Show("Ussername or password incorrect.");
                }
            }
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            string ussername = userTextBox.Text;
            string password = passTextBox.Text;
            Boolean result;

            CashierService cashier = new CashierService();
            result = cashier.addCashier(ussername, password);

            if(result == true)
            {
                MessageBox.Show("The operation was successful :)");
            }
            else
            {
                MessageBox.Show("The operation was not successful or the implementation is garbage:(");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
