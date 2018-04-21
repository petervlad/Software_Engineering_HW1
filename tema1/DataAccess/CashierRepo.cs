using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using tema1.DataAccess.Model;
using System.Security.Cryptography;
using System.Security.Authentication;

namespace tema1.DataAccess
{
    class CashierRepo:DataAccess
    {
        /*
        public static string HashText(string text, string salt, HashAlgorithmType hasher)
        {
            byte[] textWithSaltBytes = Encoding.UTF8.GetBytes(string.Concat(text, salt));
            byte[] hashedBytes = hasher.ComputeHash(textWithSaltBytes);
            hasher.Clear();
            return Convert.ToBase64String(hashedBytes);
        }

        //VERIFY LOGIN//////////////////////////////////////////////////////

        public Boolean verifyLogin(string uss, string pass)
        {
            string salt = "blablabla";
            string hashedUss = HashText(pass, salt, new SHA1CryptoServiceProvider());

        }
        */

        public Boolean isCashier(string name, string pass)
        {
            string nameT = name.Trim();
            string passT = pass.Trim();

            
                string dbpass = "nope";
                DataAccess db = new DataAccess();
                SqlConnection conn;

                conn = db.getConnection();

                var cmd = conn.CreateCommand();

                conn.Open();
                cmd.CommandText = "SELECT Password FROM dbo.Cashier WHERE Name=" + "\'" + name + "\'";

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dbpass = (string)reader[0];
                }

                int isCash = string.Compare(dbpass.Trim(), pass.Trim());
                if (isCash ==  0)
                    return true;
                return false;
            
        }
        //  GET ALL CASHIERS ///////////////////////////////////////////////
        public List<CashierDTO> getAllCashiers()
        {
            DataAccess db = new DataAccess();
            SqlConnection conn;

            conn = db.getConnection();

            var result = new List<CashierDTO>();

            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select * from dbo.Cashier";
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new CashierDTO()
                    {
                        Id = (int)reader[0],
                        Name = (string)reader[1],
                        Password = (string)reader[2]
                    });
                }
            }
            conn.Close();
            return result;
        }      

        //  CREATE  CASHIER ////////////////////////////////////////////////////////
        public Boolean insertCashier(string name, string pass)
        {
            DataAccess db = new DataAccess();
            SqlConnection conn;
            conn = db.getConnection();

            var cmd = conn.CreateCommand();

            conn.Open();
            cmd.CommandText = "INSERT INTO dbo.Cashier (Name, Password) VALUES("
                                                      + "\'" + name + "\'" + ","
                                                      + "\'" + pass + "\'" + ")";
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

        //  DELETE  CASHIER /////////////////////////////////////////////////////////// 

        public Boolean deleteCashier(int id)
        {
            DataAccess db = new DataAccess();
            SqlConnection conn;
            conn = db.getConnection();

            var cmd = conn.CreateCommand();

            conn.Open();

            cmd.CommandText = "DELETE FROM dbo.Cashier WHERE Id=" + id;

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

        //  UPDATE  CASHIER ////////////////////////////////////////////////////////

        public Boolean updateCashier(int Id, string name, string password)
        {
            DataAccess db = new DataAccess();
            SqlConnection conn;
            conn = db.getConnection();

            var cmd = conn.CreateCommand();

            conn.Open();

            cmd.CommandText = "UPDATE dbo.Cashier SET Name=" + "\'" + name + "\'" + ", " +
                                                      "Password=" + "\'" + password + "\'" + " " +
                                                      "WHERE Id=" + Id;
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

        //  GET CASHIER BY ID  /////////////////////////////////////////////////
        public CashierDTO getCashier(int id)
        {
            DataAccess db = new DataAccess();
            SqlConnection conn;

            conn = db.getConnection();

            CashierDTO result = null;

            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select * from dbo.Cashier where Id=" + id.ToString();

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result = new CashierDTO()
                    {
                        Id = (int)reader[0],
                        Name = (string)reader[1],
                        Password = (string)reader[2]
                    };
                }
            }
            conn.Close();
            return result;
        }
    }
}

