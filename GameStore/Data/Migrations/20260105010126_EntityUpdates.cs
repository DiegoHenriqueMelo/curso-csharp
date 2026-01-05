using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameStore.DataMigrations
{
    /// <inheritdoc />
    public partial class EntityUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Release",
                table: "Games",
                newName: "ReleaseDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "Games",
                newName: "Release");
        }
    }
}
