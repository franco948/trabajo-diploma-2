using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsultorioDigital.Seguridad
{
  public class Usuario : Entidad<Guid>
  {
    private const byte CantidadMaximaIntentos = 3;
    private List<Permiso> _permisos = new List<Permiso>();

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
    public byte Intentos { get; set; }

    internal bool TieneIntentos => Intentos > 0;

    public IEnumerable<Permiso> Permisos 
    { 
      get { return _permisos;  } 
      set { _permisos = value.ToList(); } 
    }

    public bool Agregar(Permiso permiso)
    {
      bool existe = _permisos.Any(p => p.Buscar(permiso));

      if (!existe)
      {
        _permisos.Add(permiso);

        return true;
      }

      return false;
    }   

    public void Remover(Permiso permiso)
    {      
      _permisos.RemoveAll(x => x.Id == permiso.Id);
    }

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
