using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

      using (var command = UnitOfWork.CreateCommand(sql))
      {
        command.CommandType = System.Data.CommandType.Text;
        command.Parameters.Add("@Id");

        command.ExecuteNonQuery();
      }
    }

    public T Obtener(T entidad)
    {
      T entidadEncontrada = null;

      string sql = $"SELECT * FROM [{_nombreTabla}] WHERE {_nombreTabla}_Id = @Id";

      using (var command = UnitOfWork.CreateCommand(sql))
      {
        command.CommandType = System.Data.CommandType.Text;
        command.Parameters.Add("@Id", entidad.Id);

        using (var reader = command.ExecuteReader())
        {
          if (reader.Read())
          {
            MapperFactory.Crear<T>().Map(reader);
          }
        }
      }

      return entidadEncontrada;
    }

    public IEnumerable<T> Todos()
    {
      List<T> entidades = new List<T>();

      string sql = $"SELECT * FROM [{_nombreTabla}]";

      using (var command = UnitOfWork.CreateCommand(sql))
      {
        command.CommandType = System.Data.CommandType.Text;

        using (var reader = command.ExecuteReader())
        {
          while (reader.Read())
          {
            T entidad = MapperFactory.Crear<T>().Map(reader);
            entidades.Add(entidad);
          }
        }
      }

      return entidades;
    }
  }
}
