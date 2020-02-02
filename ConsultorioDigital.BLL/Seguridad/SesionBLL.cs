using ConsultorioDigital.DAL;
using ConsultorioDigital.Seguridad;

namespace ConsultorioDigital.BLL
{
  public class SesionBLL
  {
    public bool Login(Usuario usuario)
    {
      using (IUnitOfWork unitOfWork = UnitOfWorkFactory.Create())
      {
        UsuarioDAL usuarioDAL = new UsuarioDAL(unitOfWork);

        Usuario usuarioEncontrado = usuarioDAL.ObtenerPorEmail(usuario);

        if (usuarioEncontrado != null && usuario.Autenticar(usuarioEncontrado))
        {
            Sesion.Instancia.Login(usuarioEncontrado);            
        }

        usuarioDAL.Actualizar(usuarioEncontrado);

        unitOfWork.SaveChanges();

        return Sesion.Instancia.Logueado;
      }
    }
  }
}
