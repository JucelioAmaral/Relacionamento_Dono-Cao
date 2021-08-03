using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaEdesoft.Models
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Dono> tblDono { get; set; }
        public DbSet<Cao> tblCao { get; set; }
        public DbSet<Relacao_Dono_Cao> tblDono_Cao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=ProvaEdsesoft;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Relacao_Dono_Cao>()
                .HasKey(e => new { e.IdCao, e.IdDono });
        }

    }
}
