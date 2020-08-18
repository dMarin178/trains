using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenesV0.controllers

{
    public class User
    {
        public string rut { get; set; }
        public string password { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

        public User(string rut, string password, string nombre, string apellido)
        {
            this.rut = rut;
            this.password = password;
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}
