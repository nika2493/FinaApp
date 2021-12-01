using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinaData.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Production_Countries_CountryId",
                table: "Production");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Production",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Production_Countries_CountryId",
                table: "Production",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Production_Countries_CountryId",
                table: "Production");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Production",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Production_Countries_CountryId",
                table: "Production",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
