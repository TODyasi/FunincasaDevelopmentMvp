using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FunincasaDevelopment.RecipeAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.recipetineats.com/wp-content/uploads/2019/05/Spaghetti-Carbonara_6.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.indianhealthyrecipes.com/wp-content/uploads/2022/04/chicken-curry-recipe.jpg");

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "CookTime", "CreatedOn", "ImageUrl", "Ingredients", "Instructions", "LastUpdated", "NoOfServings", "PrepTime", "RecipeDescription", "RecipeTitle" },
                values: new object[,]
                {
                    { 3, 25, new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.simplyrecipes.com/thmb/wdIHbAeXrjjieDhNUvFNSplGeEw=/1800x1200/filters:fill(auto,1)/Simply-Recipes-Beef-Stroganoff-LEAD-09-d826ebd2baf14e768e3254a67e1a2988.jpg", "[\"Beef\",\"Mushrooms\",\"Onion\",\"Sour Cream\",\"Paprika\"]", "Cook beef and mushrooms. Add sour cream and seasonings. Serve over pasta or rice.", new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 15, "A creamy and hearty Russian beef dish served over noodles or rice.", "Beef Stroganoff" },
                    { 4, 10, new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.acouplecooks.com/wp-content/uploads/2020/04/Veggie-Stir-Fry-005s.jpg", "[\"Broccoli\",\"Carrots\",\"Bell Peppers\",\"Soy Sauce\",\"Garlic\"]", "Sauté garlic. Add vegetables and stir-fry with soy sauce.", new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 10, "A quick and healthy mix of colorful vegetables stir-fried with soy sauce.", "Vegetable Stir-Fry" },
                    { 5, 10, new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.kingarthurbaking.com/sites/default/files/styles/featured_image/public/2023-07/Margherita-pizza.jpg", "[\"Pizza Dough\",\"Tomato Sauce\",\"Mozzarella\",\"Basil\",\"Olive Oil\"]", "Roll dough. Spread sauce. Add cheese and basil. Bake at 220°C for 10 minutes.", new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 15, "An Italian pizza with tomato, mozzarella, and fresh basil.", "Classic Margherita Pizza" },
                    { 6, 10, new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.recipetineats.com/wp-content/uploads/2019/09/Grilled-Salmon_5.jpg", "[\"Salmon\",\"Lemon\",\"Garlic\",\"Olive Oil\",\"Dill\"]", "Season salmon. Grill for 5 minutes per side.", new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 10, "A healthy and flavorful salmon dish with lemon and herbs.", "Grilled Salmon" },
                    { 7, 5, new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.acouplecooks.com/wp-content/uploads/2021/02/Avocado-Toast-007.jpg", "[\"Avocado\",\"Bread\",\"Salt\",\"Pepper\",\"Lemon Juice\"]", "Mash avocado. Spread on toast. Season with salt, pepper, and lemon juice.", new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5, "A simple and nutritious avocado spread on toasted bread.", "Avocado Toast" },
                    { 8, 12, new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.sallysbakingaddiction.com/wp-content/uploads/2013/05/thick-chewy-chocolate-chip-cookies.jpg", "[\"Flour\",\"Butter\",\"Sugar\",\"Chocolate Chips\",\"Eggs\"]", "Mix ingredients. Scoop onto baking sheet. Bake at 180°C for 12 minutes.", new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 15, "Classic soft and chewy chocolate chip cookies.", "Chocolate Chip Cookies" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://example.com/spaghetti.jpg");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://example.com/chicken-curry.jpg");
        }
    }
}
