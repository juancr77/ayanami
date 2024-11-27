namespace RecetApp.Models
{
    public class FavoriteFood
    {
        public int Id { get; set; }
        public string FoodName { get; set; }
        public string NutritionalInfo { get; set; }
        public int UserId { get; set; }
    }
}
