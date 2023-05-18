using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TVCAPI.Migrations
{
    /// <inheritdoc />
    public partial class FinishedMerchtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Merches",
                keyColumn: "MerchId",
                keyValue: 1,
                column: "MerchImgUrl",
                value: "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/T-SHIRT-TVC-Monuments-BLACK_600x.jpg?v=1621621536");

            migrationBuilder.InsertData(
                table: "Merches",
                columns: new[] { "MerchId", "MerchImgUrl", "MerchName", "MerchPrice" },
                values: new object[,]
                {
                    { 2, "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/Monolithbaseball_700x.jpg?v=1621620613", "Monoliths T-shirt", 3500 },
                    { 3, "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/tanktop_700x.jpg?v=1621620627", "Tank Top", 3000 },
                    { 4, "https://cdn.shopify.com/s/files/1/0506/9566/7910/files/Longsleeve-The-Vintage-Caravan-Blizzard_700x.jpg?v=1682686660", "Blizzard Long sleeve", 3500 },
                    { 5, "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/t-shirt-gateways_700x.jpg?v=1621620596", "Gateways T-shirt", 3500 },
                    { 6, "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/Hidden-Streams_700x.jpg?v=1621620620", "Hidden Streams T-shirt", 3500 },
                    { 7, "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/1COASTER-TVC-Logo_700x.jpg?v=1621621585", "Coaster", 500 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Merches",
                keyColumn: "MerchId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Merches",
                keyColumn: "MerchId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Merches",
                keyColumn: "MerchId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Merches",
                keyColumn: "MerchId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Merches",
                keyColumn: "MerchId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Merches",
                keyColumn: "MerchId",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Merches",
                keyColumn: "MerchId",
                keyValue: 1,
                column: "MerchImgUrl",
                value: "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/T-SHIRT-TVC-Monuments-BLACK_600x.jpg?v=1621621536\r\n");
        }
    }
}
