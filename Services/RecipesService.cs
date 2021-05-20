using System;
using System.Collections.Generic;
using spice.Models;
using spice.Repositories;

namespace spice.Services
{
    public class RecipesService
    {
        private readonly RecipesRepository _repo;
        public RecipesService(RecipesRepository repo)
        {
            _repo = repo;
        }

        internal IEnumerable<Recipe> GetAllRecipes()
        {
            return _repo.GetAllRecipes();
        }

        internal Recipe CreateRecipe(Recipe newRecipe)
        {
            return _repo.CreateRecipe(newRecipe);
        }
    }
}