namespace models;


public class Entrada
{

    public string Id { get; private set; }
    public Usuario Usuario { get; set; }
    public int UsuarioId {get; set;}
    public Sesion SesionId { get; set; }
    public DateTime FechaInicio{ get; set; }
    public DateTime FechaFin{ get; set; }

    public Entrada()
    {
        Id = $"{Usuario.Id},{SesionId.Id}";
        UsuarioId = Usuario.Id;
        FechaInicio = SesionId.FechaInicio;
        FechaFin = SesionId.FechaFin;

    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Numero: {Usuario.Nombre}");
        Console.WriteLine($"Fecha Inicio: {FechaInicio}");
        Console.WriteLine($"Fecha Fin: {FechaFin}");
    }
}
