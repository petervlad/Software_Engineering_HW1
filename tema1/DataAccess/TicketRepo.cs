using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using tema1.DataAccess.Model;

namespace tema1.DataAccess
{
    class TicketRepo : DataAccess
    {

        //  GET ALL TICKETS /////////////////////////////////////////////////////////
       
        public List<TicketDTO> getAllTickets()
        {  SqlConnection conn;
        DataAccess db = new DataAccess();

            conn = db.getConnection();

            var result = new List<TicketDTO>();

            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select * from dbo.Ticket";
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new TicketDTO()
                    {
                        Id = (int)reader[0],
                        ConcertId = (int)reader[1],
                        Seat = (int)reader[2]
                    });
                }
            }
            conn.Close();
            return result;
        }
        public List<TicketDTO> getTicketsForConcert(int concertId)
        {
            var tickets = getAllTickets();
                var filteredTickets=tickets.Where(x=>x.ConcertId==concertId).ToList();
                return filteredTickets;
        }

        // SELL TICKET////////////////////////////////////////////////////////////////

        public Boolean sellTicket(int concertId, int seat)
        {
            DataAccess db = new DataAccess();
            SqlConnection conn;
            conn = db.getConnection();
            EventDTO concertDTO = null;
            Boolean dec;

            var cmd = conn.CreateCommand();

            conn.Open();

            EventRepo concert = new EventRepo();
            int ticketsLeft = concert.getTicketsLeft(concertId);
            concertDTO = concert.getEvent(concertId);

            dec = concert.decTickets(concertDTO);

            if ( dec)
            {
                return false;
            }
            else
            {
                cmd.CommandText = "INSERT INTO dbo.Ticket (ConcertId, Seat) VALUES(" +
                                   concertId + "," + seat + ")";

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nError:" + ex.ToString());
                    conn.Close();
                    return false;
                }

                conn.Close();
                return true;
            }
        }


        // GET TICKETS LEFT ///////////////////////////////////////////////////

        public int getTicketsLeft(int concertId)
        {
            DataAccess db = new DataAccess();
            SqlConnection conn;

            conn = db.getConnection();

            int result = 0;

            using (var cmd = conn.CreateCommand())
            {

                conn.Open();
                cmd.CommandText = "SELECT * FROM dbo.Event WHERE Id=" + concertId.ToString();

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result = (int)reader[0];
                }
            }

            conn.Close();
            return result;
        }

        //  UPDATE  TICKET ////////////////////////////////////////////////////////

        public Boolean updateTicket(int seat, int ticketId)
        {
            DataAccess db = new DataAccess();
            SqlConnection conn;
            conn = db.getConnection();

            var cmd = conn.CreateCommand();

            conn.Open();

            cmd.CommandText = "UPDATE dbo.Ticket SET Seat="  + seat +        
                                                      "WHERE Id=" + ticketId;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nError:" + ex.ToString());
                conn.Close();
                return false;
            }

            conn.Close();
            return true;
        }
    }
}
