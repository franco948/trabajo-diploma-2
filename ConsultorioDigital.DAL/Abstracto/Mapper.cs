using System.Data;

namespace ConsultorioDigital.DAL.Mappers
{
  internal abstract class Mapper<T>
  {
    public abstract T Map(DataRow row);
  }
}
