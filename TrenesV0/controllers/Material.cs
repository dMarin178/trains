using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenesV0
{
    public class Material
    {
        public long id { get; set; }
        public string material { get; set; }
        public long peso { get; set; }
        public long estacion_actual { get; set; }

        public Material(long id, string material, long peso, long estacion_actual)
        {
            this.id = id;
            this.material = material;
            this.peso = peso;
            this.estacion_actual = estacion_actual;
        }
    }
}
