using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rovin.Migrations
{
    public partial class SeededCountries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Name", "Shortname" },
                values: new object[] { 1, "India", "IN" });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Name", "Shortname" },
                values: new object[] { 2, "Jamaica", "JM" });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Name", "Shortname" },
                values: new object[] { 3, "USA", "US" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CountryId", "Name", "Rating" },
                values: new object[] { 1, "No 8 India", 3, "Park", 3.5 });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CountryId", "Name", "Rating" },
                values: new object[] { 2, "No 32 India", 2, "Taj", 4.0999999999999996 });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CountryId", "Name", "Rating" },
                values: new object[] { 3, "No 33 India", 1, "Saravana", 4.7000000000000002 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
