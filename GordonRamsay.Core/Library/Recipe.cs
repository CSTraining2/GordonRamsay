namespace GordonRamsay.Core.Library;

class Recipe
{
    private string RecipeName { get; set; }
    private string Instructions { get; set; }
    private int Preparation { get; set; }
    protected int Time { get; set; }
    internal List<Ingredient> Ingredients { get; init; } = [];

    public Recipe(string name, string instructions, int preparation, int time)
    {
        RecipeName = name;
        Instructions = instructions;
        Preparation = preparation;
        Time = time;
    }

    internal void ShowRecipe()
    {
        Console.WriteLine($"Name: {RecipeName}, Zutaten: {Preparation}");

        foreach (var ingredient in Ingredients)
        {
            Console.WriteLine(ingredient.PrintIngredient());
        }
        
        Console.WriteLine($"Anleitung: {Instructions}");
    }

    internal bool IngredientLookUp(string name)
    {
        foreach (var ingredient in Ingredients)
        {
            if (ingredient.IngredientName == name)
            {
                return true;
            }
        }
        return false;
    }

    internal void IngredientCheck()
    {
        if (Ingredients.Count <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(Ingredients), "Ingredient list is empty!");
        }
    }
}