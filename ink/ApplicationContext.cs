using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ink
{
    public class ApplicationContext : DbContext  // Исправлено: наследуемся от DbContext, а не от DbConnection
    {
        public DbSet<AirFlow> AirFlows { get; set; } // Поправлено название свойства и тип
        public DbSet<Volume> Volumes { get; set; } // Поправлено название свойства и тип

        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Username=postgres;Password=avemelissa;Database=postgreses");
        }
    }
}
