using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Exercises
{

    class DatabaseConnection
    {
        static void Main(string[] args)
        {
            var db = new DbCommand(new SqlConnection("123"));
            db.Execute("Hi there!");

            db = new DbCommand(new OracleConnection("456"));
            db.Execute("Hi back!");
        }
    }

    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly String _connectionString;
        private readonly String _instructions;

        public DbCommand(DbConnection dbConnection)
        {
            _dbConnection = dbConnection ?? throw new InvalidOperationException("The connection type cannot be null");
        }

        public void Execute(string instructions)
        {
            if (String.IsNullOrWhiteSpace(instructions))
                throw new InvalidOperationException("Instructions can't be null");

            _dbConnection.OpenConnection();
            Console.WriteLine("The instruction is: {0}", instructions);
            _dbConnection.CloseConnection();
        }


    }
}
