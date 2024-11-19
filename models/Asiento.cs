namespace models;


public class Asiento
{
    private static int contadorId = 1;

    public int Id { get; private set; }
    public bool Estado { get; set; }
    
    public Asiento(bool estado)
    {
        Id = contadorId++;
        Estado = estado;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Estado: {Estado}");
    }
}
