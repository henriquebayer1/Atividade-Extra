using Microsoft.EntityFrameworkCore;

namespace CrudExtra.Context
{
    public class FrutaContext : DbContext
    {






        public FrutaContext(DbContextOptions<FrutaContext> options)
       : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=NOTE14-S21\\MSSQLSERVER1; initial catalog=FrutaDB; user Id = sa; pwd = Senai@134; TrustServerCertificate=true;");
        }
    }
}
