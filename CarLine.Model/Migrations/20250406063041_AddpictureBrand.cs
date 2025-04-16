using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarLine.Model.Migrations
{
    /// <inheritdoc />
    public partial class AddpictureBrand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_CarBrands_CarBrandId",
                table: "Pictures");

            migrationBuilder.DropIndex(
                name: "IX_Pictures_CarBrandId",
                table: "Pictures");

            migrationBuilder.DropColumn(
                name: "CarBrandId",
                table: "Pictures");

            migrationBuilder.CreateTable(
                name: "PictureBrand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: true),
                    CarBrandId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PictureBrand", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PictureBrand_CarBrands_CarBrandId",
                        column: x => x.CarBrandId,
                        principalTable: "CarBrands",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PictureBrand_CarBrandId",
                table: "PictureBrand",
                column: "CarBrandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PictureBrand");

            migrationBuilder.AddColumn<int>(
                name: "CarBrandId",
                table: "Pictures",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_CarBrandId",
                table: "Pictures",
                column: "CarBrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_CarBrands_CarBrandId",
                table: "Pictures",
                column: "CarBrandId",
                principalTable: "CarBrands",
                principalColumn: "Id");
        }
    }
}
