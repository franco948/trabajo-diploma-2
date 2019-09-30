using System.Reflection;
using ConsultorioDigital.Seguridad;

namespace ConsultorioDigital.DAL.Mappers
{
  internal static class MapperFactory
  {
    // TODO deberia limitar a solo entidades
    // me estaba dando error con Entidad<object>
    public static Mapper<T> Crear<T>() where T : Entidad
    {
      string assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
      string typeName = $"{assemblyName}.Mappers.{typeof(T).Name}Mapper";

      return (Mapper<T>)Assembly.GetExecutingAssembly().CreateInstance(typeName);
    }
  }
}
