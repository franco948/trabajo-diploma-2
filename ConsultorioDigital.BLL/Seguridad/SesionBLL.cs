using ConsultorioDigital.DAL;
using ConsultorioDigital.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Sesion.Instancia.Login(usuario);

            return true;
        }

        return false;
      }
    }
  }
}
