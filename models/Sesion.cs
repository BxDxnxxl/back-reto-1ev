namespace models;

public class Sesion
{
    private static int contadorId = 1;
    public int Id { get; private set; }
    public string IdSala { get; set; }
    public int AsientosRestantes {get; set;}
    public List<Asientos> ListaAsientos { get; set; } = new List<Asientos>();

    public Sesion(string idSala, List<Asientos> asientos)
    {
        Id = contadorId++;
        IdSala = idSala;
        ListaAsientos = asientos;
        AsientosRestantes = asientos.Count;
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
