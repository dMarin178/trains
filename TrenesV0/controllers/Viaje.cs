using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenesV0.controllers
{
    class Viaje
    {
        public long idViaje { get; set; }
        public long idTren { get; set; }
        public long nroEstacionOrigen { get; set; }
        public long nroEstacionFinal { get; set; }
        public string rutCreador { get; set; }
        public DateTime fechaHoraSalida { get; set; }

        public Viaje(long idViaje, long idTren, long nroEstacionOrigen, long nroEstacionFinal, string rutCreador, DateTime fechaHoraSalida)
        {
            this.idViaje = idViaje;
            this.idTren = idTren;
            this.nroEstacionOrigen = nroEstacionOrigen;
            this.nroEstacionFinal = nroEstacionFinal;
            this.rutCreador = rutCreador;
            this.fechaHoraSalida = fechaHoraSalida;
        }
    }
}
