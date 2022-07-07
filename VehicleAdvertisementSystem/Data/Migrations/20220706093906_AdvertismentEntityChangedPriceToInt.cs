using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleAdvertisementSystem.Data.Migrations
{
    public partial class AdvertismentEntityChangedPriceToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Advertisments",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Advertisments",
                type: "decimal(9,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
