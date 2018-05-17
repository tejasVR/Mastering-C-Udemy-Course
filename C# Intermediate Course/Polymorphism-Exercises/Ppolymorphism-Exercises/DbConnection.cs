using System;

namespace Polymorphism_Exercises
{
    public abstract class DbConnection
    {
        public string ConnectString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            ConnectString = connectionString ?? throw new InvalidOperationException("The connection string can't be empty");
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}
