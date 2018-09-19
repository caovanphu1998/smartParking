using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace smartParking.Utils
{
    public partial class smartParkingContext : DbContext
    {
        public smartParkingContext()
        {
        }

        public smartParkingContext(DbContextOptions<smartParkingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAccount> TblAccount { get; set; }
        public virtual DbSet<TblCars> TblCars { get; set; }
        public virtual DbSet<TblHistorys> TblHistorys { get; set; }
        public virtual DbSet<TblMessages> TblMessages { get; set; }
        public virtual DbSet<TblUsers> TblUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\;Database=smartParking;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAccount>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("tblAccount");

                entity.Property(e => e.UserId)
                    .HasColumnName("userID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.RoleName)
                    .HasColumnName("roleName")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithOne(p => p.TblAccount)
                    .HasForeignKey<TblAccount>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtblAccount144644");
            });

            modelBuilder.Entity<TblCars>(entity =>
            {
                entity.HasKey(e => e.CarId);

                entity.ToTable("tblCars");

                entity.Property(e => e.CarId).HasColumnName("carID");

                entity.Property(e => e.CarName)
                    .HasColumnName("carName")
                    .HasMaxLength(50);

                entity.Property(e => e.LicensePlate)
                    .HasColumnName("licensePlate")
                    .HasMaxLength(20);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("userID")
                    .HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblCars)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtblCars199047");
            });

            modelBuilder.Entity<TblHistorys>(entity =>
            {
                entity.HasKey(e => e.HistoryId);

                entity.ToTable("tblHistorys");

                entity.Property(e => e.HistoryId).HasColumnName("historyID");

                entity.Property(e => e.KeyCode)
                    .HasColumnName("keyCode")
                    .HasMaxLength(50);

                entity.Property(e => e.Money).HasColumnName("money");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeIn)
                    .HasColumnName("timeIn")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeOut)
                    .HasColumnName("timeOut")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("userID")
                    .HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblHistorys)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtblHistory673104");
            });

            modelBuilder.Entity<TblMessages>(entity =>
            {
                entity.HasKey(e => e.MessId);

                entity.ToTable("tblMessages");

                entity.Property(e => e.MessId).HasColumnName("messID");

                entity.Property(e => e.MessStatus)
                    .HasColumnName("messStatus")
                    .HasMaxLength(50);

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("userID")
                    .HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblMessages)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtblMessage45632");
            });

            modelBuilder.Entity<TblUsers>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("tblUsers");

                entity.Property(e => e.UserId)
                    .HasColumnName("userID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstName)
                    .HasColumnName("firstName")
                    .HasMaxLength(50);

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.LastName)
                    .HasColumnName("lastName")
                    .HasMaxLength(50);

                entity.Property(e => e.Mail)
                    .HasColumnName("mail")
                    .HasMaxLength(70);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phoneNumber")
                    .HasMaxLength(11);
            });
        }
    }
}
