using System.Collections.Generic;
using System.Data;
using ConsultorioDigital.DAL.Mappers;
using ConsultorioDigital.Seguridad;

namespace ConsultorioDigital.DAL
{
  public abstract class CrudGenerico<T> : ICrud<T> where T : Entidad
  {
    private readonly IAdoNetUnitOfWork UnitOfWork;
    private string _nombreTabla;

    public CrudGenerico(IUnitOfWork unitOfWork)
    {
      UnitOfWork = (IAdoNetUnitOfWork)unitOfWork;
      _nombreTabla = typeof(T).Name;
    }

    public abstract void Actualizar(T entidad);

    public abstract void Crear(T entidad);

    public void Eliminar(T entidad)
    {
      string sql = $"DELETE FROM [{_nombreTabla}] WHERE {_nombreTabla}_Id = @Id";

      UnitOfWork.Execute(sql, UnitOfWork.CreateParameter("@Id", entidad.Id));
    }

    public T Obtener(T entidad)
    {
      T entidadEncontrada = null;

      string sql = $"SELECT * FROM [{_nombreTabla}] WHERE {_nombreTabla}_Id = @Id";

      DataTable table = UnitOfWork.Read(sql, null, CommandType.Text).Tables[0];

      if (table.Rows.Count > 0)
      {
        MapperFactory.Crear<T>().Map(table.Rows[0]);
      }

      return entidadEncontrada;
    }

    public IEnumerable<T> Todos()
    {
      List<T> entidades = new List<T>();

      string sql = $"SELECT * FROM [{_nombreTabla}]";

      DataTable table = UnitOfWork.Read(sql, null, CommandType.Text).Tables[0];

      foreach (DataRow row in table.Rows)
      {
        T entidad = MapperFactory.Crear<T>().Map(row);
        entidades.Add(entidad);
      }

      return entidades;
    }
  }
}
