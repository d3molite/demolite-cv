using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demolite.Cv.Db.Migrations
{
    /// <inheritdoc />
    public partial class SkillEntries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SkillEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    TitleEn = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    Skills = table.Column<string>(type: "TEXT", maxLength: 512, nullable: false),
                    SkillsEn = table.Column<string>(type: "TEXT", maxLength: 512, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillEntries", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SkillEntries");
        }
    }
}
