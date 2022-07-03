using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleAdvertisementSystem.Data.Migrations
{
    public partial class MergedAdvertismentAndVihecleTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Vehicles_VehicleId",
                table: "Images");

            migrationBuilder.DropTable(
                name: "ExtraVehicle");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "Advertisments",
                newName: "VehicleTypeId");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Advertisments",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ConditionStatusId",
                table: "Advertisments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "CubicCapacity",
                table: "Advertisments",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "EurostandardId",
                table: "Advertisments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FuelId",
                table: "Advertisments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Make",
                table: "Advertisments",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ManifactureDate",
                table: "Advertisments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "Mileage",
                table: "Advertisments",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Advertisments",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "NewImportation",
                table: "Advertisments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfDoors",
                table: "Advertisments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfSeats",
                table: "Advertisments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Power",
                table: "Advertisments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Advertisments",
                type: "decimal(9,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "TransmissionId",
                table: "Advertisments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AdvertismentExtra",
                columns: table => new
                {
                    ExtrasId = table.Column<int>(type: "int", nullable: false),
                    VehiclesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertismentExtra", x => new { x.ExtrasId, x.VehiclesId });
                    table.ForeignKey(
                        name: "FK_AdvertismentExtra_Advertisments_VehiclesId",
                        column: x => x.VehiclesId,
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

            migrationBuilder.CreateIndex(
                name: "IX_AdvertismentExtra_VehiclesId",
                table: "AdvertismentExtra",
                column: "VehiclesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisments_ConditionStatuses_ConditionStatusId",
                table: "Advertisments",
                column: "ConditionStatusId",
                principalTable: "ConditionStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisments_Eurostandards_EurostandardId",
                table: "Advertisments",
                column: "EurostandardId",
                principalTable: "Eurostandards",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisments_FuelTypes_FuelId",
                table: "Advertisments",
                column: "FuelId",
                principalTable: "FuelTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisments_Transmissions_TransmissionId",
                table: "Advertisments",
                column: "TransmissionId",
                principalTable: "Transmissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisments_VehicleTypes_VehicleTypeId",
                table: "Advertisments",
                column: "VehicleTypeId",
                principalTable: "VehicleTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Advertisments_VehicleId",
                table: "Images",
                column: "VehicleId",
                principalTable: "Advertisments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisments_ConditionStatuses_ConditionStatusId",
                table: "Advertisments");

            migrationBuilder.DropForeignKey(
                name: "FK_Advertisments_Eurostandards_EurostandardId",
                table: "Advertisments");

            migrationBuilder.DropForeignKey(
                name: "FK_Advertisments_FuelTypes_FuelId",
                table: "Advertisments");

            migrationBuilder.DropForeignKey(
                name: "FK_Advertisments_Transmissions_TransmissionId",
                table: "Advertisments");

            migrationBuilder.DropForeignKey(
                name: "FK_Advertisments_VehicleTypes_VehicleTypeId",
                table: "Advertisments");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Advertisments_VehicleId",
                table: "Images");

            migrationBuilder.DropTable(
                name: "AdvertismentExtra");

            migrationBuilder.DropIndex(
                name: "IX_Advertisments_ConditionStatusId",
                table: "Advertisments");

            migrationBuilder.DropIndex(
                name: "IX_Advertisments_EurostandardId",
                table: "Advertisments");

            migrationBuilder.DropIndex(
                name: "IX_Advertisments_FuelId",
                table: "Advertisments");

            migrationBuilder.DropIndex(
                name: "IX_Advertisments_TransmissionId",
                table: "Advertisments");

            migrationBuilder.DropIndex(
                name: "IX_Advertisments_VehicleTypeId",
                table: "Advertisments");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Advertisments");

            migrationBuilder.DropColumn(
                name: "ConditionStatusId",
                table: "Advertisments");

            migrationBuilder.DropColumn(
                name: "CubicCapacity",
                table: "Advertisments");

            migrationBuilder.DropColumn(
                name: "EurostandardId",
                table: "Advertisments");

            migrationBuilder.DropColumn(
                name: "FuelId",
                table: "Advertisments");

            migrationBuilder.DropColumn(
                name: "Make",
                table: "Advertisments");

            migrationBuilder.DropColumn(
                name: "ManifactureDate",
                table: "Advertisments");

            migrationBuilder.DropColumn(
                name: "Mileage",
                table: "Advertisments");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Advertisments");

            migrationBuilder.DropColumn(
                name: "NewImportation",
                table: "Advertisments");

            migrationBuilder.DropColumn(
                name: "NumberOfDoors",
                table: "Advertisments");

            migrationBuilder.DropColumn(
                name: "NumberOfSeats",
                table: "Advertisments");

            migrationBuilder.DropColumn(
                name: "Power",
                table: "Advertisments");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Advertisments");

            migrationBuilder.DropColumn(
                name: "TransmissionId",
                table: "Advertisments");

            migrationBuilder.RenameColumn(
                name: "VehicleTypeId",
                table: "Advertisments",
                newName: "VehicleId");

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvertismentId = table.Column<int>(type: "int", nullable: false),
                    ConditionStatusId = table.Column<int>(type: "int", nullable: false),
                    EurostandardId = table.Column<int>(type: "int", nullable: true),
                    FuelId = table.Column<int>(type: "int", nullable: false),
                    TransmissionId = table.Column<int>(type: "int", nullable: false),
                    VehicleTypeId = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CubicCapacity = table.Column<double>(type: "float", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ManifactureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mileage = table.Column<long>(type: "bigint", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NewImportation = table.Column<bool>(type: "bit", nullable: false),
                    NumberOfDoors = table.Column<int>(type: "int", nullable: false),
                    NumberOfSeats = table.Column<int>(type: "int", nullable: false),
                    Power = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(9,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Advertisments_AdvertismentId",
                        column: x => x.AdvertismentId,
                        principalTable: "Advertisments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_ConditionStatuses_ConditionStatusId",
                        column: x => x.ConditionStatusId,
                        principalTable: "ConditionStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_Eurostandards_EurostandardId",
                        column: x => x.EurostandardId,
                        principalTable: "Eurostandards",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicles_FuelTypes_FuelId",
                        column: x => x.FuelId,
                        principalTable: "FuelTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_Transmissions_TransmissionId",
                        column: x => x.TransmissionId,
                        principalTable: "Transmissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_VehicleTypes_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExtraVehicle",
                columns: table => new
                {
                    ExtrasId = table.Column<int>(type: "int", nullable: false),
                    VehiclesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraVehicle", x => new { x.ExtrasId, x.VehiclesId });
                    table.ForeignKey(
                        name: "FK_ExtraVehicle_Extras_ExtrasId",
                        column: x => x.ExtrasId,
                        principalTable: "Extras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExtraVehicle_Vehicles_VehiclesId",
                        column: x => x.VehiclesId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExtraVehicle_VehiclesId",
                table: "ExtraVehicle",
                column: "VehiclesId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_AdvertismentId",
                table: "Vehicles",
                column: "AdvertismentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ConditionStatusId",
                table: "Vehicles",
                column: "ConditionStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_EurostandardId",
                table: "Vehicles",
                column: "EurostandardId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_FuelId",
                table: "Vehicles",
                column: "FuelId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_TransmissionId",
                table: "Vehicles",
                column: "TransmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleTypeId",
                table: "Vehicles",
                column: "VehicleTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Vehicles_VehicleId",
                table: "Images",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
