using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenesV0.controllers
{
    public class Producto
    {
        public long id { get; set; }
        public string tipo { get; set; }
        public long peso { get; set; }

        public Producto(long id, string tipo, long peso, long estacion_actual)
        {
            this.id = id;
            this.tipo = tipo;
            this.peso = peso;
        }
    }
}
