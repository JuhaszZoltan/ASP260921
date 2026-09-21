using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP260921.Migrations;

/// <inheritdoc />
public partial class InitialCreate : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Movies",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Title = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                Genre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                Price = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Movies", x => x.Id);
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Movies");
    }
}
