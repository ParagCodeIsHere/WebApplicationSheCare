using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationSheCare.Migrations
{
    /// <inheritdoc />
    public partial class SuggetionAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Diffuclulty",
                table: "Suggetions");

            migrationBuilder.DropColumn(
                name: "HaveBloating",
                table: "Suggetions");

            migrationBuilder.DropColumn(
                name: "HaveFatigue",
                table: "Suggetions");

            migrationBuilder.DropColumn(
                name: "HaveHeadache",
                table: "Suggetions");

            migrationBuilder.DropColumn(
                name: "HaveMoodSwing",
                table: "Suggetions");

            migrationBuilder.DropColumn(
                name: "HeavyFlow",
                table: "Suggetions");

            migrationBuilder.DropColumn(
                name: "Insomia",
                table: "Suggetions");

            migrationBuilder.DropColumn(
                name: "IrregularCycle",
                table: "Suggetions");

            migrationBuilder.DropColumn(
                name: "IsBadCramps",
                table: "Suggetions");

            migrationBuilder.DropColumn(
                name: "Itches",
                table: "Suggetions");

            migrationBuilder.DropColumn(
                name: "LegPain",
                table: "Suggetions");

            migrationBuilder.DropColumn(
                name: "LightFlow",
                table: "Suggetions");

            migrationBuilder.DropColumn(
                name: "ModerateFlow",
                table: "Suggetions");

            migrationBuilder.DropColumn(
                name: "ProblemInDigetion",
                table: "Suggetions");

            migrationBuilder.DropColumn(
                name: "RelieveByHerbs",
                table: "Suggetions");

            migrationBuilder.DropColumn(
                name: "RelieveByMeds",
                table: "Suggetions");

            migrationBuilder.DropColumn(
                name: "RelieveHeatingPod",
                table: "Suggetions");

            migrationBuilder.DropColumn(
                name: "SleepWell",
                table: "Suggetions");

            migrationBuilder.DropColumn(
                name: "Vomiting",
                table: "Suggetions");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Suggetions",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Answer",
                table: "Suggetions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Question",
                table: "Suggetions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Answer",
                table: "Suggetions");

            migrationBuilder.DropColumn(
                name: "Question",
                table: "Suggetions");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Suggetions",
                newName: "UserId");

            migrationBuilder.AddColumn<bool>(
                name: "Diffuclulty",
                table: "Suggetions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HaveBloating",
                table: "Suggetions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HaveFatigue",
                table: "Suggetions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HaveHeadache",
                table: "Suggetions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HaveMoodSwing",
                table: "Suggetions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HeavyFlow",
                table: "Suggetions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Insomia",
                table: "Suggetions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IrregularCycle",
                table: "Suggetions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsBadCramps",
                table: "Suggetions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Itches",
                table: "Suggetions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LegPain",
                table: "Suggetions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LightFlow",
                table: "Suggetions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ModerateFlow",
                table: "Suggetions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProblemInDigetion",
                table: "Suggetions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RelieveByHerbs",
                table: "Suggetions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RelieveByMeds",
                table: "Suggetions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RelieveHeatingPod",
                table: "Suggetions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SleepWell",
                table: "Suggetions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Vomiting",
                table: "Suggetions",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
