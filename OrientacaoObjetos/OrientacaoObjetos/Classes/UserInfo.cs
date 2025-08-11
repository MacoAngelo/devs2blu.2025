using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Classes
{
    internal class UserInfo
    {
        public static List<UserInfo> AllUsers { get; set; } = new List<UserInfo>()
        {
            new UserInfo()
            {
                Name = "Pelé",
                Email = "Pelé@futebol.com",
                User = "pele",
                Password = "Bolinha",            
            }
        };

        public string Name { get; set; }
        public string Email { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }
}
