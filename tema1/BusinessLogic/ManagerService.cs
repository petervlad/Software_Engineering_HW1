using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using tema1.DataAccess.Model;
using tema1.DataAccess;
using tema1.BusinessLogic.Model;
using System.Security.Cryptography;

namespace tema1.BusinessLogic
{
    class ManagerService
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

        public ManagerDTO ModelToDTO(ManagerModel manager)
        {
            var converted = setupMapper<ManagerModel, ManagerDTO>().Map<ManagerDTO>(manager);
            return converted;
        }

        public Boolean checkManagaer(string name, string pass)
        {
            ManagerRepo manager = new ManagerRepo();
         
            string encryptedPassword = this.HashText(pass.Trim(), this.mySecretHash, new SHA1CryptoServiceProvider());
            return manager.isManager(name, encryptedPassword);
        }
        public string HashText(string text, string salt, HashAlgorithm hasher)
        {
            byte[] textWithSaltBytes = Encoding.UTF8.GetBytes(string.Concat(text, salt));
            byte[] hashedBytes = hasher.ComputeHash(textWithSaltBytes);
            hasher.Clear();
            return Convert.ToBase64String(hashedBytes);
        }
    }
}
