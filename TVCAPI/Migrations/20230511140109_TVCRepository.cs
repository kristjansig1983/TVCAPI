using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TVCAPI.Migrations
{
    /// <inheritdoc />
    public partial class TVCRepository : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AlbumCoverUrl", "AlbumName", "AlbumYear" },
                values: new object[] { 1, "https://www.spirit-of-metal.com/les%20goupes/T/The%20Vintage%20Caravan/The%20Vintage%20Caravan/The%20Vintage%20Caravan.jpg", "The Vintage Caravan", 2009 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 1);
        }
    }
}
