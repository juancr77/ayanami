namespace RecetApp.Models
{
    public class FavoriteRecipe
    {
        public int Id { get; set; }
        public string RecipeName { get; set; }
        public string RecipeDetails { get; set; }
        public int UserId { get; set; }
    }
}
