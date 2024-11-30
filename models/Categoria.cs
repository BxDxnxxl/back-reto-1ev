namespace models;

public class Categoria
{
    private static int contadorId = 1;
    public int Id { get; set; }
    public string Nombre { get; set; }

    public Categoria(string nombre)
    {
        Id = contadorId++;
        Nombre = nombre;
    }
}
