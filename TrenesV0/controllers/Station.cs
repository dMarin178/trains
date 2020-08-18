using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenesV0.controllers
{
    public class Station
    {
        public long nroEstacion { get; set; }
        public long espacio { get; set; }
        public string nombre { get; set; }
        
        public List<MaterialRodante> materiales { get; set; }
        public Station(long nroEstacion, long espacio, string nombre)
        {
            this.nroEstacion = nroEstacion;
            this.espacio = espacio;
            this.nombre = nombre;
            this.materiales = new List<MaterialRodante>();
        }
    }
}