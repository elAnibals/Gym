using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManager.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CityErrorCorrectionMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cities_cities_CityId",
                table: "cities");

            migrationBuilder.DropIndex(
                name: "IX_cities_CityId",
                table: "cities");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "cities");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "cities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_cities_CityId",
                table: "cities",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_cities_cities_CityId",
                table: "cities",
                column: "CityId",
                principalTable: "cities",
                principalColumn: "Id");
        }
    }
}
