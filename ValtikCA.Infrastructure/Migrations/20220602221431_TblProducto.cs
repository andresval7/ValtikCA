using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ValtikCA.Infrastructure.Migrations
{
    public partial class TblProducto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblCategoria",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    Miniatura = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TblCateg__A3C02A10B4DB5E92", x => x.IdCategoria);
                });

            migrationBuilder.CreateTable(
                name: "TblCliente",
                columns: table => new
                {
                    IdCliente = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Nombre1 = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Nombre2 = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Apellido1 = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Apellido2 = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Password1 = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Direccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Telefono = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    Ciudad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Provincia = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    CodigoPostal = table.Column<decimal>(type: "numeric(10,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TblClien__D594664268D372FA", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "TblProducto",
                columns: table => new
                {
                    IdProducto = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Sku = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    Nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Precio = table.Column<decimal>(type: "numeric(15,0)", nullable: false),
                    Categoria = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    ImgMiniatura = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Imagen = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TblProdu__09889210000CD310", x => x.IdProducto);
                });

            migrationBuilder.CreateTable(
                name: "TblOrdenes",
                columns: table => new
                {
                    IdOrden = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    DireccionEnvio = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FechaOrden = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    EstadoOrden = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TblOrden__C38F300DFA35D4CF", x => x.IdOrden);
                    table.ForeignKey(
                        name: "FK__TblOrdene__IdCli__2A4B4B5E",
                        column: x => x.IdCliente,
                        principalTable: "TblCliente",
                        principalColumn: "IdCliente");
                });

            migrationBuilder.CreateTable(
                name: "ProductoCategoria",
                columns: table => new
                {
                    IdProdCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProducto = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    IdCategoria = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Producto__208D92138A310C61", x => x.IdProdCategoria);
                    table.ForeignKey(
                        name: "FK__ProductoC__IdCat__31EC6D26",
                        column: x => x.IdCategoria,
                        principalTable: "TblCategoria",
                        principalColumn: "IdCategoria");
                    table.ForeignKey(
                        name: "FK__ProductoC__IdPro__30F848ED",
                        column: x => x.IdProducto,
                        principalTable: "TblProducto",
                        principalColumn: "IdProducto");
                });

            migrationBuilder.CreateTable(
                name: "ProductosXOrden",
                columns: table => new
                {
                    IdProdOrden = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdOrden = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    IdProducto = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Sku = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "numeric(15,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Producto__604613286DDF5391", x => x.IdProdOrden);
                    table.ForeignKey(
                        name: "FK__Productos__IdOrd__2D27B809",
                        column: x => x.IdOrden,
                        principalTable: "TblOrdenes",
                        principalColumn: "IdOrden");
                    table.ForeignKey(
                        name: "FK__Productos__IdPro__2E1BDC42",
                        column: x => x.IdProducto,
                        principalTable: "TblProducto",
                        principalColumn: "IdProducto");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductoCategoria_IdCategoria",
                table: "ProductoCategoria",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoCategoria_IdProducto",
                table: "ProductoCategoria",
                column: "IdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_ProductosXOrden_IdOrden",
                table: "ProductosXOrden",
                column: "IdOrden");

            migrationBuilder.CreateIndex(
                name: "IX_ProductosXOrden_IdProducto",
                table: "ProductosXOrden",
                column: "IdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_TblOrdenes_IdCliente",
                table: "TblOrdenes",
                column: "IdCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductoCategoria");

            migrationBuilder.DropTable(
                name: "ProductosXOrden");

            migrationBuilder.DropTable(
                name: "TblCategoria");

            migrationBuilder.DropTable(
                name: "TblOrdenes");

            migrationBuilder.DropTable(
                name: "TblProducto");

            migrationBuilder.DropTable(
                name: "TblCliente");
        }
    }
}
