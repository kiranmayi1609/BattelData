using BattelData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BattelData.DataContext
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DatabaseContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer($"Data Source=LAPTOP-OL97CBLC\\MSSQLSERVER02;Initial Catalog=SamurayiDataBase;Integrated Security=True; TrustServerCertificate=True");
//            LAPTOP - OL97CBLC\MSSQLSERVER02
        }
        //Adding domain classes as Dbset 
        public virtual DbSet<Battle> Battles { get; set; }
        public virtual DbSet<Horses> Horses { get; set; }
        public virtual DbSet<Museum> Museums { get; set; }
        public virtual DbSet<S_Battle> S_Battle { get; set; }
        public virtual DbSet<S_Musem> S_Musem { get; set; }
        public virtual DbSet<Samurai> Samurais { get; set; }
        public virtual DbSet<Weapon> Weapons { get; set; }
}    }
