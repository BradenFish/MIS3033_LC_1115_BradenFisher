using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MIS3033_LC_1115_BradenFisher.Migrations
{
    /// <inheritdoc />
    public partial class createdb3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentId",
                table: "Profiles",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_StudentId",
                table: "Profiles",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Students_StudentId",
                table: "Profiles",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Students_StudentId",
                table: "Profiles");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_StudentId",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Profiles");
        }
    }
}
