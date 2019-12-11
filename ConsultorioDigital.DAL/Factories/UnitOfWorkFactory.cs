using ConsultorioDigital.DAL.Factories;
using System.Configuration;
using System.Data;

namespace ConsultorioDigital.DAL
{
  public static class UnitOfWorkFactory
  {
    public static IUnitOfWork Create()
    {
      string connectionString = ConfigurationManager.ConnectionStrings["Diploma"].ConnectionString;

      IDbConnection connection = ProviderFactory.GetProvider().CreateConnection();
      connection.ConnectionString = connectionString;

      connection.Open();

      return new AdoNetUnitOfWork(connection);
    }
  }
}
