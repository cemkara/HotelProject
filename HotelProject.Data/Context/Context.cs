using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelProject.Data
{
    public class Context : IdentityDbContext<MyUser, MyRole, int>
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AdminCommissionEarning> AdminCommissionEarnings { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<DiscountCoupon> DiscountCoupons { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<DriverAssignment> DriverAssignments { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<EventLog> EventLogs { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelCommission> HotelCommissions { get; set; }
        public DbSet<HotelCommissionEarning> HotelCommissionEarnings { get; set; }
        public DbSet<HotelEmail> HotelEmails { get; set; }
        public DbSet<HotelMenu> HotelMenus { get; set; }
        public DbSet<HotelMenuProduct> HotelMenuProducts { get; set; }
        public DbSet<HotelPhoneNumber> HotelPhoneNumbers { get; set; }
        public DbSet<HotelRestaurant> HotelRestaurants { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<NotificationLog> NotificationLogs { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderStatusHistory> OrderStatusHistories { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantCommission> RestaurantCommissions { get; set; }
        public DbSet<RestaurantEmail> RestaurantEmails { get; set; }
        public DbSet<RestaurantPhoneNumber> RestaurantPhoneNumbers { get; set; }
        public DbSet<RestaurantProduct> RestaurantProducts { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Transfer> Transfers { get; set; }
        public DbSet<UserEmail> UserEmails { get; set; }
        public DbSet<UserPhoneNumber> UserPhoneNumbers { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<UserType> UserTypes { get; set; }





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=HotelRestaurantProject;trusted_connection=true;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AdminCommissionEarning>()
                .Property(e => e.CommissionRate)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<AdminCommissionEarning>()
                .Property(e => e.EarnedAmount)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<HotelCommission>()
                .Property(e => e.CommissionRate)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<HotelCommissionEarning>()
                .Property(e => e.CommissionRate)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<HotelCommissionEarning>()
                .Property(e => e.EarnedAmount)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<DiscountCoupon>()
                .Property(e => e.DiscountAmount)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<DiscountCoupon>()
                .Property(e => e.MinAmount)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Transfer>()
                .Property(e => e.TransferPrice)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<HotelMenuProduct>()
                .Property(e => e.DiscountRate)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<HotelMenuProduct>()
                .Property(e => e.Price)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderTotalPrice)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.UnitPrice)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Payment>()
                .Property(e => e.TotalPayment)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Rating>()
                .Property(e => e.Rate)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Restaurant>()
                .Property(e => e.MinAmount)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<RestaurantCommission>()
                .Property(e => e.CommissionRate)
                .HasColumnType("decimal(18, 2)");

        }
    }
}
