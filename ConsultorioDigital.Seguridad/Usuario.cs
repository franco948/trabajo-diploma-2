using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioDigital.Seguridad
{
  public class Usuario : Entidad<Guid>
  {
    private const uint CantidadMaximaIntentos = 3;

    public Usuario(string email, string password)
    {
      Email = email;
      Password = password;
      ResetearIntentos();
    }

    // TODO agregar regex al Email
    public string Email { get; set; }

    // TODO agregar validacion al password (min 6, 1 letra)
    public string Password { get; set; }

    public string PasswordCifrado { get; set; }
    public uint Intentos { get; set; }

    internal bool TieneIntentos => Intentos > 0;

    public void ResetearIntentos()
    {
      Intentos = CantidadMaximaIntentos;
    }

    public bool Autenticar(Usuario usuario)
    {
      if (!usuario.TieneIntentos)
      {
        // TODO traducir mensaje de error
        throw new InvalidOperationException($"El usuario {usuario.Email} se encuentra bloqueado");
      }

      usuario.Intentos--;

      bool autenticado = (CryptoManager.Comparar(Password, usuario.PasswordCifrado));

      if (autenticado)
      {
        usuario.ResetearIntentos();
      }

      return autenticado;
    }
  }
}
