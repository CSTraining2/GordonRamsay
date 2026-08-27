using GordonRamsay.Core.Library;

namespace GordonRamsay.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var cake = new Recipe(name: "Kuchen", instructions: "Gut Backen!", preparation: 15, time: 20)
            {
                Ingredients = new List<Ingredient>
                {
                    new Ingredient { IngredientName = "Mehl", Quantity = 200 },
                    new Ingredient {IngredientName = "Eier", Quantity = 3}
                }
            };

            var cooky = new Recipe(name: "Cookies", instructions: "Sehr Gut Backen", preparation: 20, time: 30)
            {
                Ingredients = new List<Ingredient>
                {
                    new Ingredient {IngredientName = "blah", Quantity = 300},
                }
            };
            
            // cake.Ingredients.Add(new Ingredient {IngredientName = "Mehl", Quantity = 200});
            
            cake.IngredientCheck();
            cake.ShowRecipe();
            cooky.IngredientCheck();
            cooky.ShowRecipe();
        }
    }
}