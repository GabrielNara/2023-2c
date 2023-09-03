namespace Clase2.IntroMVC.Entidades;

public class Pelicula
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Genero { get; set; }
    public string? Descripcion { get; set; }
    public int? Año { get; set; }
    public decimal? Presupuesto { get; set; }
    public decimal? Recaudacion { get; set; }
    public string? ImagenUrl { get; set; }
    public bool? NominadaAlOscar { get; set; }
    public bool? EstaEnNetflix { get; set; }
    public bool? EstaEnDisney { get; set; }
    public bool? EstaEnAmazon { get; set; }
    public bool? EstaEnStarPlus { get; set; }
    public bool? EstaEnHBO { get; set; }
}