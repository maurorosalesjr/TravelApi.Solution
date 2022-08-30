using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelApi.Migrations
{
    public partial class DBSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Travels",
                type: "varchar(50) CHARACTER SET utf8mb4",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20) CHARACTER SET utf8mb4",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Blerb",
                table: "Travels",
                type: "varchar(1000) CHARACTER SET utf8mb4",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.InsertData(
                table: "Travels",
                columns: new[] { "TravelId", "Blerb", "Location", "Rating" },
                values: new object[,]
                {
                    { 1, "It was pretty cool, sunny but a nice cool sea breeze. food was great", "San Fancisco, CA", 8 },
                    { 2, "This town is whack AF. This is also my home town", "Gonzales, CA", 2 },
                    { 3, "I feel like I'm in California, with all the driving i have to do to get around. coffee was over rated but the food was pretty ok", "Seattle, WA", 4 },
                    { 4, "Christopher Moore said it best, the Monterey Peninsula is best for the Newly Wed and Nearly Dead", "Monterey, CA", 6 },
                    { 5, "if an armpit was a city, it would be Bakersfield. nothing of note", "Bakersfield, CA", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Travels",
                keyColumn: "TravelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Travels",
                keyColumn: "TravelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Travels",
                keyColumn: "TravelId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Travels",
                keyColumn: "TravelId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Travels",
                keyColumn: "TravelId",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Travels",
                type: "varchar(20) CHARACTER SET utf8mb4",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50) CHARACTER SET utf8mb4",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Blerb",
                table: "Travels",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(1000) CHARACTER SET utf8mb4",
                oldMaxLength: 1000);
        }
    }
}
