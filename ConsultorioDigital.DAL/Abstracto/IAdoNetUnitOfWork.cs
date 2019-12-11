using System.Data;

namespace ConsultorioDigital.DAL
{
  internal interface IAdoNetUnitOfWork : IUnitOfWork
  {
    int Execute(string sql, params IDataParameter[] parameters);
    DataSet Read(string sql, IDataParameter[] parameters, CommandType commandType);
    IDataParameter CreateParameter(string name, object value);
  }
}
