using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BusinessObject.Models
{
    public partial class InvoiceDBContext : DbContext
    {
        public InvoiceDBContext()
        {
        }

        public InvoiceDBContext(DbContextOptions<InvoiceDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountingSoftware> AccountingSoftwares { get; set; }
        public virtual DbSet<ExcelField> ExcelFields { get; set; }
        public virtual DbSet<Field> Fields { get; set; }
        public virtual DbSet<GoodAndService> GoodAndServices { get; set; }
        public virtual DbSet<InvoiceVat> InvoiceVats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);Uid=sa;Pwd=123456;Database=InvoiceDB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AI");

            modelBuilder.Entity<AccountingSoftware>(entity =>
            {
                entity.ToTable("AccountingSoftware");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExcelField>(entity =>
            {
                entity.ToTable("ExcelField");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.FieldName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Field>(entity =>
            {
                entity.ToTable("Field");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AccountingSoftware)
                    .WithMany(p => p.Fields)
                    .HasForeignKey(d => d.AccountingSoftwareId)
                    .HasConstraintName("FK__Field__Accountin__3B75D760");

                entity.HasOne(d => d.ExcelFiled)
                    .WithMany(p => p.Fields)
                    .HasForeignKey(d => d.ExcelFiledId)
                    .HasConstraintName("FK__Field__ExcelFile__3C69FB99");
            });

            modelBuilder.Entity<GoodAndService>(entity =>
            {
                entity.ToTable("GoodAndService");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.InvoiceVatid).HasColumnName("InvoiceVATId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(255);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 3)");

                entity.HasOne(d => d.InvoiceVat)
                    .WithMany(p => p.GoodAndServices)
                    .HasForeignKey(d => d.InvoiceVatid)
                    .HasConstraintName("FK__GoodAndSe__Invoi__5165187F");
            });

            modelBuilder.Entity<InvoiceVat>(entity =>
            {
                entity.ToTable("InvoiceVAT");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BuyerAddress).HasMaxLength(255);

                entity.Property(e => e.BuyerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerName).HasMaxLength(50);

                entity.Property(e => e.BuyerTaxCode)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ImportedDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceSymbol)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SellerAddress).HasMaxLength(255);

                entity.Property(e => e.SellerName).HasMaxLength(50);

                entity.Property(e => e.SellerTaxCode)
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
