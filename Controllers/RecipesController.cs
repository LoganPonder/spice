using System;
using System.Collections.Generic;
using spice.Models;
using spice.Services;
using Microsoft.AspNetCore.Mvc;
// using CodeWorks.Auth0Provider;
// using Microsoft.AspNetCore.Authorization;

namespace spice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipesController : ControllerBase
    {
        private readonly RecipesService _service;

        public RecipesController(RecipesService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Recipe>> GetAllRecipes()
        {
            try
            {
                IEnumerable<Recipe> recipes = _service.GetAllRecipes();
                return Ok(recipes);
            }
            catch (Exception e)

            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Recipe> CreateRecipe([FromBody] Recipe newRecipe)
        {
            try
            {
                Recipe recipe = _service.CreateRecipe(newRecipe);
                return Ok(recipe);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}