
using Domain.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using Service.Validations;
using System;

namespace ApiReceitas.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private Domain.Interfaces.IBaseService<Recipe> _baseRecipeService;
        private IRecipeService _recipeService;

        public RecipeController(Domain.Interfaces.IBaseService<Recipe> baseRecipeService, IRecipeService recipeService)
        {
            _baseRecipeService = baseRecipeService;
            _recipeService = recipeService;
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("CreateRecipe")]
        public IActionResult Create([FromBody] Recipe recipe)
        {
            if (recipe == null)
                return NotFound();


            return Execute(() => _baseRecipeService.Add<RecipeValidator>(recipe).id);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Recipe recipe)
        {
            if (recipe == null)
                return NotFound();

            return Execute(() => _baseRecipeService.Update<RecipeValidator>(recipe));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0)
                return NotFound();

            Execute(() =>
            {
                _baseRecipeService.Delete(id);
                return true;
            });

            return new NoContentResult();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Execute(() => _baseRecipeService.Get());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id == 0)
                return NotFound();

            return Execute(() => _baseRecipeService.GetById(id));
        }

        private IActionResult Execute(Func<object> func)
        {
            try
            {
                var result = func();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
