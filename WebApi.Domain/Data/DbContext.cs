using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace WebApi.Domain.Data
{
    public class DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionstring;
        private readonly IDbConnection _connection;
        public DbContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionstring = _configuration.GetConnectionString("default")!;
            _connection = new SqlConnection(_connectionstring);
        }
        public IDbConnection connection { get { return _connection; } }
    }
}
