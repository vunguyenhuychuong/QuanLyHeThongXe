﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BusinessObject
{
    public partial class CarRentalSystemDBContext : DbContext
    {
        public CarRentalSystemDBContext()
        {
        }

        public CarRentalSystemDBContext(DbContextOptions<CarRentalSystemDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<CarProducer> CarProducers { get; set; }
        public virtual DbSet<CarRental> CarRentals { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<StaffAccount> StaffAccounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=1010;database=CarRentalSystemDB;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("Car");

                entity.Property(e => e.CarId)
                    .HasMaxLength(25)
                    .HasColumnName("CarID");

                entity.Property(e => e.CarName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ImportDate).HasColumnType("datetime");

                entity.Property(e => e.ProducerId)
                    .HasMaxLength(25)
                    .HasColumnName("ProducerID");

                entity.Property(e => e.RentPrice).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Producer)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.ProducerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Car__ProducerID__267ABA7A");
            });

            modelBuilder.Entity<CarProducer>(entity =>
            {
                entity.HasKey(e => e.ProducerId)
                    .HasName("PK__CarProdu__133696B2A4335C7C");

                entity.ToTable("CarProducer");

                entity.Property(e => e.ProducerId)
                    .HasMaxLength(25)
                    .HasColumnName("ProducerID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.ProcuderName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CarRental>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.CarId, e.PickupDate, e.ReturnDate })
                    .HasName("PK__CarRenta__E01D12250AD9B0EE");

                entity.ToTable("CarRental");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(25)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.CarId)
                    .HasMaxLength(25)
                    .HasColumnName("CarID");

                entity.Property(e => e.PickupDate).HasColumnType("datetime");

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");

                entity.Property(e => e.RentPrice).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.CarRentals)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK__CarRental__CarID__2C3393D0");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CarRentals)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__CarRental__Custo__2B3F6F97");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(25)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.CustomerEmail)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CustomerPassword)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdentityCard)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LicenceDate).HasColumnType("datetime");

                entity.Property(e => e.LicenceNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.CarId })
                    .HasName("PK__Review__522467F884A7FDAD");

                entity.ToTable("Review");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(25)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.CarId)
                    .HasMaxLength(25)
                    .HasColumnName("CarID");

                entity.Property(e => e.Comment).HasMaxLength(250);

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK__Review__CarID__300424B4");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Review__Customer__2F10007B");
            });

            modelBuilder.Entity<StaffAccount>(entity =>
            {
                entity.HasKey(e => e.StaffId)
                    .HasName("PK__StaffAcc__96D4AAF7B5775B26");

                entity.ToTable("StaffAccount");

                entity.Property(e => e.StaffId)
                    .HasMaxLength(25)
                    .HasColumnName("StaffID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Password).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
