public class InformacionGeneral
{
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public string TipoInformacion { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.Now;
    public DateTime? FechaActualizacion { get; set; }
    public string UsuarioCreador { get; set; }
    public string Estado { get; set; }


    public Cliente Cliente { get; set; }
}
