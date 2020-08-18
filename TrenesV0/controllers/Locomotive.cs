using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenesV0.controllers
{
    public class Locomotive : MaterialRodante
    {
        public long fuerza { get; set; }
        public Locomotive(long id, string marca, long peso, long fuerza): base(id,marca,peso)
        {
            this.fuerza = fuerza;
        }
    }
}