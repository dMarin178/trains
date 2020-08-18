using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenesV0.controllers
{
    public class Tren
    {

        public long idTren { get; set; }
        public long idLocoTiradora { get; set; }
        public string rutCreador { get; set; }

        public Tren(long idTren, long idLocoTiradora, string rutCreador)
        {
            this.idTren = idTren;
            this.idLocoTiradora = idLocoTiradora;
            this.rutCreador = rutCreador;
        }
        public Tren()
        {
        }
    }
}
