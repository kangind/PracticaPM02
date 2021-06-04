using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EsculapWpfApp.ModelBD
{
    public partial class DataBase : DbContext
    {
        public DataBase()
            : base("name=DataBase")
        {
        }

        public virtual DbSet<Doctors> Doctors { get; set; }
        public virtual DbSet<Patients> Patients { get; set; }
        public virtual DbSet<Privileges> Privileges { get; set; }
        public virtual DbSet<Reception> Reception { get; set; }
        public virtual DbSet<users> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Privileges>()
                .Property(e => e.Exempt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Privileges>()
                .Property(e => e.Summa)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Privileges>()
                .Property(e => e.Comment)
                .IsFixedLength();

            modelBuilder.Entity<Reception>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<users>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.password)
                .IsUnicode(false);
        }
    }
}
