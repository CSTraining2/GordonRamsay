using GordonRamsay.Core.Library;

namespace GordonRamsay.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipe cake = new Recipe(name: "Kuchen", instructions: "Gut Kochen!", preparation: 15, time: 20)
            {
                Ingredients = new List<Ingredient>
                {
                    new Ingredient { IngredientName = "Mehl", Quantity = 200 },
                    new Ingredient {IngredientName = "Eier", Quantity = 3}
                }
            };
            
            // cake.Ingredients.Add(new Ingredient {IngredientName = "Mehl", Quantity = 200});
            
            cake.IngredientCheck();
            cake.ShowRecipe();
        }
    }
}