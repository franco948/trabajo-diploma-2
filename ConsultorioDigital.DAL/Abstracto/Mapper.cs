using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioDigital.DAL.Mappers
{
  internal abstract class Mapper<T>
  {
    public abstract T Map(IDataReader reader);
  }
}
