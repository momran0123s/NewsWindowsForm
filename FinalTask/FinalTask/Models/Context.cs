using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask.Models
{
    internal class Context : DbContext
    {
        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Catalog> Catalog { get; set; }
        public virtual DbSet<News> News { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=.;Database=FinalTask;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
