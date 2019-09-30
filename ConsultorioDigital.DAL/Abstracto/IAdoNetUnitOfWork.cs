using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioDigital.DAL
{
  internal interface IAdoNetUnitOfWork : IUnitOfWork
  {
    IDbCommand CreateCommand(string sql);
  }
}
