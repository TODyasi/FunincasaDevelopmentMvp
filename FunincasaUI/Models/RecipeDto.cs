namespace FunincasaUI.Models
{
    public class RecipeDto
    {
        public int RecipeId { get; set; }
        public string RecipeTitle { get; set; }
        public string RecipeDescription { get; set; }
        public List<string> Ingredients { get; set; } = new List<string>();
        public string Instructions { get; set; }
        public int PrepTime { get; set; }
        public int CookTime { get; set; }
        public int NoOfServings { get; set; }
        public string ImageUrl { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
