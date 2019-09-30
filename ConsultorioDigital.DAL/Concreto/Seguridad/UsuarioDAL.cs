using ConsultorioDigital.Seguridad;
using System;
using System.Linq;

namespace ConsultorioDigital.DAL
{
  public class UsuarioDAL : CrudGenerico<Usuario>
  {
    public UsuarioDAL(IUnitOfWork unitOfWork) : base(unitOfWork)
    {
    }

    public override void Actualizar(Usuario entidad)
    {
      throw new NotImplementedException();
    }

    public override void Crear(Usuario entidad)
    {
      throw new NotImplementedException();
    }

    public Usuario ObtenerPorEmail(Usuario usuario)
    {
      return Todos().Where(x => x.Email == usuario.Email).FirstOrDefault();
    }
  }
}
