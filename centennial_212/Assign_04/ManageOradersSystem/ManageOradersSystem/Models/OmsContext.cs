using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ManageOradersSystem.Models;

public partial class OmsContext : DbContext
{
    public OmsContext()
    {
    }

    public OmsContext(DbContextOptions<OmsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Basket> Baskets { get; set; }

    public virtual DbSet<BasketItem> BasketItems { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Shopper> Shoppers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\sqlexpress;Database=OMS;User ID=sa;Password=blogadmin;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Basket>(entity =>
        {
            entity.HasKey(e => e.IdBasket).HasName("PK__Basket__7ADD396B73501016");

            entity.ToTable("Basket");

            entity.Property(e => e.IdBasket)
                .ValueGeneratedNever()
                .HasColumnName("idBasket");
            entity.Property(e => e.IdShopper).HasColumnName("idShopper");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.SubTotal).HasColumnType("decimal(7, 2)");

            entity.HasOne(d => d.IdShopperNavigation).WithMany(p => p.Baskets)
                .HasForeignKey(d => d.IdShopper)
                .HasConstraintName("bskt_idshopper_fk");
        });

        modelBuilder.Entity<BasketItem>(entity =>
        {
            entity.HasKey(e => e.IdBasketItem).HasName("PK__BasketIt__2B9ACCF5D46DD5FE");

            entity.ToTable("BasketItem");

            entity.Property(e => e.IdBasketItem)
                .ValueGeneratedNever()
                .HasColumnName("idBasketItem");
            entity.Property(e => e.IdBasket).HasColumnName("idBasket");
            entity.Property(e => e.IdProduct).HasColumnName("idProduct");

            entity.HasOne(d => d.IdBasketNavigation).WithMany(p => p.BasketItems)
                .HasForeignKey(d => d.IdBasket)
                .HasConstraintName("bsktitem_bsktid_fk");

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.BasketItems)
                .HasForeignKey(d => d.IdProduct)
                .HasConstraintName("bsktitem_idprod_fk");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.IdProduct).HasName("PK__Product__5EEC79D18245E53F");

            entity.ToTable("Product");

            entity.Property(e => e.IdProduct)
                .ValueGeneratedNever()
                .HasColumnName("idProduct");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.ProductName)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Shopper>(entity =>
        {
            entity.HasKey(e => e.IdShopper).HasName("PK__Shopper__14739D529ACDDEF6");

            entity.ToTable("Shopper");

            entity.Property(e => e.IdShopper)
                .ValueGeneratedNever()
                .HasColumnName("idShopper");
            entity.Property(e => e.Address)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StateProvince)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ZipCode)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
