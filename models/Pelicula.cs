namespace models;


public class Pelicula
{
    private static int contadorId = 1;

    public int Id { get; private set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public string Director { get; set; }
    public List<Categoria> Categorias { get; set; }
    public DateTime AnioDeSalida { get; set; }
    public string ImagenBannerUrl { get; set; }
    public string ImagenPequeniaUrl { get; set; }
    public int Duracion { get; set; }
    public double Valoracion {get; set;}

    public Pelicula(string nombre, string descripcion, string director, List<Categoria> categorias, DateTime anioDeSalida, string imagenBannerUrl, string imagenPequeniaUrl, int duracion, double valoracion)
    {
        Id = contadorId++;
        Nombre = nombre;
        Descripcion = descripcion;
        Director = director;
        Categorias = categorias;
        AnioDeSalida = anioDeSalida;
        ImagenBannerUrl = imagenBannerUrl;
        ImagenPequeniaUrl = imagenPequeniaUrl;
        Duracion = duracion;
        Valoracion = valoracion;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Descripción: {Descripcion}");
        Console.WriteLine($"Director: {Director}");
        Console.WriteLine("Categorías: " + string.Join(", ", Categorias));
        Console.WriteLine($"Año de Salida: {AnioDeSalida.Year}");
        Console.WriteLine($"Duración: {Duracion}");
    }
}
