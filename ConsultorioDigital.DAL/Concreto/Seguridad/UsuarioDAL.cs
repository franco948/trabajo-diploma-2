using ConsultorioDigital.Seguridad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ConsultorioDigital.DAL
{
  public class UsuarioDAL : CrudBase<Usuario>
  {
    public UsuarioDAL(IUnitOfWork unitOfWork) : base(unitOfWork)
    {
    }

    public override void Actualizar(Usuario entidad)
    {
      IDataParameter[] parameters =
      {
        UnitOfWork.CreateParameter("@Id", entidad.Id),
        UnitOfWork.CreateParameter("@Intentos", entidad.Intentos)
      };

      UnitOfWork.Execute("usp_UpdateUsuario", parameters);
    }

    public Usuario ObtenerPorEmail(Usuario usuario)
    {
      return Todos().Where(x => x.Email == usuario.Email).FirstOrDefault();
    }

    public IEnumerable<Permiso> Permisos(Usuario usuario)
    {
      List<Permiso> permisosUsuario = new List<Permiso>();

      PermisoDAL permisoDAL = new PermisoDAL(UnitOfWork);

      IEnumerable<Permiso> permisos = permisoDAL.Todos();

      IDataParameter[] parametros = { UnitOfWork.CreateParameter("@Usuario_Id", usuario.Id) };

      DataTable table = UnitOfWork.Read("usp_GetUsuarioPermiso", parametros).Tables[0];

      foreach (DataRow row in table.Rows)
      {
        int permisoId = Convert.ToInt32(row["Permiso_Id"]);

        permisosUsuario.Add(permisos.FirstOrDefault(x => x.Id == permisoId));
      }

      return permisosUsuario;
    }

    public void Habilitar(Usuario usuario, Permiso permiso)
    {
      IDataParameter[] parametros =
      {
        UnitOfWork.CreateParameter("@Usuario_Id", usuario.Id),
        UnitOfWork.CreateParameter("@Permiso_Id", permiso.Id)
      };

      UnitOfWork.Execute("usp_CreateUsuarioPermiso", parametros);
    }

    public void Deshabilitar(Usuario usuario, Permiso permiso)
    {
      IDataParameter[] parametros =
      {
        UnitOfWork.CreateParameter("@Usuario_Id", usuario.Id),
        UnitOfWork.CreateParameter("@Permiso_Id", permiso.Id)
      };

      UnitOfWork.Execute("usp_DeleteUsuarioPermiso", parametros);
    }
  }
}
