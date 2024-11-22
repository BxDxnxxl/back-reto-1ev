namespace models
{
    public static class DataStore
    {
        //listas para almacenar todos los datos que se creen, se usa como si fuese una especie de BBDD
        public static List<Pelicula> Peliculas { get; set; } = new List<Pelicula>();
        public static List<Sala> Salas { get; set; } = new List<Sala>();
        public static List<Sesion> Sesiones { get; set; } = new List<Sesion>();
    }
}