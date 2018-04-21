using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using tema1.DataAccess;
using tema1.DataAccess.Model;
using System.Security.Cryptography;
using System.Text;

namespace tema1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
              

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          Application.Run(new Form1());
          //string mySecretHash = "I love the SD lab";
            //var t = HashText("admin", mySecretHash, new SHA1CryptoServiceProvider());

          

        }
        public static string HashText(string text, string salt, HashAlgorithm hasher)
        {
            byte[] textWithSaltBytes = Encoding.UTF8.GetBytes(string.Concat(text, salt));
            byte[] hashedBytes = hasher.ComputeHash(textWithSaltBytes);
            hasher.Clear();
            return Convert.ToBase64String(hashedBytes);
        }
    }
}
