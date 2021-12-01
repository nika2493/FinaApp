using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinaData.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Production_Groups_GroupId",
                table: "Production");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "Production",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Production_Groups_GroupId",
                table: "Production",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Production_Groups_GroupId",
                table: "Production");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "Production",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Production_Groups_GroupId",
                table: "Production",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
