using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TVCAPI.Migrations
{
    /// <inheritdoc />
    public partial class Allfinished : Migration
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
                values: new object[,]
                {
                    { 1, "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/T-SHIRT-TVC-Monuments-BLACK_600x.jpg?v=1621621536", "Monuments Cover Long sleeve", 3500 },
                    { 2, "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/Monolithbaseball_700x.jpg?v=1621620613", "Monoliths T-shirt", 3500 },
                    { 3, "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/tanktop_700x.jpg?v=1621620627", "Tank Top", 3000 },
                    { 4, "https://cdn.shopify.com/s/files/1/0506/9566/7910/files/Longsleeve-The-Vintage-Caravan-Blizzard_700x.jpg?v=1682686660", "Blizzard Long sleeve", 3500 },
                    { 5, "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/t-shirt-gateways_700x.jpg?v=1621620596", "Gateways T-shirt", 3500 },
                    { 6, "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/Hidden-Streams_700x.jpg?v=1621620620", "Hidden Streams T-shirt", 3500 },
                    { 7, "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/1COASTER-TVC-Logo_700x.jpg?v=1621621585", "Coaster", 500 }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "AlbumId", "SongName" },
                values: new object[,]
                {
                    { 1, 1, "Need a Woman" },
                    { 2, 1, "Corruption and Fraud" },
                    { 3, 1, "Sun-ray" },
                    { 4, 1, "Psychedelic Mushroom Man" },
                    { 5, 1, "Wild Child" },
                    { 6, 1, "Empty Space" },
                    { 7, 1, "Let's Get It on" },
                    { 8, 1, "Going Home" },
                    { 9, 1, "Black Swan" },
                    { 10, 2, "Know Your Place" },
                    { 11, 2, "Craving" },
                    { 12, 2, "Let Me Be" },
                    { 13, 2, "Do You Remember" },
                    { 14, 2, "M.A.R.S.W.A.T.T." },
                    { 15, 2, "Cocaine Sally" },
                    { 16, 2, "Winterland" },
                    { 17, 2, "Midnight Meditation" },
                    { 18, 2, "The Kings Voyage" },
                    { 19, 3, "Last Day of Light" },
                    { 20, 3, "Monolith" },
                    { 21, 3, "Babylon" },
                    { 22, 3, "Eclipsed" },
                    { 23, 3, "Shaken Beliefs" },
                    { 24, 3, "Crazy Horses" },
                    { 25, 3, "Sandwalker" },
                    { 26, 3, "Innerverse" },
                    { 27, 3, "Carousel" },
                    { 28, 3, "Winter Queen" },
                    { 29, 3, "Say Hello" },
                    { 30, 3, "Five Months" },
                    { 31, 4, "Set Your Sights" },
                    { 32, 4, "The Way" },
                    { 33, 4, "Reflections" },
                    { 34, 4, "On the Run" },
                    { 35, 4, "All This Time" },
                    { 36, 4, "Hidden Streams" },
                    { 37, 4, "Reset" },
                    { 38, 4, "Nebula" },
                    { 39, 4, "Farewell" },
                    { 40, 4, "Tune out" },
                    { 41, 4, "The Chain (Fleetwood Mac Cover)" },
                    { 42, 5, "Whispers" },
                    { 43, 5, "Crystallized" },
                    { 44, 5, "Can’t get you off my mind" },
                    { 45, 5, "Dark times" },
                    { 46, 5, "This one’s for you" },
                    { 47, 5, "Forgotten" },
                    { 48, 5, "Sharp teeth" },
                    { 49, 5, "Hell" },
                    { 50, 5, "Torn in two" },
                    { 51, 5, "Said&Done" },
                    { 52, 5, "Clarity" }
                });

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
