namespace TrenesV0
{
    public class Station
    {
        public long id { get; set; }
        public string nombre { get; set; }

        public Station(long id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }
}