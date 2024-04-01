using Microsoft.EntityFrameworkCore;
using NTierCvPro.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierCvPro.DataAccessLayer.Context
{
    public class NTierCvProContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-I1U4DR9;initial catalog=NTierCvProDb;Integrated Security=true");
        }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Deneyimlerim> Deneyimlerim { get; set; }
        public DbSet<Egitimlerim> Egitimlerim { get; set; }
        public DbSet<Hakkimda> Hakkimda { get; set; }
        public DbSet<Hobilerim> Hobilerim { get; set; }
        public DbSet<Iletisim> Iletisim { get; set; }
        public DbSet<Sertifikalarım> Sertifikalarım { get; set; }
        public DbSet<Yeteneklerim> Yeteneklerim { get; set; }
        public DbSet<SosyalMedya> SosyalMedya { get; set; }


    }
}
