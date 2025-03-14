using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarLine.Model.Migrations
{
    /// <inheritdoc />
    public partial class updateTablePictureAndPhone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarShowRooms_AspNetUsers_AppSellerId",
                table: "CarShowRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceCenters_Addresses_AddressId",
                table: "MaintenanceCenters");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceCenters_AspNetUsers_AppSellerId",
                table: "MaintenanceCenters");

            migrationBuilder.DropForeignKey(
                name: "FK_Phones_AspNetUsers_AppSellerId",
                table: "Phones");

            migrationBuilder.DropForeignKey(
                name: "FK_Phones_Wanches_WanchId",
                table: "Phones");

            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_CarShowRooms_CarShowRoomId",
                table: "Pictures");

            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Wanches_WanchId",
                table: "Pictures");

            migrationBuilder.DropIndex(
                name: "IX_Pictures_CarShowRoomId",
                table: "Pictures");

            migrationBuilder.DropIndex(
                name: "IX_Pictures_WanchId",
                table: "Pictures");

            migrationBuilder.DropIndex(
                name: "IX_Phones_AppSellerId",
                table: "Phones");

            migrationBuilder.DropIndex(
                name: "IX_Phones_WanchId",
                table: "Phones");

            migrationBuilder.DropIndex(
                name: "IX_MaintenanceCenters_AddressId",
                table: "MaintenanceCenters");

            migrationBuilder.DropColumn(
                name: "CarShowRoomId",
                table: "Pictures");

            migrationBuilder.DropColumn(
                name: "WanchId",
                table: "Pictures");

            migrationBuilder.DropColumn(
                name: "AppSellerId",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "WanchId",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "MaintenanceCenters");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Equipments");

            migrationBuilder.AddColumn<int>(
                name: "PhoneId1",
                table: "Wanches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PictureUrlId",
                table: "Wanches",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AppSellerId",
                table: "MaintenanceCenters",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "AppSellerId",
                table: "CarShowRooms",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "PictureUrlId",
                table: "CarShowRooms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaintenanceCenterId",
                table: "Addresses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wanches_PhoneId1",
                table: "Wanches",
                column: "PhoneId1");

            migrationBuilder.CreateIndex(
                name: "IX_Wanches_PictureUrlId",
                table: "Wanches",
                column: "PictureUrlId");

            migrationBuilder.CreateIndex(
                name: "IX_CarShowRooms_PictureUrlId",
                table: "CarShowRooms",
                column: "PictureUrlId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_MaintenanceCenterId",
                table: "Addresses",
                column: "MaintenanceCenterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_MaintenanceCenters_MaintenanceCenterId",
                table: "Addresses",
                column: "MaintenanceCenterId",
                principalTable: "MaintenanceCenters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CarShowRooms_AspNetUsers_AppSellerId",
                table: "CarShowRooms",
                column: "AppSellerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CarShowRooms_Pictures_PictureUrlId",
                table: "CarShowRooms",
                column: "PictureUrlId",
                principalTable: "Pictures",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceCenters_AspNetUsers_AppSellerId",
                table: "MaintenanceCenters",
                column: "AppSellerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Wanches_Phones_PhoneId1",
                table: "Wanches",
                column: "PhoneId1",
                principalTable: "Phones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wanches_Pictures_PictureUrlId",
                table: "Wanches",
                column: "PictureUrlId",
                principalTable: "Pictures",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_MaintenanceCenters_MaintenanceCenterId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_CarShowRooms_AspNetUsers_AppSellerId",
                table: "CarShowRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_CarShowRooms_Pictures_PictureUrlId",
                table: "CarShowRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceCenters_AspNetUsers_AppSellerId",
                table: "MaintenanceCenters");

            migrationBuilder.DropForeignKey(
                name: "FK_Wanches_Phones_PhoneId1",
                table: "Wanches");

            migrationBuilder.DropForeignKey(
                name: "FK_Wanches_Pictures_PictureUrlId",
                table: "Wanches");

            migrationBuilder.DropIndex(
                name: "IX_Wanches_PhoneId1",
                table: "Wanches");

            migrationBuilder.DropIndex(
                name: "IX_Wanches_PictureUrlId",
                table: "Wanches");

            migrationBuilder.DropIndex(
                name: "IX_CarShowRooms_PictureUrlId",
                table: "CarShowRooms");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_MaintenanceCenterId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "PhoneId1",
                table: "Wanches");

            migrationBuilder.DropColumn(
                name: "PictureUrlId",
                table: "Wanches");

            migrationBuilder.DropColumn(
                name: "PictureUrlId",
                table: "CarShowRooms");

            migrationBuilder.DropColumn(
                name: "MaintenanceCenterId",
                table: "Addresses");

            migrationBuilder.AddColumn<int>(
                name: "CarShowRoomId",
                table: "Pictures",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WanchId",
                table: "Pictures",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppSellerId",
                table: "Phones",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WanchId",
                table: "Phones",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AppSellerId",
                table: "MaintenanceCenters",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "MaintenanceCenters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Equipments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "AppSellerId",
                table: "CarShowRooms",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_CarShowRoomId",
                table: "Pictures",
                column: "CarShowRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_WanchId",
                table: "Pictures",
                column: "WanchId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_AppSellerId",
                table: "Phones",
                column: "AppSellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_WanchId",
                table: "Phones",
                column: "WanchId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceCenters_AddressId",
                table: "MaintenanceCenters",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarShowRooms_AspNetUsers_AppSellerId",
                table: "CarShowRooms",
                column: "AppSellerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceCenters_Addresses_AddressId",
                table: "MaintenanceCenters",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceCenters_AspNetUsers_AppSellerId",
                table: "MaintenanceCenters",
                column: "AppSellerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_AspNetUsers_AppSellerId",
                table: "Phones",
                column: "AppSellerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_Wanches_WanchId",
                table: "Phones",
                column: "WanchId",
                principalTable: "Wanches",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_CarShowRooms_CarShowRoomId",
                table: "Pictures",
                column: "CarShowRoomId",
                principalTable: "CarShowRooms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_Wanches_WanchId",
                table: "Pictures",
                column: "WanchId",
                principalTable: "Wanches",
                principalColumn: "Id");
        }
    }
}
