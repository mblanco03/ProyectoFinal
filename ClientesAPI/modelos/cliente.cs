public class Cliente
{
    public int Id { get; set; }

    public required string Nombres { get; set; }
    public required string Apellidos { get; set; }
    public required string Genero { get; set; }
    public DateTime? FechaNacimiento { get; set; } 
    public required string Estado { get; set; }
}
