using GimnasioApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GimnasioApi.Data
{
    public class GimnasioDbContext : DbContext
    {
        public GimnasioDbContext(DbContextOptions<GimnasioDbContext> options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UsersProfiles { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<MembershipAdjustment> MembershipsAdjustments { get; set; }
        public DbSet<UserMembership> UserMemberships { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductSale> ProductSales { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<TrainerSpeciality> TrainerSpecialities { get; set; }

        public DbSet<ClassGroup> ClassGroups { get; set; }
        public DbSet<ClassSchedule> ClassSchedules { get; set; }
        public DbSet<ClassAttendance> ClassAttendances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TrainerSpeciality>()
                .HasKey(ts => new { ts.TrainerId, ts.SpecialityId });

            modelBuilder.Entity<TrainerSpeciality>()
                .HasOne(ts => ts.Trainer)
                .WithMany(t => t.TrainerSpecialities)
                .HasForeignKey(ts => ts.TrainerId);

            modelBuilder.Entity<TrainerSpeciality>()
                .HasOne(ts => ts.Speciality)
                .WithMany(s => s.TrainerSpecialities)
                .HasForeignKey(ts => ts.SpecialityId);
        }
    }
}
