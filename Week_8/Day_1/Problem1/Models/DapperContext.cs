using Microsoft.Data.SqlClient;
using System.Data;

namespace WebApplication4.Models
{
    public class DapperContext
    {
        private readonly string _connectionString;

        public DapperContext(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("DefaultConnection");
        }
        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

    }
}
