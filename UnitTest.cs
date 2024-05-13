using NUnit.Framework;

public class RecipeTests
{
    [Test]
    public void TestTotalCaloriesCalculation()
    {
        // Arrange
        var recipe = new Recipe("Test Recipe");

        // Add ingredients with known calorie values
        recipe.Ingredients.Add(new Ingredient("Apple", 1.0, "cup", 50));
        recipe.Ingredients.Add(new Ingredient("Banana", 0.5, "", 105));
        recipe.Ingredients.Add(new Ingredient("Milk", 1.0, "cup", 120));

        // Expected total calories
        int expectedTotalCalories = 50 + (105 * 0.5) + 120;

        // Act
        recipe.CalculateTotalCalories();

        // Assert
        Assert.AreEqual(expectedTotalCalories, recipe.TotalCalories);
    }
}
