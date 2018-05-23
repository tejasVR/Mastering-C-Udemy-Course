using System;

namespace Polymorphism_Exercises
{
    public class SqlConnection : DbConnection
    {

        public SqlConnection(string connectionString)
            : base(connectionString)  {       }

        public override void OpenConnection()
        {
            Console.WriteLine("The connection string is {0}", ConnectString);
            Console.WriteLine("Opened Sql Connection");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing Sql Connection");
        }

    }
}
