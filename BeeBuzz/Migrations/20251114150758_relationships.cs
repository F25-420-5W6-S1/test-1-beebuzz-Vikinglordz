using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeeBuzz.Migrations
{
    /// <inheritdoc />
    public partial class relationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beehives_AspNetUsers_ApplicationUserId",
                table: "Beehives");

            migrationBuilder.DropIndex(
                name: "IX_Beehives_ApplicationUserId",
                table: "Beehives");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Beehives");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Beehives",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Beehives_UserId",
                table: "Beehives",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Beehives_AspNetUsers_UserId",
                table: "Beehives",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beehives_AspNetUsers_UserId",
                table: "Beehives");

            migrationBuilder.DropIndex(
                name: "IX_Beehives_UserId",
                table: "Beehives");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Beehives");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserId",
                table: "Beehives",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Beehives_ApplicationUserId",
                table: "Beehives",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Beehives_AspNetUsers_ApplicationUserId",
                table: "Beehives",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
