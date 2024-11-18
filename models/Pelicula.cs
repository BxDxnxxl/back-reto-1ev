namespace models;


public class Pelicula
{
    private static int contadorId = 1;

    public int Id { get; private set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public string Director { get; set; }
    public string[] Categorias { get; set; }
    public DateTime AnioDeSalida { get; set; }
    public string ImagenBannerUrl { get; set; }
    public string ImagenPequeniaUrl { get; set; }
    public string Duracion { get; set; }
    public string Valoracion {get; set;}

    public Pelicula(string nombre, string descripcion, string director, string[] categorias, DateTime anioDeSalida, string imagenBannerUrl, string imagenPequeniaUrl, string duracion, string valoracion)
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
        Console.WriteLine($"Imagen: {ImagenUrl}");
        Console.WriteLine($"Duración: {Duracion}");
    }
}
