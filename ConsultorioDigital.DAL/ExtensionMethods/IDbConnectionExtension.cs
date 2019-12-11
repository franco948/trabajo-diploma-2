using System.Data;
using ConsultorioDigital.DAL.Factories;

namespace ConsultorioDigital.DAL
{
  public static class IDbConnectionExtension
  {
    public static IDbDataAdapter CreateDataAdapter(this IDbConnection connection)
    {
      IDbCommand command = connection.CreateCommand();
      IDbDataAdapter adapter = ProviderFactory.GetProvider().CreateDataAdapter();

      adapter.SelectCommand = command;

      return adapter;
    }
  }
}
