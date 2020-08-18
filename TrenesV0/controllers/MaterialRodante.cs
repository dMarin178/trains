using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenesV0.controllers
{
    public class MaterialRodante
    {
        public long idMaterialR { get; set; }
        public string marca { get; set; }
        public long peso { get; set; }

        public MaterialRodante(long idMaterialR, string marca, long peso)
        {
            this.idMaterialR = idMaterialR;
            this.marca = marca;
            this.peso = peso;
        }
    }
}
