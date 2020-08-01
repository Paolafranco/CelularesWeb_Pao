using Microsoft.EntityFrameworkCore.Migrations;

namespace DeberPrograPao1.Migrations
{
    public partial class BodegaOtros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Celulares_Bodegas_BodegaId",
                table: "Celulares");

            migrationBuilder.DropForeignKey(
                name: "FK_Computadoras_Bodegas_BodegaId",
                table: "Computadoras");

            migrationBuilder.DropForeignKey(
                name: "FK_Impresoras_Bodegas_BodegaId",
                table: "Impresoras");

            migrationBuilder.DropForeignKey(
                name: "FK_Mouses_Bodegas_BodegaId",
                table: "Mouses");

            migrationBuilder.DropForeignKey(
                name: "FK_Tablets_Bodegas_BodegaId",
                table: "Tablets");

            migrationBuilder.DropTable(
                name: "Bodegas");

            migrationBuilder.DropIndex(
                name: "IX_Tablets_BodegaId",
                table: "Tablets");

            migrationBuilder.DropIndex(
                name: "IX_Mouses_BodegaId",
                table: "Mouses");

            migrationBuilder.DropIndex(
                name: "IX_Impresoras_BodegaId",
                table: "Impresoras");

            migrationBuilder.DropIndex(
                name: "IX_Computadoras_BodegaId",
                table: "Computadoras");

            migrationBuilder.DropIndex(
                name: "IX_Celulares_BodegaId",
                table: "Celulares");

            migrationBuilder.DropColumn(
                name: "BodegaId",
                table: "Tablets");

            migrationBuilder.DropColumn(
                name: "BodegaId",
                table: "Mouses");

            migrationBuilder.DropColumn(
                name: "BodegaId",
                table: "Impresoras");

            migrationBuilder.DropColumn(
                name: "BodegaId",
                table: "Computadoras");

            migrationBuilder.DropColumn(
                name: "BodegaId",
                table: "Celulares");

            migrationBuilder.AddColumn<int>(
                name: "CelularId",
                table: "Personas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ComputadoraId",
                table: "Personas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ImpresoraId",
                table: "Personas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MouseId",
                table: "Personas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TabletId",
                table: "Personas",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Celulares",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "Celulares",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_CelularId",
                table: "Personas",
                column: "CelularId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_ComputadoraId",
                table: "Personas",
                column: "ComputadoraId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_ImpresoraId",
                table: "Personas",
                column: "ImpresoraId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_MouseId",
                table: "Personas",
                column: "MouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_TabletId",
                table: "Personas",
                column: "TabletId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Celulares_CelularId",
                table: "Personas",
                column: "CelularId",
                principalTable: "Celulares",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Computadoras_ComputadoraId",
                table: "Personas",
                column: "ComputadoraId",
                principalTable: "Computadoras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Impresoras_ImpresoraId",
                table: "Personas",
                column: "ImpresoraId",
                principalTable: "Impresoras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Mouses_MouseId",
                table: "Personas",
                column: "MouseId",
                principalTable: "Mouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Tablets_TabletId",
                table: "Personas",
                column: "TabletId",
                principalTable: "Tablets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Celulares_CelularId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Computadoras_ComputadoraId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Impresoras_ImpresoraId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Mouses_MouseId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Tablets_TabletId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_CelularId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_ComputadoraId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_ImpresoraId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_MouseId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_TabletId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "CelularId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "ComputadoraId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "ImpresoraId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "MouseId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "TabletId",
                table: "Personas");

            migrationBuilder.AddColumn<int>(
                name: "BodegaId",
                table: "Tablets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BodegaId",
                table: "Mouses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BodegaId",
                table: "Impresoras",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BodegaId",
                table: "Computadoras",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Celulares",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "Celulares",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BodegaId",
                table: "Celulares",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Bodegas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BodegueroId = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bodegas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bodegas_Personas_BodegueroId",
                        column: x => x.BodegueroId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tablets_BodegaId",
                table: "Tablets",
                column: "BodegaId");

            migrationBuilder.CreateIndex(
                name: "IX_Mouses_BodegaId",
                table: "Mouses",
                column: "BodegaId");

            migrationBuilder.CreateIndex(
                name: "IX_Impresoras_BodegaId",
                table: "Impresoras",
                column: "BodegaId");

            migrationBuilder.CreateIndex(
                name: "IX_Computadoras_BodegaId",
                table: "Computadoras",
                column: "BodegaId");

            migrationBuilder.CreateIndex(
                name: "IX_Celulares_BodegaId",
                table: "Celulares",
                column: "BodegaId");

            migrationBuilder.CreateIndex(
                name: "IX_Bodegas_BodegueroId",
                table: "Bodegas",
                column: "BodegueroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Celulares_Bodegas_BodegaId",
                table: "Celulares",
                column: "BodegaId",
                principalTable: "Bodegas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Computadoras_Bodegas_BodegaId",
                table: "Computadoras",
                column: "BodegaId",
                principalTable: "Bodegas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Impresoras_Bodegas_BodegaId",
                table: "Impresoras",
                column: "BodegaId",
                principalTable: "Bodegas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mouses_Bodegas_BodegaId",
                table: "Mouses",
                column: "BodegaId",
                principalTable: "Bodegas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tablets_Bodegas_BodegaId",
                table: "Tablets",
                column: "BodegaId",
                principalTable: "Bodegas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
