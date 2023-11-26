using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciDersBilgisi
{
    public class UygulamaDbContext : DbContext
    {
        public DbSet<Ders> Dersler {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=DersBilgisiDb;trusted_connection=true;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ders>().HasData(

                new Ders { Id=1,Ad="İleri Programlama",Kod="BİL256",HarfNotu='A',Kredi=3},
                new Ders { Id=2,Ad="Genel Matematik",Kod="MAT178",HarfNotu='B',Kredi=3},
                new Ders { Id = 3, Ad = "İngilizce II", Kod = "İNG262", HarfNotu = 'D', Kredi = 2 },
                new Ders { Id = 4, Ad = "Seçmeli Ders I", Kod = "SEÇ401", HarfNotu = 'C', Kredi = 1 },
                new Ders { Id = 5, Ad = "Olasılık", Kod = "İST244", HarfNotu = 'F', Kredi = 4 }

                );    
        }
    }
}
