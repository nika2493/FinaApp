using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinaData.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Production_Countries_CountryId",
                table: "Production");

            migrationBuilder.DropForeignKey(
                name: "FK_Production_Groups_GroupId",
                table: "Production");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Production",
                table: "Production");

            migrationBuilder.RenameTable(
                name: "Production",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_Production_GroupId",
                table: "Products",
                newName: "IX_Products_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Production_CountryId",
                table: "Products",
                newName: "IX_Products_CountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Countries_CountryId",
                table: "Products",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Groups_GroupId",
                table: "Products",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Countries_CountryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Groups_GroupId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Production");

            migrationBuilder.RenameIndex(
                name: "IX_Products_GroupId",
                table: "Production",
                newName: "IX_Production_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CountryId",
                table: "Production",
                newName: "IX_Production_CountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Production",
                table: "Production",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Production_Countries_CountryId",
                table: "Production",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Production_Groups_GroupId",
                table: "Production",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id");
        }
    }
}
