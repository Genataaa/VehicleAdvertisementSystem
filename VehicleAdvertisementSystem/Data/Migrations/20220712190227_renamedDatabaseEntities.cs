using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleAdvertisementSystem.Data.Migrations
{
    public partial class renamedDatabaseEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Advertisments_AdvertismentId",
                table: "Images");

            migrationBuilder.DropTable(
                name: "Advertisments");

            migrationBuilder.DropIndex(
                name: "IX_Images_AdvertismentId",
                table: "Images");

            migrationBuilder.AddColumn<int>(
                name: "AdvertisementId",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Advertisements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleTypeId = table.Column<int>(type: "int", nullable: false),
                    ConditionStatusId = table.Column<int>(type: "int", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Mileage = table.Column<long>(type: "bigint", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    TransmissionId = table.Column<int>(type: "int", nullable: false),
                    FuelId = table.Column<int>(type: "int", nullable: false),
                    Power = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    NumberOfDoors = table.Column<int>(type: "int", nullable: false),
                    NumberOfSeats = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EurostandardId = table.Column<int>(type: "int", nullable: false),
                    NewImportation = table.Column<bool>(type: "bit", nullable: false),
                    DateOfPublication = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViewsCounter = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Advertisements_ConditionStatuses_ConditionStatusId",
                        column: x => x.ConditionStatusId,
                        principalTable: "ConditionStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advertisements_Eurostandards_EurostandardId",
                        column: x => x.EurostandardId,
                        principalTable: "Eurostandards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advertisements_FuelTypes_FuelId",
                        column: x => x.FuelId,
                        principalTable: "FuelTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advertisements_Transmissions_TransmissionId",
                        column: x => x.TransmissionId,
                        principalTable: "Transmissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advertisements_VehicleTypes_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_AdvertisementId",
                table: "Images",
                column: "AdvertisementId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_ConditionStatusId",
                table: "Advertisements",
                column: "ConditionStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_EurostandardId",
                table: "Advertisements",
                column: "EurostandardId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_FuelId",
                table: "Advertisements",
                column: "FuelId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_TransmissionId",
                table: "Advertisements",
                column: "TransmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_VehicleTypeId",
                table: "Advertisements",
                column: "VehicleTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Advertisements_AdvertisementId",
                table: "Images",
                column: "AdvertisementId",
                principalTable: "Advertisements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Advertisements_AdvertisementId",
                table: "Images");

            migrationBuilder.DropTable(
                name: "Advertisements");

            migrationBuilder.DropIndex(
                name: "IX_Images_AdvertisementId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "AdvertisementId",
                table: "Images");

            migrationBuilder.CreateTable(
                name: "Advertisments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConditionStatusId = table.Column<int>(type: "int", nullable: false),
                    EurostandardId = table.Column<int>(type: "int", nullable: false),
                    FuelId = table.Column<int>(type: "int", nullable: false),
                    TransmissionId = table.Column<int>(type: "int", nullable: false),
                    VehicleTypeId = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DateOfPublication = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Mileage = table.Column<long>(type: "bigint", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    NewImportation = table.Column<bool>(type: "bit", nullable: false),
                    NumberOfDoors = table.Column<int>(type: "int", nullable: false),
                    NumberOfSeats = table.Column<int>(type: "int", nullable: false),
                    Power = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ViewsCounter = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Advertisments_ConditionStatuses_ConditionStatusId",
                        column: x => x.ConditionStatusId,
                        principalTable: "ConditionStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advertisments_Eurostandards_EurostandardId",
                        column: x => x.EurostandardId,
                        principalTable: "Eurostandards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advertisments_FuelTypes_FuelId",
                        column: x => x.FuelId,
                        principalTable: "FuelTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advertisments_Transmissions_TransmissionId",
                        column: x => x.TransmissionId,
                        principalTable: "Transmissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advertisments_VehicleTypes_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_AdvertismentId",
                table: "Images",
                column: "AdvertismentId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisments_ConditionStatusId",
                table: "Advertisments",
                column: "ConditionStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisments_EurostandardId",
                table: "Advertisments",
                column: "EurostandardId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisments_FuelId",
                table: "Advertisments",
                column: "FuelId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisments_TransmissionId",
                table: "Advertisments",
                column: "TransmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisments_VehicleTypeId",
                table: "Advertisments",
                column: "VehicleTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Advertisments_AdvertismentId",
                table: "Images",
                column: "AdvertismentId",
                principalTable: "Advertisments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
