using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrenesV0.controllers;

namespace TrenesV0.models
{
    public class Sistema
    {
        private List<Station> estaciones;
        private List<User> usuarios;
        private List<Producto> productos;

        public Sistema()
        {
            usuarios = SQLiteDataAccess.getUsers();
            estaciones = SQLiteDataAccess.getStationsComplete();
            productos = SQLiteDataAccess.getProducts();
        }

        public Boolean verificarUser(String rut, string passwd)
        {
            foreach(User u in usuarios)
            {
                if ( u.rut == rut && u.password == passwd)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
