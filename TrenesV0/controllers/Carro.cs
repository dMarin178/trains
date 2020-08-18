using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenesV0.controllers
{
    public class Carro : MaterialRodante
    {
        public long idProducto { get; set; }

        public Carro(long id, string marca, long peso, long idProducto) : base(id, marca, peso)
        {
            this.idProducto = idProducto;
        }
    }

}
