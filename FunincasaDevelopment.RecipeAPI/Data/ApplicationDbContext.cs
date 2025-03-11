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
                    ImageUrl = "https://example.com/spaghetti.jpg",
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
                    ImageUrl = "https://example.com/chicken-curry.jpg",
                    CreatedOn = new DateTime(2025, 2, 17),
                    LastUpdated = new DateTime(2025, 2, 17)
                }
            );
        }
    }
}
