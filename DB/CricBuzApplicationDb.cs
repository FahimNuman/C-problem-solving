using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrickbazZ.DB
{
    internal class CricBuzApplicationDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-AJGON69\\SQLEXPRESS;Database=CricBuZZ;TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Deposite> Deposites { get; set; }
        public DbSet<Withdraw> Withdraws { get; set; }

    }
}
