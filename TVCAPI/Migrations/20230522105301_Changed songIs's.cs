using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TVCAPI.Migrations
{
    /// <inheritdoc />
    public partial class ChangedsongIss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 58);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 6,
                column: "SongName",
                value: "Empty Space");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 7,
                column: "SongName",
                value: "Let's Get It on");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 8,
                column: "SongName",
                value: "Going Home");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 9,
                column: "SongName",
                value: "Black Swan");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 10,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 2, "Know Your Place" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 11,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 2, "Craving" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 12,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 2, "Let Me Be" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 13,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 2, "Do You Remember" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 14,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 2, "M.A.R.S.W.A.T.T." });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 15,
                column: "SongName",
                value: "Cocaine Sally");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 16,
                column: "SongName",
                value: "Winterland");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 17,
                column: "SongName",
                value: "Midnight Meditation");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 18,
                column: "SongName",
                value: "The Kings Voyage");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 19,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 3, "Last Day of Light" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 20,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 3, "Monolith" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 21,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 3, "Babylon" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 22,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 3, "Eclipsed" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 23,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 3, "Shaken Beliefs" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 24,
                column: "SongName",
                value: "Crazy Horses");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 25,
                column: "SongName",
                value: "Sandwalker");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 26,
                column: "SongName",
                value: "Innerverse");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 27,
                column: "SongName",
                value: "Carousel");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 28,
                column: "SongName",
                value: "Winter Queen");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 29,
                column: "SongName",
                value: "Say Hello");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 30,
                column: "SongName",
                value: "Five Months");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 31,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 4, "Set Your Sights" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 32,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 4, "The Way" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 33,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 4, "Reflections" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 34,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 4, "On the Run" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 35,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 4, "All This Time" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 36,
                column: "SongName",
                value: "Hidden Streams");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 37,
                column: "SongName",
                value: "Reset");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 38,
                column: "SongName",
                value: "Nebula");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 39,
                column: "SongName",
                value: "Farewell");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 40,
                column: "SongName",
                value: "Tune out");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 41,
                column: "SongName",
                value: "The Chain (Fleetwood Mac Cover)");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 42,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 5, "Whispers" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 43,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 5, "Crystallized" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 44,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 5, "Can’t get you off my mind" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 45,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 5, "Dark times" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 46,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 5, "This one’s for you" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 47,
                column: "SongName",
                value: "Forgotten");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 48,
                column: "SongName",
                value: "Sharp teeth");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 49,
                column: "SongName",
                value: "Hell");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 50,
                column: "SongName",
                value: "Torn in two");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 52,
                column: "SongName",
                value: "Clarity");

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
                    { 51, 5, "Said&Done" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 51);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 6,
                column: "SongName",
                value: "Need a Woman");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 7,
                column: "SongName",
                value: "Corruption and Fraud");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 8,
                column: "SongName",
                value: "Sun-ray");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 9,
                column: "SongName",
                value: "Psychedelic Mushroom Man");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 10,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 1, "Wild Child" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 11,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 1, "Empty Space" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 12,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 1, "Let's Get It on" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 13,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 1, "Going Home" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 14,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 1, "Black Swan" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 15,
                column: "SongName",
                value: "Know Your Place");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 16,
                column: "SongName",
                value: "Craving");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 17,
                column: "SongName",
                value: "Let Me Be");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 18,
                column: "SongName",
                value: "Do You Remember");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 19,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 2, "M.A.R.S.W.A.T.T." });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 20,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 2, "Cocaine Sally" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 21,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 2, "Winterland" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 22,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 2, "Midnight Meditation" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 23,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 2, "The Kings Voyage" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 24,
                column: "SongName",
                value: "Last Day of Light");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 25,
                column: "SongName",
                value: "Monolith");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 26,
                column: "SongName",
                value: "Babylon");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 27,
                column: "SongName",
                value: "Eclipsed");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 28,
                column: "SongName",
                value: "Shaken Beliefs");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 29,
                column: "SongName",
                value: "Crazy Horses");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 30,
                column: "SongName",
                value: "Sandwalker");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 31,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 3, "Innerverse" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 32,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 3, "Carousel" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 33,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 3, "Winter Queen" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 34,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 3, "Say Hello" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 35,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 3, "Five Months" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 36,
                column: "SongName",
                value: "Set Your Sights");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 37,
                column: "SongName",
                value: "The Way");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 38,
                column: "SongName",
                value: "Reflections");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 39,
                column: "SongName",
                value: "On the Run");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 40,
                column: "SongName",
                value: "All This Time");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 41,
                column: "SongName",
                value: "Hidden Streams");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 42,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 4, "Reset" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 43,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 4, "Nebula" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 44,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 4, "Farewell" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 45,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 4, "Tune out" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 46,
                columns: new[] { "AlbumId", "SongName" },
                values: new object[] { 4, "The Chain (Fleetwood Mac Cover)" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 47,
                column: "SongName",
                value: "Whispers");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 48,
                column: "SongName",
                value: "Crystallized");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 49,
                column: "SongName",
                value: "Can’t get you off my mind");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 50,
                column: "SongName",
                value: "Dark times");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 52,
                column: "SongName",
                value: "This one’s for you");

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "AlbumId", "SongName" },
                values: new object[,]
                {
                    { 53, 5, "Forgotten" },
                    { 54, 5, "Sharp teeth" },
                    { 55, 5, "Hell" },
                    { 56, 5, "Torn in two" },
                    { 57, 5, "Said&Done" },
                    { 58, 5, "Clarity" }
                });
        }
    }
}
