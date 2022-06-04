﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ValtikCA.Infrastructure.Persistence;

#nullable disable

namespace ValtikCA.Infrastructure.Migrations
{
    [DbContext(typeof(DBTiendaValtikContext))]
    partial class DBTiendaValtikContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ValtikCA.Infrastructure.Persistence.ProductoCategorium", b =>
                {
                    b.Property<int>("IdProdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProdCategoria"), 1L, 1);

                    b.Property<int>("IdCategoria")
                        .HasColumnType("int");

                    b.Property<string>("IdProducto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdProdCategoria")
                        .HasName("PK__Producto__208D92138A310C61");

                    b.HasIndex("IdCategoria");

                    b.HasIndex("IdProducto");

                    b.ToTable("ProductoCategoria");
                });

            modelBuilder.Entity("ValtikCA.Infrastructure.Persistence.ProductosXorden", b =>
                {
                    b.Property<decimal>("IdProdOrden")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(18,0)");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("IdProdOrden"), 1L, 1);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<decimal>("IdOrden")
                        .HasColumnType("numeric(18,0)");

                    b.Property<string>("IdProducto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Sku")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)");

                    b.Property<decimal>("Total")
                        .HasColumnType("numeric(15,0)");

                    b.HasKey("IdProdOrden")
                        .HasName("PK__Producto__604613286DDF5391");

                    b.HasIndex("IdOrden");

                    b.HasIndex("IdProducto");

                    b.ToTable("ProductosXOrden", (string)null);
                });

            modelBuilder.Entity("ValtikCA.Infrastructure.Persistence.TblCategorium", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCategoria"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Miniatura")
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdCategoria")
                        .HasName("PK__TblCateg__A3C02A10B4DB5E92");

                    b.ToTable("TblCategoria");
                });

            modelBuilder.Entity("ValtikCA.Infrastructure.Persistence.TblCliente", b =>
                {
                    b.Property<decimal>("IdCliente")
                        .HasColumnType("numeric(18,0)");

                    b.Property<string>("Apellido1")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Apellido2")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Ciudad")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<decimal?>("CodigoPostal")
                        .HasColumnType("numeric(10,0)");

                    b.Property<string>("Direccion")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Nombre1")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Nombre2")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Password1")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Provincia")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<decimal?>("Telefono")
                        .HasColumnType("numeric(18,0)");

                    b.HasKey("IdCliente")
                        .HasName("PK__TblClien__D594664268D372FA");

                    b.ToTable("TblCliente", (string)null);
                });

            modelBuilder.Entity("ValtikCA.Infrastructure.Persistence.TblOrdene", b =>
                {
                    b.Property<decimal>("IdOrden")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(18,0)");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("IdOrden"), 1L, 1);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("DireccionEnvio")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("EstadoOrden")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("FechaOrden")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<decimal>("IdCliente")
                        .HasColumnType("numeric(18,0)");

                    b.HasKey("IdOrden")
                        .HasName("PK__TblOrden__C38F300DFA35D4CF");

                    b.HasIndex("IdCliente");

                    b.ToTable("TblOrdenes");
                });

            modelBuilder.Entity("ValtikCA.Infrastructure.Persistence.TblProducto", b =>
                {
                    b.Property<string>("IdProducto")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Categoria")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Imagen")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("ImgMiniatura")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("numeric(15,0)");

                    b.Property<string>("Sku")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("IdProducto")
                        .HasName("PK__TblProdu__09889210000CD310");

                    b.ToTable("TblProducto", (string)null);
                });

            modelBuilder.Entity("ValtikCA.Infrastructure.Persistence.ProductoCategorium", b =>
                {
                    b.HasOne("ValtikCA.Infrastructure.Persistence.TblCategorium", "IdCategoriaNavigation")
                        .WithMany("ProductoCategoria")
                        .HasForeignKey("IdCategoria")
                        .IsRequired()
                        .HasConstraintName("FK__ProductoC__IdCat__31EC6D26");

                    b.HasOne("ValtikCA.Infrastructure.Persistence.TblProducto", "IdProductoNavigation")
                        .WithMany("ProductoCategoria")
                        .HasForeignKey("IdProducto")
                        .IsRequired()
                        .HasConstraintName("FK__ProductoC__IdPro__30F848ED");

                    b.Navigation("IdCategoriaNavigation");

                    b.Navigation("IdProductoNavigation");
                });

            modelBuilder.Entity("ValtikCA.Infrastructure.Persistence.ProductosXorden", b =>
                {
                    b.HasOne("ValtikCA.Infrastructure.Persistence.TblOrdene", "IdOrdenNavigation")
                        .WithMany("ProductosXordens")
                        .HasForeignKey("IdOrden")
                        .IsRequired()
                        .HasConstraintName("FK__Productos__IdOrd__2D27B809");

                    b.HasOne("ValtikCA.Infrastructure.Persistence.TblProducto", "IdProductoNavigation")
                        .WithMany("ProductosXordens")
                        .HasForeignKey("IdProducto")
                        .IsRequired()
                        .HasConstraintName("FK__Productos__IdPro__2E1BDC42");

                    b.Navigation("IdOrdenNavigation");

                    b.Navigation("IdProductoNavigation");
                });

            modelBuilder.Entity("ValtikCA.Infrastructure.Persistence.TblOrdene", b =>
                {
                    b.HasOne("ValtikCA.Infrastructure.Persistence.TblCliente", "IdClienteNavigation")
                        .WithMany("TblOrdenes")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK__TblOrdene__IdCli__2A4B4B5E");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ValtikCA.Infrastructure.Persistence.TblCategorium", b =>
                {
                    b.Navigation("ProductoCategoria");
                });

            modelBuilder.Entity("ValtikCA.Infrastructure.Persistence.TblCliente", b =>
                {
                    b.Navigation("TblOrdenes");
                });

            modelBuilder.Entity("ValtikCA.Infrastructure.Persistence.TblOrdene", b =>
                {
                    b.Navigation("ProductosXordens");
                });

            modelBuilder.Entity("ValtikCA.Infrastructure.Persistence.TblProducto", b =>
                {
                    b.Navigation("ProductoCategoria");

                    b.Navigation("ProductosXordens");
                });
#pragma warning restore 612, 618
        }
    }
}
