using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleAdvertisementSystem.Data.Migrations
{
    public partial class RenamedDatabaseProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvertismentExtra_Advertisments_VehiclesId",
                table: "AdvertismentExtra");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Advertisments_VehicleId",
                table: "Images");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdvertismentExtra",
                table: "AdvertismentExtra");

            migrationBuilder.DropIndex(
                name: "IX_AdvertismentExtra_VehiclesId",
                table: "AdvertismentExtra");

            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "Images",
                newName: "AdvertismentId");

            migrationBuilder.RenameIndex(
                name: "IX_Images_VehicleId",
                table: "Images",
                newName: "IX_Images_AdvertismentId");

            migrationBuilder.RenameColumn(
                name: "VehiclesId",
                table: "AdvertismentExtra",
                newName: "AdvertismentsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdvertismentExtra",
                table: "AdvertismentExtra",
                columns: new[] { "AdvertismentsId", "ExtrasId" });

            migrationBuilder.CreateIndex(
                name: "IX_AdvertismentExtra_ExtrasId",
                table: "AdvertismentExtra",
                column: "ExtrasId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvertismentExtra_Advertisments_AdvertismentsId",
                table: "AdvertismentExtra",
                column: "AdvertismentsId",
                principalTable: "Advertisments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Advertisments_AdvertismentId",
                table: "Images",
                column: "AdvertismentId",
                principalTable: "Advertisments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvertismentExtra_Advertisments_AdvertismentsId",
                table: "AdvertismentExtra");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Advertisments_AdvertismentId",
                table: "Images");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdvertismentExtra",
                table: "AdvertismentExtra");

            migrationBuilder.DropIndex(
                name: "IX_AdvertismentExtra_ExtrasId",
                table: "AdvertismentExtra");

            migrationBuilder.RenameColumn(
                name: "AdvertismentId",
                table: "Images",
                newName: "VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_Images_AdvertismentId",
                table: "Images",
                newName: "IX_Images_VehicleId");

            migrationBuilder.RenameColumn(
                name: "AdvertismentsId",
                table: "AdvertismentExtra",
                newName: "VehiclesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdvertismentExtra",
                table: "AdvertismentExtra",
                columns: new[] { "ExtrasId", "VehiclesId" });

            migrationBuilder.CreateIndex(
                name: "IX_AdvertismentExtra_VehiclesId",
                table: "AdvertismentExtra",
                column: "VehiclesId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvertismentExtra_Advertisments_VehiclesId",
                table: "AdvertismentExtra",
                column: "VehiclesId",
                principalTable: "Advertisments",
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
    }
}
