using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace D20_Practice;

public partial class AmazondbContext : DbContext
{
    public AmazondbContext()
    {
    }

    public AmazondbContext(DbContextOptions<AmazondbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CustomerTbl> CustomerTbls { get; set; }

    public virtual DbSet<OrdersTbl> OrdersTbls { get; set; }

    public virtual DbSet<ProductsTbl> ProductsTbls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=F91983E652CC589;Initial Catalog=AMAZONDB;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CustomerTbl>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64B822166CDC");

            entity.ToTable("CustomerTbl");

            entity.Property(e => e.CustomerId)
                .ValueGeneratedNever()
                .HasColumnName("CustomerID");
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CustomerName).HasMaxLength(50);
        });

        modelBuilder.Entity<OrdersTbl>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__OrdersTb__C3905BAFDE256AC8");

            entity.ToTable("OrdersTbl");

            entity.Property(e => e.OrderId)
                .ValueGeneratedNever()
                .HasColumnName("OrderID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");

            entity.HasOne(d => d.Customer).WithMany(p => p.OrdersTbls)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__OrdersTbl__Custo__398D8EEE");
        });

        modelBuilder.Entity<ProductsTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProductsTbl");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ProductName).HasMaxLength(50);

            entity.HasOne(d => d.Order).WithMany()
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__ProductsT__Order__3B75D760");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
