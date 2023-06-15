using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManager.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MembershipTypesMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ActivationDate",
                table: "members",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "MembershipTypeId",
                table: "members",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "members",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "membershipTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_membershipTypes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_members_MembershipTypeId",
                table: "members",
                column: "MembershipTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_members_membershipTypes_MembershipTypeId",
                table: "members",
                column: "MembershipTypeId",
                principalTable: "membershipTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_members_membershipTypes_MembershipTypeId",
                table: "members");

            migrationBuilder.DropTable(
                name: "membershipTypes");

            migrationBuilder.DropIndex(
                name: "IX_members_MembershipTypeId",
                table: "members");

            migrationBuilder.DropColumn(
                name: "ActivationDate",
                table: "members");

            migrationBuilder.DropColumn(
                name: "MembershipTypeId",
                table: "members");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "members");
        }
    }
}
