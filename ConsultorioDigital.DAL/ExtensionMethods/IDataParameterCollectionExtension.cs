using System.Configuration;
using System.Data;
using System.Data.Common;

namespace ConsultorioDigital.DAL
{
  public static class IDataParameterCollectionExtension
  {
    public static IDataParameter Add(this IDataParameterCollection parameters, string name, object value)
    {
      string dbProvider = ConfigurationManager.AppSettings["DbProvider"];

      IDataParameter parameter = DbProviderFactories.GetFactory(dbProvider).CreateParameter();
      parameter.ParameterName = name;
      parameter.Value = value;

      parameters.Add(parameter);

      return parameter;
    }
  }
}
