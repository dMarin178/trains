namespace TrenesV0
{
    public class Station
    {
        public long id { get; set; }
        public int espacio { get; set; }
        public string nombre { get; set; }

        public Station(long id, int espacio, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
            this.espacio = espacio;
        }
    }
}