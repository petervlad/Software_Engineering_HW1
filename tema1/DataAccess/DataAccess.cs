using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tema1.DataAccess.Model;
using System.Data.SqlClient;

namespace tema1.DataAccess
{
    public class DataAccess
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=HW1;Integrated Security=True";
        private SqlConnection sqlConnection;

        public SqlConnection getConnection()
        {
            sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;

        }
    }
}
