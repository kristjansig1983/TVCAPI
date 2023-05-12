using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TVCAPI.Migrations
{
    /// <inheritdoc />
    public partial class TryingSongs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "AlbumId", "SongName" },
                values: new object[] { 1, 1, "Need a Woman" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 1);
        }
    }
}
