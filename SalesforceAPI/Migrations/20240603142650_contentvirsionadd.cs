using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesforceAPI.Migrations
{
    /// <inheritdoc />
    public partial class contentvirsionadd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContentVersions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PathOnClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VersionData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstPublishLocationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UCDocumentType = table.Column<int>(type: "int", nullable: true),
                    LinkedEntityId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssociatedProvider = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentVersions", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContentVersions");
        }
    }
}
