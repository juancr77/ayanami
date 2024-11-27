using Newtonsoft.Json; // Importa Newtonsoft.Json
using RecetApp.Models;
using System.Text;

namespace RecetApp.Services
{
    public class ApiService
    {
        private readonly string BaseUrl = "http://Recetas123.somee.com/api/";

        public async Task<List<FavoriteFood>> GetFavoriteFoodsAsync(int userId)
        {
            using var client = new HttpClient();
            var response = await client.GetAsync($"{BaseUrl}favorite-foods/user/{userId}");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<FavoriteFood>>(json);
        }

        public async Task<List<FavoriteRecipe>> GetFavoriteRecipesAsync(int userId)
        {
            using var client = new HttpClient();
            var response = await client.GetAsync($"{BaseUrl}favorite-recipes/user/{userId}");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<FavoriteRecipe>>(json);
        }
    }
}
