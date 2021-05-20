using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using spice.Models;

namespace spice.Repositories
{
    public class RecipesRepository
    {
        private readonly IDbConnection _db;
        public RecipesRepository(IDbConnection db)
        {
            _db = db;
        }

        internal IEnumerable<Recipe> GetAllRecipes()
        {
            string sql = "SELECT * FROM recipes;";
            return _db.Query<Recipe>(sql);
        }

        internal Recipe CreateRecipe(Recipe newRecipe)
        {
            string sql = @"
            INSERT INTO recipes
            (title, timeToMake, vegan, vegetarian)
            VALUES
            (@Title, @TimeToMake, @Vegan, @Vegetarian);
            SELECT LAST_INSERT_ID()";
            newRecipe.Id = _db.ExecuteScalar<int>(sql, newRecipe);
            return newRecipe;
        }
    }
}