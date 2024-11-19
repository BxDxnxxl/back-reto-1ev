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
    public double Precio {get; set;}
    public string TipoSala {get; set;}
    public double Descuento {get; set;}

    public Sesion(string idSala, List<Asiento> asientos, Pelicula pelicula, Sala sala, string tipoSala, double descuento)
    {
        Id = contadorId++;
        IdSala = idSala;
        ListaAsientos = asientos;
        AsientosRestantes = Sala.Capacidad;
        Pelicula = pelicula;
        Sala = sala;
        TipoSala = tipoSala;
        Descuento = descuento;

    }

    public void EliminarAsientos(int numAsientos){
        AsientosRestantes = AsientosRestantes - numAsientos;
    }

    public void CalcularPrecio()
    {
        switch (TipoSala)
        {
            case "Estandar":
                Precio = 6.00; 
                break;
            case "3D":
                Precio = 7.80; 
                break;
            case "Audio Dolby":
                Precio = 7.00; 
                break;
            default:
                throw new ArgumentException("Tipo de sala no válido");
        }

        if(Descuento != 0.00){
            Precio = Precio - (Precio*Descuento);
        }
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
