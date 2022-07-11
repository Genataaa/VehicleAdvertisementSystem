using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleAdvertisementSystem.Data.Migrations
{
    public partial class EurostanderdNotNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisments_Eurostandards_EurostandardId",
                table: "Advertisments");

            migrationBuilder.AlterColumn<int>(
                name: "EurostandardId",
                table: "Advertisments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisments_Eurostandards_EurostandardId",
                table: "Advertisments",
                column: "EurostandardId",
                principalTable: "Eurostandards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisments_Eurostandards_EurostandardId",
                table: "Advertisments");

            migrationBuilder.AlterColumn<int>(
                name: "EurostandardId",
                table: "Advertisments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisments_Eurostandards_EurostandardId",
                table: "Advertisments",
                column: "EurostandardId",
                principalTable: "Eurostandards",
                principalColumn: "Id");
        }
    }
}
