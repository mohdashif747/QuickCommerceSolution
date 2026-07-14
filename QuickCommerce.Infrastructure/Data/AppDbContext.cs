using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuickCommerce.Infrastructure.Data
{
    public class AppDbContext
    {
        private readonly IConfiguration _config;
        public AppDbContext(IConfiguration configuration) { _config = configuration; }
        public IDbConnection CreateConnection() => new SqlConnection(_config.GetConnectionString("DefaultConnection"));
    }
}
