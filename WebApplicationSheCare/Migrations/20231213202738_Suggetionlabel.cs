using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationSheCare.Migrations
{
    /// <inheritdoc />
    public partial class Suggetionlabel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Label",
                table: "Suggetions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Label",
                table: "Suggetions");
        }
    }
}
