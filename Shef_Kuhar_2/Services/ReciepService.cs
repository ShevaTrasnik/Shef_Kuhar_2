using Newtonsoft.Json;
using Shef_Kuhar_2.Models;
using System.Collections.Generic;
using System.IO;


    public static class RecipeService
    {
        private static readonly string FilePath = "recipes.json";

        public static void SaveRecipes(List<Recipe> recipes)
        {
            var json = JsonConvert.SerializeObject(recipes, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

        public static List<Recipe> LoadRecipes()
        {
            if (!File.Exists(FilePath))
            {
                return new List<Recipe>();
            }

            var json = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<List<Recipe>>(json) ?? new List<Recipe>();
        }
    }
