namespace GordonRamsay.Core.Library;

class Ingredient
{
    public required string IngredientName { get; init; }
    internal int Quantity { get; init; }
    internal int Weight { get; set; }

    internal void PrintIngredient() => Console.WriteLine($"Name: {IngredientName}, Menge: {Quantity}, Gewicht: {Weight}");
}