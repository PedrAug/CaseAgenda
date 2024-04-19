using Npgsql;
using System.Data;

namespace CaseProject.Repository
{
    public class DataContext : IDisposable
    {
        public NpgsqlConnection Connection { get; set; }

        public DataContext()
        {
            Connection = new NpgsqlConnection("Host=caseagenda.database;Username=postgres;Password=admin;Database=usecase");
            Connection.Open();
        }

        public void Dispose()
        {
            if (Connection.State != ConnectionState.Closed)
                Connection.Close();
        }
    }
}
