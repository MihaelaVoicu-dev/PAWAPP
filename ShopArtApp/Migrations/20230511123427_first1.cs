using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopArtApp.Migrations
{
    public partial class first1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillAddresses_Users_UserId",
                table: "BillAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_BillAddresses_BillAddressId",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_UserId",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_CommandDetails_CommandDetailId",
                table: "Products");

            migrationBuilder.AddForeignKey(
                name: "FK_BillAddresses_Users_UserId",
                table: "BillAddresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_BillAddresses_BillAddressId",
                table: "Commands",
                column: "BillAddressId",
                principalTable: "BillAddresses",
                principalColumn: "BillAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_UserId",
                table: "Commands",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "IdCategory");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CommandDetails_CommandDetailId",
                table: "Products",
                column: "CommandDetailId",
                principalTable: "CommandDetails",
                principalColumn: "CommandDetailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillAddresses_Users_UserId",
                table: "BillAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_BillAddresses_BillAddressId",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Users_UserId",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_CommandDetails_CommandDetailId",
                table: "Products");

            migrationBuilder.AddForeignKey(
                name: "FK_BillAddresses_Users_UserId",
                table: "BillAddresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_BillAddresses_BillAddressId",
                table: "Commands",
                column: "BillAddressId",
                principalTable: "BillAddresses",
                principalColumn: "BillAddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Users_UserId",
                table: "Commands",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "IdCategory",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CommandDetails_CommandDetailId",
                table: "Products",
                column: "CommandDetailId",
                principalTable: "CommandDetails",
                principalColumn: "CommandDetailId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
