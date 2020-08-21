using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Businesses",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Address", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Rogers Park", "Mexican Restaurant", "El Famous", "Restuarant" },
                    { 2, "Rogers Park", "Mexican Restaurant", "Rockys Tacos", "Restuarant" },
                    { 3, "Evanston", "Craft Store", "Paper Source", "Store" },
                    { 4, "Rogers Park", "Amazing Store", "Target", "Store" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Businesses");
        }
    }
}
