using FunincasaDevelopment.RecipeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FunincasaDevelopment.RecipeAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<RecipeModel> Recipes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<RecipeModel>().HasData(
                new RecipeModel
                {
                    RecipeId = 1,
                    RecipeTitle = "Spaghetti Carbonara",
                    RecipeDescription = "A classic Italian pasta dish made with eggs, cheese, pancetta, and pepper.",
                    Ingredients = new List<string> { "Spaghetti", "Eggs", "Parmesan Cheese", "Pancetta", "Black Pepper" },
                    Instructions = "Cook spaghetti. Fry pancetta. Mix eggs and cheese. Combine all with spaghetti.",
                    PrepTime = 10,
                    CookTime = 15,
                    NoOfServings = 2,
                    ImageUrl = "https://www.recipetineats.com/wp-content/uploads/2019/05/Spaghetti-Carbonara_6.jpg",
                    CreatedOn = new DateTime(2025, 2, 17),
                    LastUpdated = new DateTime(2025, 2, 17)
                },
                new RecipeModel
                {
                    RecipeId = 2,
                    RecipeTitle = "Chicken Curry",
                    RecipeDescription = "A flavorful Indian-style chicken curry cooked with spices and coconut milk.",
                    Ingredients = new List<string> { "Chicken", "Onion", "Garlic", "Curry Powder", "Coconut Milk" },
                    Instructions = "Sauté onions and garlic. Add chicken and spices. Pour coconut milk and simmer.",
                    PrepTime = 15,
                    CookTime = 30,
                    NoOfServings = 4,
                    ImageUrl = "https://www.indianhealthyrecipes.com/wp-content/uploads/2022/04/chicken-curry-recipe.jpg",
                    CreatedOn = new DateTime(2025, 2, 17),
                    LastUpdated = new DateTime(2025, 2, 17)
                },
                new RecipeModel
                {
                    RecipeId = 3,
                    RecipeTitle = "Beef Stroganoff",
                    RecipeDescription = "A creamy and hearty Russian beef dish served over noodles or rice.",
                    Ingredients = new List<string> { "Beef", "Mushrooms", "Onion", "Sour Cream", "Paprika" },
                    Instructions = "Cook beef and mushrooms. Add sour cream and seasonings. Serve over pasta or rice.",
                    PrepTime = 15,
                    CookTime = 25,
                    NoOfServings = 4,
                    ImageUrl = "https://www.simplyrecipes.com/thmb/wdIHbAeXrjjieDhNUvFNSplGeEw=/1800x1200/filters:fill(auto,1)/Simply-Recipes-Beef-Stroganoff-LEAD-09-d826ebd2baf14e768e3254a67e1a2988.jpg",
                    CreatedOn = new DateTime(2025, 2, 17),
                    LastUpdated = new DateTime(2025, 2, 17)
                },
                new RecipeModel
                {
                    RecipeId = 4,
                    RecipeTitle = "Vegetable Stir-Fry",
                    RecipeDescription = "A quick and healthy mix of colorful vegetables stir-fried with soy sauce.",
                    Ingredients = new List<string> { "Broccoli", "Carrots", "Bell Peppers", "Soy Sauce", "Garlic" },
                    Instructions = "Sauté garlic. Add vegetables and stir-fry with soy sauce.",
                    PrepTime = 10,
                    CookTime = 10,
                    NoOfServings = 3,
                    ImageUrl = "https://www.acouplecooks.com/wp-content/uploads/2020/04/Veggie-Stir-Fry-005s.jpg",
                    CreatedOn = new DateTime(2025, 2, 17),
                    LastUpdated = new DateTime(2025, 2, 17)
                },
                new RecipeModel
                {
                    RecipeId = 5,
                    RecipeTitle = "Classic Margherita Pizza",
                    RecipeDescription = "An Italian pizza with tomato, mozzarella, and fresh basil.",
                    Ingredients = new List<string> { "Pizza Dough", "Tomato Sauce", "Mozzarella", "Basil", "Olive Oil" },
                    Instructions = "Roll dough. Spread sauce. Add cheese and basil. Bake at 220°C for 10 minutes.",
                    PrepTime = 15,
                    CookTime = 10,
                    NoOfServings = 2,
                    ImageUrl = "https://www.kingarthurbaking.com/sites/default/files/styles/featured_image/public/2023-07/Margherita-pizza.jpg",
                    CreatedOn = new DateTime(2025, 2, 17),
                    LastUpdated = new DateTime(2025, 2, 17)
                },
                new RecipeModel
                {
                    RecipeId = 6,
                    RecipeTitle = "Grilled Salmon",
                    RecipeDescription = "A healthy and flavorful salmon dish with lemon and herbs.",
                    Ingredients = new List<string> { "Salmon", "Lemon", "Garlic", "Olive Oil", "Dill" },
                    Instructions = "Season salmon. Grill for 5 minutes per side.",
                    PrepTime = 10,
                    CookTime = 10,
                    NoOfServings = 2,
                    ImageUrl = "https://www.recipetineats.com/wp-content/uploads/2019/09/Grilled-Salmon_5.jpg",
                    CreatedOn = new DateTime(2025, 2, 17),
                    LastUpdated = new DateTime(2025, 2, 17)
                },
                new RecipeModel
                {
                    RecipeId = 7,
                    RecipeTitle = "Avocado Toast",
                    RecipeDescription = "A simple and nutritious avocado spread on toasted bread.",
                    Ingredients = new List<string> { "Avocado", "Bread", "Salt", "Pepper", "Lemon Juice" },
                    Instructions = "Mash avocado. Spread on toast. Season with salt, pepper, and lemon juice.",
                    PrepTime = 5,
                    CookTime = 5,
                    NoOfServings = 1,
                    ImageUrl = "https://www.acouplecooks.com/wp-content/uploads/2021/02/Avocado-Toast-007.jpg",
                    CreatedOn = new DateTime(2025, 2, 17),
                    LastUpdated = new DateTime(2025, 2, 17)
                },
                new RecipeModel
                {
                    RecipeId = 8,
                    RecipeTitle = "Chocolate Chip Cookies",
                    RecipeDescription = "Classic soft and chewy chocolate chip cookies.",
                    Ingredients = new List<string> { "Flour", "Butter", "Sugar", "Chocolate Chips", "Eggs" },
                    Instructions = "Mix ingredients. Scoop onto baking sheet. Bake at 180°C for 12 minutes.",
                    PrepTime = 15,
                    CookTime = 12,
                    NoOfServings = 8,
                    ImageUrl = "https://www.sallysbakingaddiction.com/wp-content/uploads/2013/05/thick-chewy-chocolate-chip-cookies.jpg",
                    CreatedOn = new DateTime(2025, 2, 17),
                    LastUpdated = new DateTime(2025, 2, 17)
                }
            );
        }

    }
}
