using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FunincasaDevelopment.RecipeAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecipeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ingredients = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instructions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrepTime = table.Column<int>(type: "int", nullable: false),
                    CookTime = table.Column<int>(type: "int", nullable: false),
                    NoOfServings = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeId);
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "CookTime", "CreatedOn", "ImageUrl", "Ingredients", "Instructions", "LastUpdated", "NoOfServings", "PrepTime", "RecipeDescription", "RecipeTitle" },
                values: new object[,]
                {
                    { 1, 15, new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://example.com/spaghetti.jpg", "[\"Spaghetti\",\"Eggs\",\"Parmesan Cheese\",\"Pancetta\",\"Black Pepper\"]", "Cook spaghetti. Fry pancetta. Mix eggs and cheese. Combine all with spaghetti.", new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 10, "A classic Italian pasta dish made with eggs, cheese, pancetta, and pepper.", "Spaghetti Carbonara" },
                    { 2, 30, new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://example.com/chicken-curry.jpg", "[\"Chicken\",\"Onion\",\"Garlic\",\"Curry Powder\",\"Coconut Milk\"]", "Sauté onions and garlic. Add chicken and spices. Pour coconut milk and simmer.", new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 15, "A flavorful Indian-style chicken curry cooked with spices and coconut milk.", "Chicken Curry" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
