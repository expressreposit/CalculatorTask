using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTask
{
    public class CalculatorContext : DbContext
    {
        public DbSet<Calculation> Calculations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=.;Initial Catalog=Company;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
