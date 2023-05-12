using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TVCAPI.Migrations
{
    /// <inheritdoc />
    public partial class TryingMerch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Merches",
                columns: new[] { "MerchId", "MerchImgUrl", "MerchName", "MerchPrice" },
                values: new object[] { 1, "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/T-SHIRT-TVC-Monuments-BLACK_600x.jpg?v=1621621536\r\n", "Monuments Cover Long sleeve", 3500 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Merches",
                keyColumn: "MerchId",
                keyValue: 1);
        }
    }
}
