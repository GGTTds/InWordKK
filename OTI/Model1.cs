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

        public virtual DbSet<HeadLeck> HeadLeck { get; set; }
        public virtual DbSet<HeadPark> HeadPark { get; set; }
        public virtual DbSet<leck> leck { get; set; }
        public virtual DbSet<Prak> Prak { get; set; }
        public virtual DbSet<Roul> Roul { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<SAMost> SAMost { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeadLeck>()
                .HasMany(e => e.leck)
                .WithOptional(e => e.HeadLeck)
                .HasForeignKey(e => e.WhoIsLec);

            modelBuilder.Entity<HeadPark>()
                .HasMany(e => e.Prak)
                .WithOptional(e => e.HeadPark)
                .HasForeignKey(e => e.WhoHead);

            modelBuilder.Entity<Roul>()
                .HasMany(e => e.User)
                .WithOptional(e => e.Roul)
                .HasForeignKey(e => e.Rol);
        }
    }
}
