namespace RecipeApp.Entity
{
    public class RecipeItem
    {
        private string id;
        public string Id { get => id; set => id = value; }
        private string name;
        public string Name { get => name; set => name = value; }
        private string ingredients;
        public string Ingredients { get => ingredients; set => ingredients = value; }
        private string instructions;
        public string Instructions { get => instructions; set => instructions = value; }
    }
}
