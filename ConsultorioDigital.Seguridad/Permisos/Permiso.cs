using System.Collections.Generic;

namespace ConsultorioDigital.Seguridad
{
  public abstract class Permiso : Entidad<int>
  {
    public string Nombre { get; set; }
    public abstract IEnumerable<Permiso> Hijos { get; }
    public abstract void Agregar(Permiso permiso);
    public abstract void Remover(Permiso permiso);
    public abstract IEnumerable<Permiso> Listar();
    public abstract bool Buscar(Permiso permiso);
    public abstract bool Habilitado(CodigoPermiso codigo);
  }
}
