
using System;
using System.Collections.Generic;
using System.Data;
using ConsultorioDigital.DAL.Mappers;
using ConsultorioDigital.Seguridad;

namespace ConsultorioDigital.DAL
{
  public abstract class CrudBase<T> : ICrud<T> where T : Entidad
  {
    protected readonly IAdoNetUnitOfWork UnitOfWork;
    private string _nombreTabla;

    public CrudBase(IUnitOfWork unitOfWork)
    {
      UnitOfWork = (IAdoNetUnitOfWork)unitOfWork;
      _nombreTabla = typeof(T).Name;
    }

    public virtual void Actualizar(T entidad) => throw new NotImplementedException();

    public virtual void Crear(T entidad) => throw new NotImplementedException();

    public virtual void Eliminar(T entidad) => throw new NotImplementedException();
    
    public virtual T Obtener(T entidad)
    {
      T entidadEncontrada = null;

      string sql = $"usp_Get{_nombreTabla}";

      IDataParameter[] parameters =
      {
        UnitOfWork.CreateParameter("@Id", entidad.Id)
      };

      DataTable table = UnitOfWork.Read(sql, parameters).Tables[0];

      if (table.Rows.Count > 0)
      {
        MapperFactory.Crear<T>().Map(table.Rows[0]);
      }

      return entidadEncontrada;
    }

    public virtual IEnumerable<T> Todos()
    {
      List<T> entidades = new List<T>();

      string sql = $"usp_Get{_nombreTabla}";

      DataTable table = UnitOfWork.Read(sql, null).Tables[0];

      foreach (DataRow row in table.Rows)
      {
        T entidad = MapperFactory.Crear<T>().Map(row);
        entidades.Add(entidad);
      }

      return entidades;
    }
  }
}
