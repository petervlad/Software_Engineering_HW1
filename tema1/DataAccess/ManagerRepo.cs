using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using tema1.DataAccess.Model;

namespace tema1.DataAccess
{
    class ManagerRepo
    {
     
        public Boolean isManager(string name, string pass)
        {
            string nameT = name.Trim();
            string passT = pass.Trim();


            string dbpass = "nope";
            DataAccess db = new DataAccess();
            SqlConnection conn;

            conn = db.getConnection();

            var cmd = conn.CreateCommand();

            conn.Open();
            cmd.CommandText = "SELECT Password FROM dbo.Manager WHERE Name=" + "\'" + name + "\'";

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dbpass = (string)reader[0];
            }

            int isCash = string.Compare(dbpass.Trim(), pass.Trim());
            if (isCash == 0)
                return true;
            return false;

        }
        
    }
}
