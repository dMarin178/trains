using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenesV0.controllers
{
    class Admin
    {
        public string rut { get; set; }
        public string password { get; set; }
        public Admin(string rut, string password)
        {
            this.rut = rut;
            this.password = password;
        }
    }
}
