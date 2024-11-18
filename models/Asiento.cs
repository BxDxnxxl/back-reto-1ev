namespace models;


public class Asiento
{
    private static int contadorId = 1;

    public int Id { get; private set; }
    public string Tipo { get; set; }
    public bool Estado { get; set; }
    
    public Asientos(string tipo, bool estado)
    {
        Id = contadorId++;
        Tipo = tipo;
        Estado = estado;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Tipo: {Tipo}");
        Console.WriteLine($"Estado: {Estado}");
    }
}
