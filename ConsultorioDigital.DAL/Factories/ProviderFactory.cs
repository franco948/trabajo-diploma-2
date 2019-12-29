using System.Configuration;
using System.Data.Common;

namespace ConsultorioDigital.DAL.Factories
{
  internal static class ProviderFactory
  {
    public static DbProviderFactory GetProvider()
    {
      string dbProvider = ConfigurationManager.AppSettings["DbProvider"];

      return DbProviderFactories.GetFactory(dbProvider);
    }
  }
}
