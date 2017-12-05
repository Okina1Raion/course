using DataAccess_CP.Entities;

namespace DataAccess_CP
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CourseProjectDBEntities : DbContext
    {
        public CourseProjectDBEntities()
            : base("name=CourseProjectDBEntities1")
        {
        }

        public virtual DbSet<CreditCard> CreditCard { get; set; }
        public virtual DbSet<Drone> Drone { get; set; }
        public virtual DbSet<ParkingPlace> ParkingPlace { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<ParkingHistory> ParkingHistory { get; set; }
        public virtual DbSet<ParkingPayment> ParkingPayment { get; set; }
        public virtual DbSet<UserInRole> UserInRole { get; set; }
        public virtual DbSet<UsersCard> UsersCard { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CreditCard>()
                .Property(e => e.number)
                .IsUnicode(false);

            modelBuilder.Entity<CreditCard>()
                .Property(e => e.finish_date)
                .IsUnicode(false);

            modelBuilder.Entity<CreditCard>()
                .Property(e => e.CVV)
                .IsUnicode(false);

            modelBuilder.Entity<CreditCard>()
                .HasMany(e => e.UsersCard)
                .WithRequired(e => e.CreditCard)
                .HasForeignKey(e => e.card_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Drone>()
                .HasMany(e => e.ParkingHistory)
                .WithRequired(e => e.Drone)
                .HasForeignKey(e => e.drone_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Drone>()
                .HasMany(e => e.User)
                .WithMany(e => e.Drone)
                .Map(m => m.ToTable("UsersDrone").MapLeftKey("drone_id").MapRightKey("user_id"));

            modelBuilder.Entity<ParkingPlace>()
                .HasMany(e => e.ParkingHistory)
                .WithRequired(e => e.ParkingPlace)
                .HasForeignKey(e => e.parking_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ParkingPlace>()
                .HasMany(e => e.ParkingPayment)
                .WithRequired(e => e.ParkingPlace)
                .HasForeignKey(e => e.parking_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ParkingPlace>()
                .HasMany(e => e.User)
                .WithMany(e => e.ParkingPlace)
                .Map(m => m.ToTable("ParkingOwner").MapLeftKey("parking_id").MapRightKey("user_id"));

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserInRole)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UsersCard)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ParkingPayment>()
                .Property(e => e.payment_per_time_unit)
                .IsUnicode(false);
        }
    }
}
