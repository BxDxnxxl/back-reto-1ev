namespace models;


public class Compra
{

    private static int contadorId = 1;
    public int Id { get; private set; }
    public string Usuario { get; set; }
    public List<string> AsientosPosiciones {get; set;}  = new List<string>();
    public int Sala {get; set;}
    public int NumEntradas {get; set;}
    public double Precio { get; set; }
    public DateTime Fecha{ get; set; }

    public Compra(string usuario, int numentradas, double precio, DateTime fecha, List<string> asientosPosiciones, int sala)
    {
        Id = contadorId++;
        Usuario = usuario;
        NumEntradas = numentradas;
        Precio = precio;
        Fecha = fecha;
        AsientosPosiciones = asientosPosiciones;
        Sala = sala;

    }

}
