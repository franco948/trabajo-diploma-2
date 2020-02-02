using System.Collections.Generic;
using System.Linq;

namespace ConsultorioDigital.Seguridad
{
  public class Familia : Permiso
  {
    private readonly List<Permiso> _hijos = new List<Permiso>();

    public override IEnumerable<Permiso> Hijos => _hijos;

    public override void Agregar(Permiso permiso)
    {
      _hijos.Add(permiso);
    }

    public override bool Buscar(Permiso permiso)
    {      
      return this.Id == permiso.Id || _hijos.Any(p => p.Buscar(permiso));
    }

    public override void Remover(Permiso permiso)
    {
      _hijos.Remove(permiso);
    }

    public override bool Habilitado(CodigoPermiso codigo)
    {
      return _hijos.Any(p => p.Habilitado(codigo));
    }

    public override IEnumerable<Permiso> Listar()
    {
      List<Permiso> permisos = new List<Permiso>();

      foreach (Permiso permiso in _hijos)
      {        
        permisos.AddRange(permiso.Listar());
      }

      return new HashSet<Permiso>(permisos);
    } 
  }  
}
