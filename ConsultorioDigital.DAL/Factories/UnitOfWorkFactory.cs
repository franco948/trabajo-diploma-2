using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioDigital.DAL
{
  public class UnitOfWorkFactory
  {
    public static IUnitOfWork Create()
    {
      string connectionString = ConfigurationManager.ConnectionStrings["Diploma"].ConnectionString;

      SqlConnection connection = new SqlConnection(connectionString);

      connection.Open();

      return new AdoNetUnitOfWork(connection);
    }
  }
}
