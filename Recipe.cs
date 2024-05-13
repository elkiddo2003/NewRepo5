using System.Collections.Generic;
using System;

public class Recipe
{
    public string Name { get; set; }
    public List<Ingredient> Ingredients { get; set; }
    public string Instructions { get; set; }
    public int CookingTime { get; set; } // In minutes
    public List<string> DietaryTags { get; set; } // List of dietary tags (e.g., Vegetarian, Gluten-Free)

    public Recipe(string name, List<Ingredient> ingredients, string instructions, int cookingTime, List<string> dietaryTags = null)
    {
        Name = name;
        Ingredients = ingredients;
        Instructions = instructions;
        CookingTime = cookingTime;
        DietaryTags = dietaryTags ?? new List<String>(); // Initialize empty list if not provided
    }

    public override string ToString()
    {
        string ingredientList = "";
        foreach (Ingredient ingredient in Ingredients)
        {
            ingredientList += $" - {ingredient}\n";
        }
        string dietaryTagsString = DietaryTags.Any() ? $" Dietary Tags: {string.Join(", ", DietaryTags)}\n" : "";
        return $"\nName: {Name}\n{dietaryTagsString}Ingredients:\n{ingredientList}Instructions:\n{Instructions}\nCooking Time: {CookingTime} minutes";
    }
}
