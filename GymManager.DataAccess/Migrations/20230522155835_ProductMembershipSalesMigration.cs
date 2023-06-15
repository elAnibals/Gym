using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManager.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ProductMembershipSalesMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MembershipSale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MembershipTypeId = table.Column<int>(type: "int", nullable: false),
                    SaleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipSale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MembershipSale_membershipTypes_MembershipTypeId",
                        column: x => x.MembershipTypeId,
                        principalTable: "membershipTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MembershipSale_sales_SaleId",
                        column: x => x.SaleId,
                        principalTable: "sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductSale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MesureTypeId = table.Column<int>(type: "int", nullable: false),
                    SaleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSale_mesureTypes_MesureTypeId",
                        column: x => x.MesureTypeId,
                        principalTable: "mesureTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSale_sales_SaleId",
                        column: x => x.SaleId,
                        principalTable: "sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_MembershipSale_MembershipTypeId",
                table: "MembershipSale",
                column: "MembershipTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MembershipSale_SaleId",
                table: "MembershipSale",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSale_MesureTypeId",
                table: "ProductSale",
                column: "MesureTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSale_SaleId",
                table: "ProductSale",
                column: "SaleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MembershipSale");

            migrationBuilder.DropTable(
                name: "ProductSale");
        }
    }
}
