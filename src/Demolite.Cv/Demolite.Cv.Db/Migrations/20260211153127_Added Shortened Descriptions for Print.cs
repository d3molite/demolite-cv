using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demolite.Cv.Db.Migrations
{
    /// <inheritdoc />
    public partial class AddedShortenedDescriptionsforPrint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescriptionShort",
                table: "WorkEntries",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionShortEn",
                table: "WorkEntries",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionShort",
                table: "ProjectEntries",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionShortEn",
                table: "ProjectEntries",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionShort",
                table: "EducationEntries",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionShortEn",
                table: "EducationEntries",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionShort",
                table: "WorkEntries");

            migrationBuilder.DropColumn(
                name: "DescriptionShortEn",
                table: "WorkEntries");

            migrationBuilder.DropColumn(
                name: "DescriptionShort",
                table: "ProjectEntries");

            migrationBuilder.DropColumn(
                name: "DescriptionShortEn",
                table: "ProjectEntries");

            migrationBuilder.DropColumn(
                name: "DescriptionShort",
                table: "EducationEntries");

            migrationBuilder.DropColumn(
                name: "DescriptionShortEn",
                table: "EducationEntries");
        }
    }
}
