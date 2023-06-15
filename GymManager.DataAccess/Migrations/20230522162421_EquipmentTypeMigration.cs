using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManager.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class EquipmentTypeMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "cities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "equipmentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_equipmentTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_equipmentTypes_cities_CityId",
                        column: x => x.CityId,
                        principalTable: "cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_cities_CityId",
                table: "cities",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_equipmentTypes_CityId",
                table: "equipmentTypes",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_cities_cities_CityId",
                table: "cities",
                column: "CityId",
                principalTable: "cities",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cities_cities_CityId",
                table: "cities");

            migrationBuilder.DropTable(
                name: "equipmentTypes");

            migrationBuilder.DropIndex(
                name: "IX_cities_CityId",
                table: "cities");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "cities");
        }
    }
}
