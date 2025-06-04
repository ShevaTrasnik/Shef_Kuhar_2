using System.Collections.Generic;

namespace ShefKuhar.Models
{
    /// Представляє один рецепт.
    public class Recipe
    {
        public string Name { get; set; }                  // Назва страви
        public string Description { get; set; }           // Опис приготування
        public List<Ingredient> Ingredients { get; set; } // Список інгредієнтів
    }
}
