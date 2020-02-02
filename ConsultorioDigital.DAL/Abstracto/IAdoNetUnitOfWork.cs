using System.Data;

namespace ConsultorioDigital.DAL
{
  public interface IAdoNetUnitOfWork : IUnitOfWork
  {
    int Execute(string sql, params IDataParameter[] parameters);
    DataSet Read(string sql, IDataParameter[] parameters);
    IDataParameter CreateParameter(string name, object value);
  }
}
