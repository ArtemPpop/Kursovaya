using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Kursovaya.Models;

public partial class KursovayaContext : DbContext
{
    public KursovayaContext()
    {
    }

    public KursovayaContext(DbContextOptions<KursovayaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actor> Actors { get; set; }

    public virtual DbSet<BrowsingHistory> BrowsingHistories { get; set; }

    public virtual DbSet<Director> Directors { get; set; }

    public virtual DbSet<Favorite> Favorites { get; set; }

    public virtual DbSet<Film> Films { get; set; }

    public virtual DbSet<Ganre> Ganres { get; set; }

    public virtual DbSet<Producer> Producers { get; set; }

    public virtual DbSet<PurchaseFilm> PurchaseFilms { get; set; }

    public virtual DbSet<PurchasingSubscription> PurchasingSubscriptions { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<Subscription> Subscriptions { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<ValidityPeriod> ValidityPeriods { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=teacherPc;Initial Catalog=Kursovaya;User ID=user8;Password=1234;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor>(entity =>
        {
            entity.ToTable("Actor");

            entity.Property(e => e.ActorId)
                .ValueGeneratedNever()
                .HasColumnName("ActorID");
            entity.Property(e => e.Fio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIO");
        });

        modelBuilder.Entity<BrowsingHistory>(entity =>
        {
            entity.HasKey(e => e.ViewId);

            entity.ToTable("BrowsingHistory");

            entity.Property(e => e.ViewId)
                .ValueGeneratedNever()
                .HasColumnName("ViewID");
            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.FilmId).HasColumnName("FilmID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Film).WithMany(p => p.BrowsingHistories)
                .HasForeignKey(d => d.FilmId)
                .HasConstraintName("FK_BrowsingHistory_Films");

            entity.HasOne(d => d.User).WithMany(p => p.BrowsingHistories)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_BrowsingHistory_Users");
        });

        modelBuilder.Entity<Director>(entity =>
        {
            entity.ToTable("Director");

            entity.Property(e => e.DirectorId)
                .ValueGeneratedNever()
                .HasColumnName("DirectorID");
            entity.Property(e => e.Fio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIO");
        });

        modelBuilder.Entity<Favorite>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("UserID");
            entity.Property(e => e.FilmId).HasColumnName("FilmID");

            entity.HasOne(d => d.User).WithOne(p => p.Favorite)
                .HasForeignKey<Favorite>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Favorites_Users");
        });

        modelBuilder.Entity<Film>(entity =>
        {
            entity.Property(e => e.FilmId)
                .ValueGeneratedNever()
                .HasColumnName("FilmID");
            entity.Property(e => e.ActorId).HasColumnName("ActorID");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DirectorId).HasColumnName("DirectorID");
            entity.Property(e => e.FilmName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GanreId).HasColumnName("GanreID");
            entity.Property(e => e.ProducersId).HasColumnName("ProducersID");
            entity.Property(e => e.SubscripType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.YearIssue)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Actor).WithMany(p => p.Films)
                .HasForeignKey(d => d.ActorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Films_Actor");

            entity.HasOne(d => d.Director).WithMany(p => p.Films)
                .HasForeignKey(d => d.DirectorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Films_Director");

            entity.HasOne(d => d.DirectorNavigation).WithMany(p => p.Films)
                .HasForeignKey(d => d.DirectorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Films_Producers");

            entity.HasOne(d => d.Ganre).WithMany(p => p.Films)
                .HasForeignKey(d => d.GanreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Films_Ganre");
        });

        modelBuilder.Entity<Ganre>(entity =>
        {
            entity.ToTable("Ganre");

            entity.Property(e => e.GanreId)
                .ValueGeneratedNever()
                .HasColumnName("GanreID");
            entity.Property(e => e.GanreName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Producer>(entity =>
        {
            entity.HasKey(e => e.ProducersId);

            entity.Property(e => e.ProducersId)
                .ValueGeneratedNever()
                .HasColumnName("ProducersID");
            entity.Property(e => e.Fio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIO");
        });

        modelBuilder.Entity<PurchaseFilm>(entity =>
        {
            entity.HasKey(e => e.PurchaseId);

            entity.ToTable("PurchaseFilm");

            entity.Property(e => e.PurchaseId)
                .ValueGeneratedNever()
                .HasColumnName("PurchaseID");
            entity.Property(e => e.FilmId).HasColumnName("FilmID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Film).WithMany(p => p.PurchaseFilms)
                .HasForeignKey(d => d.FilmId)
                .HasConstraintName("FK_PurchaseFilm_Films");

            entity.HasOne(d => d.User).WithMany(p => p.PurchaseFilms)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_PurchaseFilm_Users");
        });

        modelBuilder.Entity<PurchasingSubscription>(entity =>
        {
            entity.HasKey(e => e.PurchasingId);

            entity.ToTable("PurchasingSubscription");

            entity.Property(e => e.PurchasingId)
                .ValueGeneratedNever()
                .HasColumnName("PurchasingID");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Subscription).WithMany(p => p.PurchasingSubscriptions)
                .HasForeignKey(d => d.SubscriptionId)
                .HasConstraintName("FK_PurchasingSubscription_Subscription");

            entity.HasOne(d => d.User).WithMany(p => p.PurchasingSubscriptions)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_PurchasingSubscription_Users");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.ReviewsId);

            entity.Property(e => e.ReviewsId)
                .ValueGeneratedNever()
                .HasColumnName("ReviewsID");
            entity.Property(e => e.FilmId).HasColumnName("FilmID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Film).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.FilmId)
                .HasConstraintName("FK_Reviews_Films");

            entity.HasOne(d => d.User).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Reviews_Users");
        });

        modelBuilder.Entity<Subscription>(entity =>
        {
            entity.ToTable("Subscription");

            entity.Property(e => e.SubscriptionId)
                .ValueGeneratedNever()
                .HasColumnName("SubscriptionID");
            entity.Property(e => e.SubscriptionType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ValidityPeriodId).HasColumnName("ValidityPeriodID");

            entity.HasOne(d => d.ValidityPeriod).WithMany(p => p.Subscriptions)
                .HasForeignKey(d => d.ValidityPeriodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Subscription_ValidityPeriod");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("UserID");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FavoritesId).HasColumnName("FavoritesID");
            entity.Property(e => e.Login)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");
        });

        modelBuilder.Entity<ValidityPeriod>(entity =>
        {
            entity.ToTable("ValidityPeriod");

            entity.Property(e => e.ValidityPeriodId)
                .ValueGeneratedNever()
                .HasColumnName("ValidityPeriodID");
            entity.Property(e => e.ValidityPeriod1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ValidityPeriod");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
