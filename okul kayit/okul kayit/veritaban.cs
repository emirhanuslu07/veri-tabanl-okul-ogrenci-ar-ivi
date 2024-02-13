using Microsoft.EntityFrameworkCore;
using okul_kayit.modelller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okul_kayit
{
    public class veritaban : DbContext

    {
        public DbSet<sinif> siniflar { get; set; }
        public DbSet<ogrenciler> ogrencilerr { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@" Server=(localdb)\MSSQLLocalDB;Initial Catalog=okul;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

        }
    }
}