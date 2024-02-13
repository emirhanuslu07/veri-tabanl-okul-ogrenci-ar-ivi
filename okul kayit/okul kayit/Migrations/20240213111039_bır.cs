using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace okul_kayit.Migrations
{
    /// <inheritdoc />
    public partial class bır : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "siniflar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sube = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seviye = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siniflar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ogrencilerr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    okulno = table.Column<int>(type: "int", nullable: false),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SınıfId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ogrencilerr", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ogrencilerr_siniflar_SınıfId",
                        column: x => x.SınıfId,
                        principalTable: "siniflar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ogrencilerr_SınıfId",
                table: "ogrencilerr",
                column: "SınıfId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ogrencilerr");

            migrationBuilder.DropTable(
                name: "siniflar");
        }
    }
}
