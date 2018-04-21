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
using System.Xml;


namespace tema1
{
    public partial class CashierForm : Form
    {
        public CashierForm()
        {
            InitializeComponent();
        }

        private void Update_Click(object sender, EventArgs e)
        {
           
            int conSeat = int.Parse(concertSeat.Text);
            int tickId = int.Parse(ticketId.Text);

            Boolean result;

            TicketService ticket = new TicketService();
            result = ticket.updateTicket(conSeat, tickId);

            if (result == true)
            {
                MessageBox.Show("Ticket updated successfully");
            }
            else
            {
                MessageBox.Show("Something went rong :(");
            }
        }

        private void Sell_Click(object sender, EventArgs e)
        {
            int contId = int.Parse(concretId.Text);
            int conSeat = int.Parse(concertSeat.Text);
            Boolean result;

            TicketService ticket = new TicketService();
            result = ticket.sellTicket(contId, conSeat);

            if (result == true)
            {
                MessageBox.Show("Ticket was sold successfully");
            }
            else
            {
                MessageBox.Show("Something went rong, maybe the implementation is garbage :(");
            }

            using (XmlWriter writer = XmlWriter.Create("ticket.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Ticket");

                    writer.WriteElementString("Concert Id: ", contId.ToString().Trim());
                    writer.WriteElementString("Seat", conSeat.ToString().Trim());

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }

        }

        private void ticketId_TextChanged(object sender, EventArgs e)
        {

        }

        private void CashierForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int concertId = -1;
            try
            {
                 concertId = int.Parse(this.concretId.Text);
            }
            catch
            {
                MessageBox.Show("Not a valid input");
                return;

            }
            TicketService tickService=new TicketService();
            List<TicketModel> tickets = tickService.getTicketsForConcert(concertId);
            this.dataGridView1.DataSource = tickets;
        }

      
    }
}
