using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1
{
    public class WypozyczalniaDb : DbContext
    {
        public DbSet<Pojazd> Pojazd { get; set; }
        public DbSet<Adres> Adres { get; set; }
        public DbSet<Pracownicy> Pracownicy { get; set; }
        public DbSet<Klienci> Klienci { get; set; }
        public DbSet<Zlecenie> Zlecenie { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                  .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TAIIB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
