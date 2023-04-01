using System.Data;

namespace WebApi.Domain.Data
{
    public class DbContext
    {

        private readonly IConfiguration _configuration;;
        private readonly IDbConnection _connection;
        public ContactDetailsContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionstring = _configuration.GetConnectionString("default");
            _connection = new SqlConnection(_connectionstring);
        }
        public IDbConnection connection { get { return _connection; } }
    }
}
