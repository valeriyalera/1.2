using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using DanceStudio.Domain.Model;

namespace DanceStudio.Infrastructure;

public partial class DanceStudioContext : DbContext
{
    public DanceStudioContext()
    {
    }

    public DanceStudioContext(DbContextOptions<DanceStudioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AgeCategory> AgeCategories { get; set; }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<Cancellation> Cancellations { get; set; }

    public virtual DbSet<Coach> Coaches { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<Style> Styles { get; set; }

    public virtual DbSet<Subscription> Subscriptions { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=DanceStudio;Username=postgres");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AgeCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("AgeCategories_pkey");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Title).HasColumnType("character varying");
        });

        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Booking_pkey");

            entity.ToTable("Booking");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.PaymentId).HasColumnName("Payment_ID");
            entity.Property(e => e.ScheduleId).HasColumnName("Schedule_ID");
            entity.Property(e => e.Status).HasColumnType("character varying");
            entity.Property(e => e.UserId).HasColumnName("User_ID");
        });

        modelBuilder.Entity<Cancellation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Cancellations_pkey");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ScheduleId).HasColumnName("Schedule_ID");
            entity.Property(e => e.UserId).HasColumnName("User_ID");
        });

        modelBuilder.Entity<Coach>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Coaches_pkey");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnType("character varying");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Groups_pkey");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AgeId).HasColumnName("Age_ID");
            entity.Property(e => e.Level).HasColumnType("character varying");
            entity.Property(e => e.StyleId).HasColumnName("Style_ID");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Payment_pkey");

            entity.ToTable("Payment");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.BookingId).HasColumnName("Booking_ID");
            entity.Property(e => e.PaymentMethod).HasColumnType("character varying");
            entity.Property(e => e.Status).HasColumnType("character varying");
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Schedule_pkey");

            entity.ToTable("Schedule");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.StartTime).HasColumnType("time with time zone");
        });

        modelBuilder.Entity<Style>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Styles_pkey");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnType("character varying");
        });

        modelBuilder.Entity<Subscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Subscription_pkey");

            entity.ToTable("Subscription");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.UserId).HasColumnName("User_ID");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Users_pkey");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.FullName).HasColumnType("character varying");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
