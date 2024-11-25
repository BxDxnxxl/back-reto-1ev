namespace models;


public class Asiento
{
    private static int contadorId = 1;

    public int Id { get; private set; }
    public bool Ocupado { get; set; }
    
    public Asiento(bool ocupado)
    {
        Id = contadorId++;
        Ocupado = ocupado;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Estado: {Ocupado}");
    }
}
