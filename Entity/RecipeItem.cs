using Blazored.LocalStorage;

namespace RecipeApp.Entity
{
    public class RecipeItem
    {
        private string id;
        public string Id { get => id; set => id = value; }
        private string name;
        public string Name { get => name; set => name = value; }
        private string image;
        public string Image { get => image; set => image = value; }
        private string ingredients;
        public string Ingredients { get => ingredients; set => ingredients = value; }
        private string instructions;
        public string Instructions { get => instructions; set => instructions = value; }
        private int duration;
        public int Duration { get => duration; set => duration = value; }
        private const string localStorageKey = "recipeapp";
        private ILocalStorageService localStorage { get; set; }
        
        public async Task<List<RecipeItem>> GetRecipeAsync()
        {
            return await localStorage.GetItemAsync<List<RecipeItem>>(localStorageKey);
        } 
    }

    public class recipeItem
{
    public string Name { get; set; }
    public string[] Ingredients { get; set; }
}


    
}
