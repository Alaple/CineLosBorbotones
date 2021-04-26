using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine.Models
{
    public class CineContext :DbContext
    {
        public DbSet<Cine> Cines { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-OUG6EEB\SQLEXPRESS;Database=CineDB;Trusted_Connection=True;");
        }
    }
}
