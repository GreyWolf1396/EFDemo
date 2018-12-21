using System;
using System.Data.Common;
using System.Data.Entity.Infrastructure.Interception;

namespace EFDemo.DAL.Interceptor
{
    public class CommandInterceptor : IDbCommandInterceptor
    {
        public void NonQueryExecuting(DbCommand command, DbCommandInterceptionContext<int> interceptionContext)
        {
            Console.WriteLine($"\tNonQueryExecuting {command.CommandType.ToString()}\t");
        }

        public void NonQueryExecuted(DbCommand command, DbCommandInterceptionContext<int> interceptionContext)
        {
            Console.WriteLine($"\tNonQueryExecuted {command.CommandType.ToString()}\t");
        }

        public void ReaderExecuting(DbCommand command, DbCommandInterceptionContext<DbDataReader> interceptionContext)
        {
            Console.WriteLine($"\tReaderExecuting {command.CommandType.ToString()}\t");
        }

        public void ReaderExecuted(DbCommand command, DbCommandInterceptionContext<DbDataReader> interceptionContext)
        {
            Console.WriteLine($"\tReaderExecuted {command.CommandType.ToString()}\t");
        }

        public void ScalarExecuting(DbCommand command, DbCommandInterceptionContext<object> interceptionContext)
        {
            Console.WriteLine($"\tScalarExecuting {command.CommandType.ToString()}\t");
        }

        public void ScalarExecuted(DbCommand command, DbCommandInterceptionContext<object> interceptionContext)
        {
            Console.WriteLine($"\tScalarExecuted {command.CommandType.ToString()}\t");
        }
    }
}
