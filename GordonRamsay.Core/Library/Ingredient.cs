namespace GordonRamsay.Core.Library;

class Ingredient
{
    internal int Id { get; init; }
    public required string IngredientName { get; init; }
    internal int Quantity { get; init; }
    internal int Weight { get; set; }

    internal string PrintIngredient() => $"ID: {Id}, Name: {IngredientName}, Menge: {Quantity}, Gewicht: {Weight}";
}