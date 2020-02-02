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

      UnitOfWork.Execute("usp_DeleteFamilia", parametros);
    }
  }
}
