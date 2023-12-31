using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostService.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_UserDeets_PostOwnerId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "UserDeets");

            migrationBuilder.DropIndex(
                name: "IX_Posts_PostOwnerId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PostOwnerId",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Posts");

            migrationBuilder.AddColumn<Guid>(
                name: "PostOwnerId",
                table: "Posts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "UserDeets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDeets", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostOwnerId",
                table: "Posts",
                column: "PostOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_UserDeets_PostOwnerId",
                table: "Posts",
                column: "PostOwnerId",
                principalTable: "UserDeets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
