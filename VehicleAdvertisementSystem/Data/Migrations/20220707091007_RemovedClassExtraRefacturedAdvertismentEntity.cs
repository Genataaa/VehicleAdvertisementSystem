using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleAdvertisementSystem.Data.Migrations
{
    public partial class RemovedClassExtraRefacturedAdvertismentEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvertismentExtra");

            migrationBuilder.DropTable(
                name: "Extras");

            migrationBuilder.DropColumn(
                name: "CubicCapacity",
                table: "Advertisments");

            migrationBuilder.DropColumn(
                name: "ManifactureDate",
                table: "Advertisments");

            migrationBuilder.AddColumn<int>(
                name: "Month",
                table: "Advertisments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Advertisments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Month",
                table: "Advertisments");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Advertisments");

            migrationBuilder.AddColumn<double>(
                name: "CubicCapacity",
                table: "Advertisments",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ManifactureDate",
                table: "Advertisments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Extras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdvertismentExtra",
                columns: table => new
                {
                    AdvertismentsId = table.Column<int>(type: "int", nullable: false),
                    ExtrasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertismentExtra", x => new { x.AdvertismentsId, x.ExtrasId });
                    table.ForeignKey(
                        name: "FK_AdvertismentExtra_Advertisments_AdvertismentsId",
                        column: x => x.AdvertismentsId,
                        principalTable: "Advertisments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvertismentExtra_Extras_ExtrasId",
                        column: x => x.ExtrasId,
                        principalTable: "Extras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdvertismentExtra_ExtrasId",
                table: "AdvertismentExtra",
                column: "ExtrasId");
        }
    }
}
