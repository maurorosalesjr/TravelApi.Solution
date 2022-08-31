using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelApi.Migrations
{
    public partial class Country : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Travels",
                type: "varchar(50) CHARACTER SET utf8mb4",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Travels",
                keyColumn: "TravelId",
                keyValue: 1,
                column: "Country",
                value: "United States of America");

            migrationBuilder.UpdateData(
                table: "Travels",
                keyColumn: "TravelId",
                keyValue: 2,
                column: "Country",
                value: "United States of America");

            migrationBuilder.UpdateData(
                table: "Travels",
                keyColumn: "TravelId",
                keyValue: 3,
                column: "Country",
                value: "United States of America");

            migrationBuilder.UpdateData(
                table: "Travels",
                keyColumn: "TravelId",
                keyValue: 4,
                column: "Country",
                value: "United States of America");

            migrationBuilder.UpdateData(
                table: "Travels",
                keyColumn: "TravelId",
                keyValue: 5,
                column: "Country",
                value: "United States of America");

            migrationBuilder.InsertData(
                table: "Travels",
                columns: new[] { "TravelId", "Blerb", "Country", "Location", "Rating" },
                values: new object[] { 6, "this was dope af. a lot of great culture and history. amazing food", "Mexico", "Mexico City", 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Travels",
                keyColumn: "TravelId",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Travels");
        }
    }
}
