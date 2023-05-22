using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TVCAPI.Migrations
{
    /// <inheritdoc />
    public partial class Fixedoneimageurl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 5,
                column: "AlbumCoverUrl",
                value: "https://www.spirit-of-metal.com/les%20goupes/T/The%20Vintage%20Caravan/Monuments/Monuments_4110.jpeg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 5,
                column: "AlbumCoverUrl",
                value: "https://www.spirit-of-metal.com/les%20goupes/T/The%20Vintage%20Caravan/Gateways/Gateways_5124.jpg");
        }
    }
}
