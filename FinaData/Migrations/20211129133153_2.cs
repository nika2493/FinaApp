using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinaData.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductionCode",
                table: "Production",
                newName: "Code");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Production",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Production",
                newName: "ProductionCode");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Production",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
