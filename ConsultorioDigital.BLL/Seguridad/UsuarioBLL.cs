using System;
using System.Collections.Generic;
using ConsultorioDigital.DAL;
using ConsultorioDigital.Seguridad;

namespace ConsultorioDigital.BLL.Seguridad
{
  public class UsuarioBLL : ICrud<Usuario>
  {
    public void Actualizar(Usuario entidad)
    {
      throw new System.NotImplementedException();
    }

    public void Crear(Usuario entidad)
    {
      throw new System.NotImplementedException();
    }

    public void Eliminar(Usuario entidad)
    {
      throw new System.NotImplementedException();
    }

    public Usuario Obtener(Usuario entidad)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Usuario> Todos()
    {
      using (IUnitOfWork unitOfWork = UnitOfWorkFactory.Create())
      {
        return new UsuarioDAL(unitOfWork).Todos();
      }
    }

    public IEnumerable<Permiso> Permisos(Usuario usuario)
    {
      using (IUnitOfWork unitOfWork = UnitOfWorkFactory.Create())
      {
        return new UsuarioDAL(unitOfWork).Permisos(usuario);
      }
    }

    public void Habilitar(Usuario usuario, Permiso permiso)
    {
      foreach (Permiso p in usuario.Permisos)
      {
        if (p.Buscar(permiso))
        {
          throw new InvalidOperationException("El permiso seleccionado ya se encuentra asignado");
        }
      }

      using (IUnitOfWork unitOfWork = UnitOfWorkFactory.Create())
      {
        UsuarioDAL usuarioDAL = new UsuarioDAL(unitOfWork);
        usuarioDAL.Habilitar(usuario, permiso);
        unitOfWork.SaveChanges();
      }
    }

    public void Deshabilitar(Usuario usuario, Permiso permiso)
    {
      using(IUnitOfWork unitOfWork = UnitOfWorkFactory.Create())
      {
        UsuarioDAL usuarioDAL = new UsuarioDAL(unitOfWork);
        usuarioDAL.Deshabilitar(usuario, permiso);
        unitOfWork.SaveChanges();
      }
    }
  }
}
