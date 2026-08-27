namespace GordonRamsay.Core.Library;

class Ingredient
{
    public required string IngredientName { get; init; }
    internal int Quantity { get; init; }
    internal int Weight { get; set; }

    internal string PrintIngredient() => $"Name: {IngredientName}, Menge: {Quantity}, Gewicht: {Weight}";
}