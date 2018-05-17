using System;

namespace Polymorphism_Exercises
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString) { }

        public override void OpenConnection()
        {
            Console.WriteLine("The connection string is {0}", ConnectString);
            Console.WriteLine("Opening Oracle Connection");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing Oracle Connection");
        }
    }
}
