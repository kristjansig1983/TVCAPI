using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TVCAPI.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AlbumYear = table.Column<int>(type: "int", nullable: false),
                    AlbumCoverUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.AlbumId);
                });

            migrationBuilder.CreateTable(
                name: "Merches",
                columns: table => new
                {
                    MerchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MerchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MerchPrice = table.Column<int>(type: "int", nullable: false),
                    MerchImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merches", x => x.MerchId);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    SongId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SongName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlbumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.SongId);
                    table.ForeignKey(
                        name: "FK_Songs_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "AlbumId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AlbumCoverUrl", "AlbumName", "AlbumYear" },
                values: new object[,]
                {
                    { 1, "https://www.spirit-of-metal.com/les%20goupes/T/The%20Vintage%20Caravan/The%20Vintage%20Caravan/The%20Vintage%20Caravan.jpg", "The Vintage Caravan", 2009 },
                    { 2, "https://www.spirit-of-metal.com/les%20goupes/T/The%20Vintage%20Caravan/Voyage/Voyage.jpg", "Voyage", 2012 },
                    { 3, "https://www.spirit-of-metal.com/les%20goupes/T/The%20Vintage%20Caravan/Arrival/Arrival.jpg", "Arrival", 2015 },
                    { 4, "https://www.spirit-of-metal.com/les%20goupes/T/The%20Vintage%20Caravan/Gateways/Gateways_5124.jpg", "Gateways", 2018 },
                    { 5, "https://www.spirit-of-metal.com/les%20goupes/T/The%20Vintage%20Caravan/Gateways/Gateways_5124.jpg", "Monuments", 2021 }
                });

            migrationBuilder.InsertData(
                table: "Merches",
                columns: new[] { "MerchId", "MerchImgUrl", "MerchName", "MerchPrice" },
                values: new object[] { 1, "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/T-SHIRT-TVC-Monuments-BLACK_600x.jpg?v=1621621536\r\n", "Monuments Cover Long sleeve", 3500 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "AlbumId", "SongName" },
                values: new object[] { 1, 1, "Need a Woman" });

            migrationBuilder.CreateIndex(
                name: "IX_Songs_AlbumId",
                table: "Songs",
                column: "AlbumId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Merches");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Albums");
        }
    }
}
