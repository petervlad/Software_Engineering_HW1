using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tema1.DataAccess.Model;
using System.Data.SqlClient;
using tema1.DataAccess.Model;

namespace tema1.DataAccess
{

    class EventRepo:DataAccess
    {
        //CREATE SHOW//////////////////////////////////////////////////////////////////

        public Boolean insertShow(DateTime date, string artists, int tickets)
        {
            DataAccess db = new DataAccess();
            SqlConnection conn;

            conn = db.getConnection();

            var cmd = conn.CreateCommand();

            conn.Open();

            cmd.CommandText = "INSERT INTO dbo.Event (Date, Artists, NrOfTickets) VALUES(" 
                 + "\'" + date + "\'" + "," + "\'" + artists + "\'" + "," + tickets + ")";

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

                while(reader.Read())
                {
                    result = (int)reader[0];
                }
            }

            conn.Close();
            return result;
        }

        // GET EVENT BY ID///////////////////////////////////////////////////////

        public EventDTO getEvent(int id)
        {
            DataAccess db = new DataAccess();
            SqlConnection conn;

            conn = db.getConnection();

            EventDTO result = null;

            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select * from dbo.Event where Id=" + id.ToString();

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result = new EventDTO()
                    {
                        Id = (int)reader[0],
                        Date = (DateTime)reader[1],
                        Artists = (string)reader[2],
                        NrOfTickets = (int)reader[3]
                    };
                }
            }
            conn.Close();
            return result;
        }

        //  DECREMENT TICKETS   /////////////////////////////////////////////////////

        public Boolean decTickets(EventDTO show)
        {
            DataAccess db = new DataAccess();
            SqlConnection conn;

            conn = db.getConnection();

            var cmd = conn.CreateCommand();

            conn.Open();



            cmd.CommandText = "UPDATE dbo.Event SET NrOfTickets = NrOfTickets - 1 WHERE id ="
                              + show.Id + " and field > 0";

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

            return true;
        }

        //  DELETE  EVENT /////////////////////////////////////////////////////////// 

        public Boolean deleteEvent(int id)
        {
            DataAccess db = new DataAccess();
            SqlConnection conn;
            conn = db.getConnection();

            var cmd = conn.CreateCommand();

            conn.Open();

            cmd.CommandText = "DELETE FROM dbo.Event WHERE Id=" + id;

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

        //UPDATE EVENT///////////////////////////////////////////////////////////////////

        public Boolean updateEvent(int Id, DateTime date, string artists, int seats)
        {
            DataAccess db = new DataAccess();
            SqlConnection conn;
            conn = db.getConnection();

            var cmd = conn.CreateCommand();

            conn.Open();

            cmd.CommandText = "UPDATE dbo.Event SET Date=" + "\'"+date.ToString()+"\'" + "," +
                                                      "Artists=" + "\'" + artists + "\'" +
                                                      ",NrOfTickets=" + seats +
                                                      " WHERE Id=" + Id;
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
