namespace OTI
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<HeadPark> HeadPark { get; set; }
        public virtual DbSet<leck> leck { get; set; }
        public virtual DbSet<Prak> Prak { get; set; }
        public virtual DbSet<Roul> Roul { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeadPark>()
                .HasMany(e => e.Prak)
                .WithOptional(e => e.HeadPark)
                .HasForeignKey(e => e.WhoHead);

            modelBuilder.Entity<Prak>()
                .Property(e => e.date)
                .IsFixedLength();

            modelBuilder.Entity<Roul>()
                .HasMany(e => e.User)
                .WithOptional(e => e.Roul)
                .HasForeignKey(e => e.Rol);
        }
    }
}
