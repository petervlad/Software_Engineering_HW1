using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using tema1.DataAccess.Model;
using tema1.BusinessLogic.Model;
using tema1.DataAccess;
using System.Security.Cryptography;

namespace tema1.BusinessLogic
{
   public class CashierService
    {
        protected Mapper IMapper;
        protected string mySecretHash = "I love the SD lab";
        public AutoMapper.IMapper setupMapper<T, U>()
        {
            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<T, U>();

            });
            var mapper = config.CreateMapper();
            return mapper;
        }

        public CashierDTO ModelToDTO(CashierModel cashier)
        {
            var converted=  setupMapper<CashierModel, CashierDTO>().Map<CashierDTO>(cashier);
            return converted;
        }

        public Boolean checkCashier(string name, string pass)
        {
            CashierRepo cashier = new CashierRepo();
            string encryptedPass = HashText(pass.Trim(), this.mySecretHash, new SHA1CryptoServiceProvider());
            return cashier.isCashier(name, encryptedPass);
        }
        public  string HashText(string text, string salt, HashAlgorithm hasher)
        {
            byte[] textWithSaltBytes = Encoding.UTF8.GetBytes(string.Concat(text, salt));
            byte[] hashedBytes = hasher.ComputeHash(textWithSaltBytes);
            hasher.Clear();
            return Convert.ToBase64String(hashedBytes);
        }
        public Boolean addCashier(string name, string pass)
        {
            Boolean result;

            CashierRepo cashier = new CashierRepo();
            string encrPass = HashText(pass.Trim(), this.mySecretHash, new SHA1CryptoServiceProvider());
            result = cashier.insertCashier(name, encrPass);

            return result;
        }

        public Boolean updateCashier(int Id, string name, string password)
        {
            Boolean result;

            CashierRepo cashier = new CashierRepo();
            result = cashier.updateCashier(Id, name, password);

            return result;
        }
    }

    
}
