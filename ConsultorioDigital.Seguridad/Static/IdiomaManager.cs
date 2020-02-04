using System.Collections.Generic;
using System.Linq;

namespace ConsultorioDigital.Seguridad
{
  public static class IdiomaManager
  {
    private static List<Leyenda> _leyendas = new List<Leyenda>();
    private static List<IObservador> _observadores = new List<IObservador>();

    public static void Attach(IObservador observador)
    {
      _observadores.Add(observador);
    }

    public static void Detach(IObservador observador)
    {
      _observadores.Remove(observador);
    }

    public static void Notify()
    {
      foreach (IObservador o in _observadores)
      {
        o.Actualizar();
      }
    }

    public static Leyenda GetLeyenda(string tag)
    {
      return _leyendas.FirstOrDefault(x => x.Tag.Nombre == tag);
    }
  }
}
