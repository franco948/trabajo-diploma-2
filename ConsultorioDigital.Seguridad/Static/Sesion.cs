using System;

namespace ConsultorioDigital.Seguridad
{
  public class Sesion
  {
    private static Sesion _instancia = null;
    private static readonly object _lock = new object();

    public static Sesion Instancia
    {
      get
      {
        if (_instancia == null)
        {
          lock (_lock)
          {
            if (_instancia == null)
            {
              _instancia = new Sesion();
            }
          }
        }

        return _instancia;
      }
    }

    public Usuario Usuario { get; private set; }

    public void Login(Usuario usuario)
    {
      // TODO traducir mensaje de error
      if (Usuario != null) throw new InvalidOperationException("Ya hay una sesión abierta");

      Usuario = usuario;
    }

    public void Logout()
    {
      Usuario = null;
    }

    public bool Logueado => Usuario != null;
  }
}
