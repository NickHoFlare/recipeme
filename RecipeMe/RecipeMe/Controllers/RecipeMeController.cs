using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RecipeMe.Controllers
{
    // Temporary routing is api/recipeme/... for now.
    // As features become more fleshed out, we shall organise controllers/routing accordingly
    [ApiController]
    [Route("api")]
    public class RecipeMeController : ControllerBase
    {
        private readonly ILogger<RecipeMeController> _logger;

        public RecipeMeController(ILogger<RecipeMeController> logger)
        {
            _logger = logger;
        }

        // Get Recipes from Edamam (General query) or
        // from Spoonacular (Ingredient query)
        [HttpGet("recipes")]
        public IActionResult GetRecipes([FromQuery] string generalQuery, [FromQuery] string ingredientQuery)
        {
            var generalResult = $"Hello Edamam: {generalQuery}";
            var ingredientResult = $"Hello Spoonacular: {ingredientQuery}";
            
            return Ok(generalResult + " " + ingredientResult);
        }
    }
}
