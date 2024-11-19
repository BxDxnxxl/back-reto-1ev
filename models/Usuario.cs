namespace models;


public class Usuario
{
    private static int contadorId = 1;

    public int Id { get; private set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string Login { get; set; }
    private string Contrasenia{get; set;}
    public string ProfilePic{get; set;}

    public Usuario(string nombre, string login, string contrasenia, string profilePic, string apellidos)
    {
        Id = contadorId++;
        Nombre = nombre;
        Login = login;
        Contrasenia = contrasenia;
        ProfilePic = profilePic;
        Apellidos = apellidos;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"nombre: {Nombre} {Apellidos}");
        Console.WriteLine($"login: {Login}");
        Console.WriteLine($"contrasenia: {Contrasenia}");
    }
}
