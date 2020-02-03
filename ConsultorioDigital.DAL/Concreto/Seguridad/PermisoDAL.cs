using ConsultorioDigital.Seguridad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ConsultorioDigital.DAL
{
  public class PermisoDAL : CrudBase<Permiso>
  {
    public PermisoDAL(IUnitOfWork unitOfWork) : base(unitOfWork)
    {
    }

    public override IEnumerable<Permiso> Todos()
    {
      IEnumerable<Permiso> permisos = base.Todos();

      DataTable table = UnitOfWork.Read("usp_GetFamilia", null).Tables[0];

      foreach (DataRow row in table.Rows)
      {
        int idHijo = Convert.ToInt32(row["Hijo_Id"]);

        int idFamilia = Convert.ToInt32(row["Familia_Id"]);

        Permiso hijo = permisos.Where(x => x.Id == idHijo).FirstOrDefault();

        Permiso familia = permisos.Where(x => x.Id == idFamilia).FirstOrDefault();

        familia.Agregar(hijo);
      }

      return permisos;
    }

    public void Agregar(Familia familia, Permiso hijo)
    {
      IDataParameter[] parametros =
      {
        UnitOfWork.CreateParameter("@Familia_Id", familia.Id),
        UnitOfWork.CreateParameter("@Hijo_Id", hijo.Id)
      };

      UnitOfWork.Execute("usp_CreateFamilia", parametros);
    }

    public void Remover(Familia familia, Permiso hijo)
    {
      IDataParameter[] parametros =
      {
        UnitOfWork.CreateParameter("@Familia_Id", familia.Id),
        UnitOfWork.CreateParameter("@Hijo_Id", hijo.Id)
      };

      UnitOfWork.Execute("usp_DeleteFamilia" +
        "", parametros);
    }

    public override void Crear(Permiso entidad)
    {
      IDataParameter idParam = UnitOfWork.CreateParameter("@Permiso_Id", 0);
      idParam.Direction = ParameterDirection.Output;

      IDataParameter[] parametros =
      {
        UnitOfWork.CreateParameter("@Permiso_Nombre", entidad.Nombre),
        idParam
      };

      UnitOfWork.Execute("usp_CreatePermiso", parametros);
      entidad.Id = (int)idParam.Value;
    }

    public override void Eliminar(Permiso entidad)
    {
      IDataParameter[] parametros =
      {
        UnitOfWork.CreateParameter("@Permiso_Id", entidad.Id)
      };

      UnitOfWork.Execute("usp_DeletePermiso", parametros);
    }
  }
}
