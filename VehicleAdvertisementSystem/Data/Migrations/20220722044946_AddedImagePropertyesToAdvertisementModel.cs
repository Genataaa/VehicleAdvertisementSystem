using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleAdvertisementSystem.Data.Migrations
{
    public partial class AddedImagePropertyesToAdvertisementModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Advertisements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Advertisements");
        }
    }
}
