using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ValtikCA.Domain.Entities;

namespace ValtikCA.Infrastructure.Persistence
{
    public partial class DBTiendaValtikContext : DbContext
    {
        public DBTiendaValtikContext()
        {
        }

        public DBTiendaValtikContext(DbContextOptions<DBTiendaValtikContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ProductoCategoria> ProductoCategoria { get; set; } = null!;
        public virtual DbSet<ProductosXorden> ProductosXordens { get; set; } = null!;
        public virtual DbSet<Categoria> Categoria { get; set; } = null!;
        public virtual DbSet<Cliente> TblClientes { get; set; } = null!;
        public virtual DbSet<Orden> TblOrdenes { get; set; } = null!;
        public virtual DbSet<Producto> TblProductos { get; set; } = null!;
        public IEnumerable<ProductoCategoria> ProductoCategorium { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("DBTiendaValtik");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductoCategoria>(entity =>
            {
                entity.HasKey(e => e.IdProdCategoria)
                    .HasName("PK__Producto__208D92138A310C61");

                entity.Property(e => e.IdProducto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.ProductoCategoria)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProductoC__IdCat__31EC6D26");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.ProductoCategoria)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProductoC__IdPro__30F848ED");
            });

            modelBuilder.Entity<ProductosXorden>(entity =>
            {
                entity.HasKey(e => e.IdProdOrden)
                    .HasName("PK__Producto__604613286DDF5391");

                entity.ToTable("ProductosXOrden");

                entity.Property(e => e.IdProdOrden)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdOrden).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdProducto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sku)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Total).HasColumnType("numeric(15, 0)");

                entity.HasOne(d => d.IdOrdenNavigation)
                    .WithMany(p => p.ProductosXordens)
                    .HasForeignKey(d => d.IdOrden)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Productos__IdOrd__2D27B809");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.ProductosXordens)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Productos__IdPro__2E1BDC42");
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.ToTable("TblCategoria");
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__TblCateg__A3C02A10B4DB5E92");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Miniatura)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__TblClien__D594664268D372FA");

                entity.ToTable("TblCliente");

                entity.Property(e => e.IdCliente).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Apellido1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPostal).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Password1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Provincia)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Orden>(entity =>
            {
                entity.HasKey(e => e.IdOrden)
                    .HasName("PK__TblOrden__C38F300DFA35D4CF");

                entity.Property(e => e.IdOrden)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DireccionEnvio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoOrden)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaOrden)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TblOrdenes)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TblOrdene__IdCli__2A4B4B5E");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto)
                    .HasName("PK__TblProdu__09889210000CD310");

                entity.ToTable("TblProducto");

                entity.Property(e => e.IdProducto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Imagen)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ImgMiniatura)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Precio).HasColumnType("numeric(15, 0)");

                entity.Property(e => e.Sku)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
