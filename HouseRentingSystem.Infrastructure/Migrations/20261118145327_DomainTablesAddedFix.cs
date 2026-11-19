using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DomainTablesAddedFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agets_AspNetUsers_UserId",
                table: "Agets");

            migrationBuilder.DropForeignKey(
                name: "FK_Houses_Agets_AgentId",
                table: "Houses");

            migrationBuilder.DropForeignKey(
                name: "FK_Houses_Categories_CategoryId",
                table: "Houses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Agets",
                table: "Agets");

            migrationBuilder.RenameTable(
                name: "Agets",
                newName: "Agents");

            migrationBuilder.RenameIndex(
                name: "IX_Agets_UserId",
                table: "Agents",
                newName: "IX_Agents_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Agents",
                table: "Agents",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Agents_AspNetUsers_UserId",
                table: "Agents",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_Agents_AgentId",
                table: "Houses",
                column: "AgentId",
                principalTable: "Agents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_Categories_CategoryId",
                table: "Houses",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agents_AspNetUsers_UserId",
                table: "Agents");

            migrationBuilder.DropForeignKey(
                name: "FK_Houses_Agents_AgentId",
                table: "Houses");

            migrationBuilder.DropForeignKey(
                name: "FK_Houses_Categories_CategoryId",
                table: "Houses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Agents",
                table: "Agents");

            migrationBuilder.RenameTable(
                name: "Agents",
                newName: "Agets");

            migrationBuilder.RenameIndex(
                name: "IX_Agents_UserId",
                table: "Agets",
                newName: "IX_Agets_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Agets",
                table: "Agets",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Agets_AspNetUsers_UserId",
                table: "Agets",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_Agets_AgentId",
                table: "Houses",
                column: "AgentId",
                principalTable: "Agets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_Categories_CategoryId",
                table: "Houses",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
