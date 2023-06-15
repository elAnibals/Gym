using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManager.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SalesBaseMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_members_membershipTypes_MembershipTypeId",
                table: "members");

            migrationBuilder.AlterColumn<int>(
                name: "MembershipTypeId",
                table: "members",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsClosed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sales_members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_sales_MemberId",
                table: "sales",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_members_membershipTypes_MembershipTypeId",
                table: "members",
                column: "MembershipTypeId",
                principalTable: "membershipTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_members_membershipTypes_MembershipTypeId",
                table: "members");

            migrationBuilder.DropTable(
                name: "sales");

            migrationBuilder.AlterColumn<int>(
                name: "MembershipTypeId",
                table: "members",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_members_membershipTypes_MembershipTypeId",
                table: "members",
                column: "MembershipTypeId",
                principalTable: "membershipTypes",
                principalColumn: "Id");
        }
    }
}
