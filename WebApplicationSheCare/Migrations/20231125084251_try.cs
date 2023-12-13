using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationSheCare.Migrations
{
    /// <inheritdoc />
    public partial class @try : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSuggetion");

            migrationBuilder.CreateTable(
                name: "selectedSuggetions",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SuggetionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_selectedSuggetions", x => new { x.UserId, x.SuggetionId });
                    table.ForeignKey(
                        name: "FK_selectedSuggetions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_selectedSuggetions_Suggetions_SuggetionId",
                        column: x => x.SuggetionId,
                        principalTable: "Suggetions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_selectedSuggetions_SuggetionId",
                table: "selectedSuggetions",
                column: "SuggetionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "selectedSuggetions");

            migrationBuilder.CreateTable(
                name: "UserSuggetion",
                columns: table => new
                {
                    SuggetionsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSuggetion", x => new { x.SuggetionsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_UserSuggetion_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSuggetion_Suggetions_SuggetionsId",
                        column: x => x.SuggetionsId,
                        principalTable: "Suggetions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserSuggetion_UsersId",
                table: "UserSuggetion",
                column: "UsersId");
        }
    }
}
