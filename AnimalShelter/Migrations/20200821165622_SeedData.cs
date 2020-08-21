using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "CatId", "Age", "Gender", "Name", "Story" },
                values: new object[,]
                {
                    { 1, 4, "Male", "Flash", "Little bit of a scaredy cat, but will be a lover once he knows you." },
                    { 2, 6, "Male", "Jazz", "Biggest cuddler and sweetest boy." },
                    { 3, 1, "Female", "Raisin", "Will follow you wherever you go." },
                    { 4, 2, "Female", "Maya", "Knows what she wants and how to manipulate you to get it." },
                    { 5, 7, "Female", "Shiva", "She is has always been that small and always will be." }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Age", "Gender", "Name", "Story" },
                values: new object[,]
                {
                    { 1, 2, "Male", "Baloo", "Born with no hip sockets, had them installed by doctors later. Will love you forever." },
                    { 2, 3, "Female", "Hambone", "Always wants to run in the park." },
                    { 3, 5, "Male", "Ziggy", "Give him treats and take him for walks and he is yours." },
                    { 4, 2, "Female", "Duchess", "Wants to sits in your lap and burrow under the covers to keep your feet warm." },
                    { 5, 1, "Male", "Bowser", "Super active and playful, wants a family that spends most of their time outside." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 5);
        }
    }
}
