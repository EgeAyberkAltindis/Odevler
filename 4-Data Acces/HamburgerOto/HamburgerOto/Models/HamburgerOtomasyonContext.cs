using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HamburgerOto.Models;

public partial class HamburgerOtomasyonContext : DbContext
{
    public HamburgerOtomasyonContext()
    {
    }

    public HamburgerOtomasyonContext(DbContextOptions<HamburgerOtomasyonContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Drink> Drinks { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Sauce> Sauces { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=DESKTOP-ABTB3OG\\SQLEXPRESS;database=HamburgerOtomasyon;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adress).HasMaxLength(255);
            entity.Property(e => e.Country).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");

            entity.HasOne(d => d.Order).WithMany(p => p.Customers)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Customers_Orders");
        });

        modelBuilder.Entity<Drink>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DrinkName).HasMaxLength(255);
            entity.Property(e => e.Litter).HasColumnName("litter");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.OrderDate).HasColumnType("date");
            entity.Property(e => e.ProcutId).HasColumnName("ProcutID");
            entity.Property(e => e.Quantity).HasColumnType("money");

            entity.HasOne(d => d.Procut).WithMany(p => p.Orders)
                .HasForeignKey(d => d.ProcutId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_Products");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DrinkId).HasColumnName("DrinkID");
            entity.Property(e => e.MenuName).HasMaxLength(50);
            entity.Property(e => e.SauceId).HasColumnName("SauceID");

            entity.HasOne(d => d.Drink).WithMany(p => p.Products)
                .HasForeignKey(d => d.DrinkId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Products_Drinks");

            entity.HasOne(d => d.Sauce).WithMany(p => p.Products)
                .HasForeignKey(d => d.SauceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Products_Sauce");
        });

        modelBuilder.Entity<Sauce>(entity =>
        {
            entity.ToTable("Sauce");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SauceName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
