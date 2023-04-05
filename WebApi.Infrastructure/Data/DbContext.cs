using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace WebApi.Domain.Data
{
    public class DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionstring;
        private IDbConnection _connection;
        public DbContext(IConfiguration configuration)
        {
            this._configuration = configuration;
            this._connectionstring = this._configuration.GetConnectionString("default")!;
        }

        public IDbConnection CreateConnection()
        {
           this._connection = new SqlConnection(_connectionstring);
            return this._connection;
        }
    }
}
