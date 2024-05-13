using System.Collections.Generic;
using System;

public class Meal
{
    public string Name { get; set; }
    public List<Ingredient> Ingredients { get; set; } // List of ingredients
    public string Instructions { get; set; }
    public int PrepTime { get; set; } // Optional prep time in minutes (default 0)
    public List<string> Tags { get; set; } // List of tags (e.g., Vegetarian, Gluten-Free)

    public Meal(string name, List<Ingredient> ingredients, string instructions, int prepTime = 0, List<string> tags = null)
    {
        // Validate name (ensure it's not empty)
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Meal name cannot be empty.");
        }

        Name = name;
        Ingredients = ingredients ?? new List<Ingredient>(); // Initialize empty list if ingredients not provided
        Instructions = instructions;
        PrepTime = prepTime;
        Tags = tags ?? new List<string>(); // Initialize empty list if tags not provided
    }

    public override string ToString()
    {
        string prepTimeText = PrepTime > 0 ? $"Prep Time: {PrepTime} minutes\n" : "";
        string tagsText = Tags.Count > 0 ? $"Tags: {string.Join(", ", Tags)}\n" : "";
        return $"\nName: {Name}\n{prepTimeText}{tagsText}Ingredients:\n  {string.Join("\n  ", Ingredients)}\nInstructions:\n{Instructions}"; // Closing brace added here
    }
}
