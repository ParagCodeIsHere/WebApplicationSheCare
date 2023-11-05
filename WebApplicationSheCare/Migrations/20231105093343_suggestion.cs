using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationSheCare.Migrations
{
    /// <inheritdoc />
    public partial class suggestion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suggetions",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HaveHeadache = table.Column<bool>(type: "bit", nullable: false),
                    RelieveByMeds = table.Column<bool>(type: "bit", nullable: false),
                    RelieveByHerbs = table.Column<bool>(type: "bit", nullable: false),
                    RelieveHeatingPod = table.Column<bool>(type: "bit", nullable: false),
                    HaveBloating = table.Column<bool>(type: "bit", nullable: false),
                    HaveMoodSwing = table.Column<bool>(type: "bit", nullable: false),
                    HaveFatigue = table.Column<bool>(type: "bit", nullable: false),
                    HeavyFlow = table.Column<bool>(type: "bit", nullable: false),
                    IrregularCycle = table.Column<bool>(type: "bit", nullable: false),
                    Itches = table.Column<bool>(type: "bit", nullable: false),
                    IsBadCramps = table.Column<bool>(type: "bit", nullable: false),
                    LegPain = table.Column<bool>(type: "bit", nullable: false),
                    LightFlow = table.Column<bool>(type: "bit", nullable: false),
                    ModerateFlow = table.Column<bool>(type: "bit", nullable: false),
                    ProblemInDigetion = table.Column<bool>(type: "bit", nullable: false),
                    SleepWell = table.Column<bool>(type: "bit", nullable: false),
                    Insomia = table.Column<bool>(type: "bit", nullable: false),
                    Diffuclulty = table.Column<bool>(type: "bit", nullable: false),
                    Vomiting = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suggetions", x => x.UserId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suggetions");
        }
    }
}
