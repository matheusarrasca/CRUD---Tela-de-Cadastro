using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaCadastroCliente.Data
{
    class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=DbConnection")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<AppDbContext>());
        }
        
        public DbSet<Cliente> Clientes { get; set; }
    }
}
