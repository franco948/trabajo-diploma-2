using ConsultorioDigital.DAL.Factories;
using System;
using System.Data;

namespace ConsultorioDigital.DAL
{
  /* https://www.codeproject.com/Articles/709052/Unit-of-Work-Sample-Implementation-for-ADO-NET */
  internal class AdoNetUnitOfWork : IAdoNetUnitOfWork
  {
    private IDbConnection _connection;
    private IDbTransaction _transaction;

    public AdoNetUnitOfWork(IDbConnection connection)
    {
      _connection = connection;
      _transaction = connection.BeginTransaction();
    }

    public IDataParameter CreateParameter(string name, object value)
    {
      var param = ProviderFactory.GetProvider().CreateParameter();
      param.ParameterName = name;
      param.Value = value;

      return param;
    }

    public void Dispose()
    {
      if (_transaction != null)
      {
        _transaction.Rollback();
        _transaction = null;
      }

      if (_connection != null)
      {
        _connection.Close();
        _connection = null;
      }
    }

    public int Execute(string sql, params IDataParameter[] parametros)
    {
      using (var command = _connection.CreateCommand())
      {
        command.Transaction = _transaction;
        command.CommandType = CommandType.StoredProcedure;
        command.CommandText = sql;

        AddParameters(command, parametros);

        return command.ExecuteNonQuery();
      }
    }

    public DataSet Read(string sql, IDataParameter[] parametros)
    {
      IDbDataAdapter adapter = _connection.CreateDataAdapter();
      adapter.SelectCommand.Transaction = _transaction;
      adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      adapter.SelectCommand.CommandText = sql;

      AddParameters(adapter.SelectCommand, parametros);

      DataSet dataSet = new DataSet();
      adapter.Fill(dataSet);

      return dataSet;
    }

    public void SaveChanges()
    {
      if (_transaction == null)
      {
        throw new InvalidOperationException
               ("Transaction have already been committed. Check your transaction handling.");
      }

      _transaction.Commit();
      _transaction = null;
    }

    private void AddParameters(IDbCommand command, IDataParameter[] parametros)
    {
      if (parametros == null) return;

      foreach (var param in parametros)
      {
        command.Parameters.Add(param);
      }
    }
  }
}
