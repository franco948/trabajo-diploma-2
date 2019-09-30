
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioDigital.Seguridad
{
  // TODO deberia limitar a T (para GUID, string e int???)
  public abstract class Entidad<T> : Entidad
  {
    public Entidad()
    {
      FechaCreacion = DateTime.Now;
    }
    
    public new T Id { get; set; }
    public DateTime FechaCreacion { get; set; }
  }

  public abstract class Entidad
  {
    public object Id { get; set; }
  }
}
