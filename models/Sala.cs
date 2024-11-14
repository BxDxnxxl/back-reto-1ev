namespace models;


public class Sala
{
    private static int contadorId = 1;

    public int Id { get; private set; }
    public string Numero { get; set; }
    public string Asientos { get; set; }

    public Sala(string numero, string asientos)
    {
        Id = contadorId++;
        Numero = numero;
        Asientos = asientos;

    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Numero: {Numero}");
        Console.WriteLine($"Asientos: {Asientos}");
    }
}
