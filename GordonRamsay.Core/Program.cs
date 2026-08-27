using GordonRamsay.Core.Library;

namespace GordonRamsay.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipe cake = new Recipe(name:"cake", instructions:"Cook good!", preparation:15, time:20);
            
            // cake.Ingredients.Add(new Ingredient {IngredientName = "Mehl", Quantity = 200});
            
            cake.IngredientCheck();
            cake.ShowRecipe();
        }
    }
}