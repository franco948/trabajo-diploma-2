using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    public IDbCommand CreateCommand(string sql)
    {
      var command = _connection.CreateCommand();

      command.CommandText = sql;
      command.CommandType = CommandType.StoredProcedure;
      command.Transaction = _transaction;

      return command;
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
  }
}
