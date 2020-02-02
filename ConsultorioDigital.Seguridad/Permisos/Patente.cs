using System.Collections.Generic;

namespace ConsultorioDigital.Seguridad
{
  public class Patente : Permiso
  {
    public Patente(CodigoPermiso codigo)
    {
      this.Codigo = codigo;
    }

    public CodigoPermiso Codigo { get; private set; }

    public override IEnumerable<Permiso> Hijos => new List<Permiso>();
       
    public override void Agregar(Permiso permiso) {}

    public override bool Buscar(Permiso permiso)
    {
      return this.Id == permiso.Id;
    }

    public override void Remover(Permiso permiso) {}

    public override bool Habilitado(CodigoPermiso codigo)
    {
      return this.Codigo == codigo;
    }

    public override IEnumerable<Permiso> Listar()
    {
      return new List<Permiso> { this };
    }
  }
}
