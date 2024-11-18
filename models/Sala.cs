namespace models;


public class Sala
{
    private static int contadorId = 1;

    public int Id { get; private set; }
    public string Numero { get; set; }
    public string Tipo { get; set; }
    public int Capacidad{ get; set; }

    public Sala(string numero, string tipo, int capacidad)
    {
        Id = contadorId++;
        Numero = numero;
        Tipo = tipo;
        Capacidad = capacidad;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Numero: {Numero}");
        Console.WriteLine($"Tipo: {Tipo}");
        Console.WriteLine($"Capacidad: {Capacidad}");
    }
}
