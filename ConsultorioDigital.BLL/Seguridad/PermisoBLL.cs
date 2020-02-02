using System;
using System.Collections.Generic;
using ConsultorioDigital.DAL;
using ConsultorioDigital.Seguridad;

namespace ConsultorioDigital.BLL.Seguridad
{
  public class PermisoBLL : ICrud<Permiso>
  {
    public void Actualizar(Permiso entidad)
    {
      throw new System.NotImplementedException();
    }

    public void Crear(Permiso entidad)
    {
      //using (IUnitOfWork unitOfWork = UnitOfWorkFactory.Create())
      //{
      //  PermisoDAL permisoDAL = new PermisoDAL(unitOfWork);
      //  permisoDAL.Crear()
      //}
    }

    public void Eliminar(Permiso entidad)
    {
      throw new System.NotImplementedException();
    }

    public Permiso Obtener(Permiso entidad)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Permiso> Todos()
    {
      using (IUnitOfWork unitOfWork = UnitOfWorkFactory.Create())
      {
        return new PermisoDAL(unitOfWork).Todos();
      }
    }

    public void Agregar(Familia familia, Permiso hijo)
    {
      if (familia.Buscar(hijo))
        throw new InvalidOperationException("El permiso que desea agregar ya existe");

      if (hijo.Buscar(familia))
        throw new InvalidCastException("No puede crear dependencias circulares");

      familia.Agregar(hijo);

      using (IUnitOfWork unitOfWork = UnitOfWorkFactory.Create())
      {
        PermisoDAL permisoDAL = new PermisoDAL(unitOfWork);
        permisoDAL.Agregar(familia, hijo);
        unitOfWork.SaveChanges();
      }
    }

    public void Remover(Familia familia, Permiso hijo)
    {
      using (IUnitOfWork unitOfWork = UnitOfWorkFactory.Create())
      {
        PermisoDAL permisoDAL = new PermisoDAL(unitOfWork);
        permisoDAL.Remover(familia, hijo);
        unitOfWork.SaveChanges();

        familia.Remover(hijo);
      }
    }
  }
}
