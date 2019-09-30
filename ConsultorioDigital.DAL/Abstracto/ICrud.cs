using ConsultorioDigital.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioDigital.DAL
{
  public interface ICrud<T> where T : Entidad
  {
    void Crear(T entidad);
    void Eliminar(T entidad);
    void Actualizar(T entidad);
    T Obtener(T entidad);
    IEnumerable<T> Todos();
  }
}
