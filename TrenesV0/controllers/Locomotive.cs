namespace TrenesV0.views
{
    public class Locomotive
    {
        public long id { get; set; }
        public string locomotora { get; set; }
        public long fuerza { get; set; }
        public long estacion_actual { get; set; }

        public Locomotive(long id, string locomotora, long fuerza, long estacion_actual)
        {
            this.id = id;
            this.locomotora = locomotora;
            this.fuerza = fuerza;
            this.estacion_actual = estacion_actual;
        }
    }
}