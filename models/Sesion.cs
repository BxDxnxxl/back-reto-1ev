namespace models;

public class Sesion
{
    private static int contadorId = 1;
    public int Id { get; private set; }
    public string IdSala { get; set; }
    public int AsientosRestantes {get; set;}
    public List<Asiento> ListaAsientos { get; set; } = new List<Asiento>();
    public Pelicula Pelicula { get; set; }
    public Sala Sala { get; set; }

    public Sesion(string idSala, List<Asiento> asientos, Pelicula pelicula, Sala sala)
    {
        Id = contadorId++;
        IdSala = idSala;
        ListaAsientos = asientos;
        AsientosRestantes = Sala.Capacidad;
        Pelicula = pelicula;
        Sala = sala;
    }

    public void EliminarAsientos(int numAsientos){
        AsientosRestantes = AsientosRestantes - numAsientos;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Numero: {IdSala}");
        Console.WriteLine($"Asientos Restantes: {AsientosRestantes}");
        Console.WriteLine("Asientos:");
        foreach (var asiento in ListaAsientos)
        {
            asiento.MostrarInformacion();
        }
    }
}
