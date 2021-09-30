using System.Data.SqlClient;

namespace SyncClient.Core.SQL
{
    public abstract class ConnectionSql
    {
        private const string ConnectionString = "Server=.;Database=NETBUS;Trusted_Connection=True;MultipleActiveResultSets=true";
       
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
