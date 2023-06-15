using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManager.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class HandlingStructureMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_mesureTypes_MesureTypeId",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_MembershipSale_membershipTypes_MembershipTypeId",
                table: "MembershipSale");

            migrationBuilder.DropForeignKey(
                name: "FK_MembershipSale_sales_SaleId",
                table: "MembershipSale");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSale_mesureTypes_MesureTypeId",
                table: "ProductSale");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSale_sales_SaleId",
                table: "ProductSale");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSale",
                table: "ProductSale");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MembershipSale",
                table: "MembershipSale");

            migrationBuilder.RenameTable(
                name: "Inventories",
                newName: "inventories");

            migrationBuilder.RenameTable(
                name: "ProductSale",
                newName: "productSales");

            migrationBuilder.RenameTable(
                name: "MembershipSale",
                newName: "membershipSales");

            migrationBuilder.RenameIndex(
                name: "IX_Inventories_MesureTypeId",
                table: "inventories",
                newName: "IX_inventories_MesureTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSale_SaleId",
                table: "productSales",
                newName: "IX_productSales_SaleId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSale_MesureTypeId",
                table: "productSales",
                newName: "IX_productSales_MesureTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_MembershipSale_SaleId",
                table: "membershipSales",
                newName: "IX_membershipSales_SaleId");

            migrationBuilder.RenameIndex(
                name: "IX_MembershipSale_MembershipTypeId",
                table: "membershipSales",
                newName: "IX_membershipSales_MembershipTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_inventories",
                table: "inventories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_productSales",
                table: "productSales",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_membershipSales",
                table: "membershipSales",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_inventories_mesureTypes_MesureTypeId",
                table: "inventories",
                column: "MesureTypeId",
                principalTable: "mesureTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_membershipSales_membershipTypes_MembershipTypeId",
                table: "membershipSales",
                column: "MembershipTypeId",
                principalTable: "membershipTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_membershipSales_sales_SaleId",
                table: "membershipSales",
                column: "SaleId",
                principalTable: "sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productSales_mesureTypes_MesureTypeId",
                table: "productSales",
                column: "MesureTypeId",
                principalTable: "mesureTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productSales_sales_SaleId",
                table: "productSales",
                column: "SaleId",
                principalTable: "sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_inventories_mesureTypes_MesureTypeId",
                table: "inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_membershipSales_membershipTypes_MembershipTypeId",
                table: "membershipSales");

            migrationBuilder.DropForeignKey(
                name: "FK_membershipSales_sales_SaleId",
                table: "membershipSales");

            migrationBuilder.DropForeignKey(
                name: "FK_productSales_mesureTypes_MesureTypeId",
                table: "productSales");

            migrationBuilder.DropForeignKey(
                name: "FK_productSales_sales_SaleId",
                table: "productSales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_inventories",
                table: "inventories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productSales",
                table: "productSales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_membershipSales",
                table: "membershipSales");

            migrationBuilder.RenameTable(
                name: "inventories",
                newName: "Inventories");

            migrationBuilder.RenameTable(
                name: "productSales",
                newName: "ProductSale");

            migrationBuilder.RenameTable(
                name: "membershipSales",
                newName: "MembershipSale");

            migrationBuilder.RenameIndex(
                name: "IX_inventories_MesureTypeId",
                table: "Inventories",
                newName: "IX_Inventories_MesureTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_productSales_SaleId",
                table: "ProductSale",
                newName: "IX_ProductSale_SaleId");

            migrationBuilder.RenameIndex(
                name: "IX_productSales_MesureTypeId",
                table: "ProductSale",
                newName: "IX_ProductSale_MesureTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_membershipSales_SaleId",
                table: "MembershipSale",
                newName: "IX_MembershipSale_SaleId");

            migrationBuilder.RenameIndex(
                name: "IX_membershipSales_MembershipTypeId",
                table: "MembershipSale",
                newName: "IX_MembershipSale_MembershipTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSale",
                table: "ProductSale",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MembershipSale",
                table: "MembershipSale",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_mesureTypes_MesureTypeId",
                table: "Inventories",
                column: "MesureTypeId",
                principalTable: "mesureTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MembershipSale_membershipTypes_MembershipTypeId",
                table: "MembershipSale",
                column: "MembershipTypeId",
                principalTable: "membershipTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MembershipSale_sales_SaleId",
                table: "MembershipSale",
                column: "SaleId",
                principalTable: "sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSale_mesureTypes_MesureTypeId",
                table: "ProductSale",
                column: "MesureTypeId",
                principalTable: "mesureTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSale_sales_SaleId",
                table: "ProductSale",
                column: "SaleId",
                principalTable: "sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
