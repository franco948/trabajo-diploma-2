namespace ConsultorioDigital.Seguridad
{
  public class Leyenda : Entidad<int>
  {
    public string Texto { get; set; }
    public Idioma Idioma { get; set; }
    public Tag Tag { get; set; }
  }
}
