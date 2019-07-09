using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalRandkowy.API.Migrations
{
    public partial class ExtendedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Children",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Education",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EyeColor",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FreeTime",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FriendeWouldDescribeMe",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Growth",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HairColor",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ILike",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdoNotLike",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Interests",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItFeelsBestIn",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Languages",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastActive",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LookingFor",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MakesMeLaugh",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MartialStatus",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Motto",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Movies",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Music",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Personality",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Profession",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sport",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZodiacSign",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    IsMain = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_UserId",
                table: "Photos",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropColumn(
                name: "Children",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Education",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EyeColor",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FreeTime",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FriendeWouldDescribeMe",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Growth",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "HairColor",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ILike",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IdoNotLike",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Interests",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ItFeelsBestIn",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Languages",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastActive",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LookingFor",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MakesMeLaugh",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MartialStatus",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Motto",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Movies",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Music",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Personality",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Profession",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Sport",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ZodiacSign",
                table: "Users");
        }
    }
}
