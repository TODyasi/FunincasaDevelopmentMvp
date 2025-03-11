using FunincasaUI.Models;
using FunincasaUI.Services.IService;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FunincasaUI.Controllers
{
    public class RecipeController : Controller
    {
        private readonly IRecipeService _recipeService;
        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        public async Task<IActionResult> RecipeIndex()
        {
            List<RecipeDto>? recipeList = new();

            ResponseDto? response = await _recipeService.GetAllRecipesAsync();

            if (response != null && response.IsSuccess)
            {
                recipeList = JsonConvert.DeserializeObject<List<RecipeDto>>(Convert.ToString(response.Result)); 
            }
            else
            {
                TempData["error"] = response?.Message;
            }
            return View(recipeList);
        }

        [HttpPost]
        public async Task<IActionResult> RecipeCreate(RecipeDto model)
        {
            ResponseDto? response = await _recipeService.CreateRecipeAsync(model);

            if (response != null && response.IsSuccess)
            {
                TempData["success"] = "Recipe created successfully";
                return RedirectToAction(nameof(RecipeIndex));
            }
            else
            {
                TempData["error"] = response?.Message;
            }
            return View(model);
        }

        public async Task<IActionResult> RecipeDelete(int recipeId)
        {
            RecipeDto? model = new();

            ResponseDto? response = await _recipeService.DeleteRecipeAsync(recipeId);

            if (response != null && response.IsSuccess)
            {
                model = JsonConvert.DeserializeObject<RecipeDto>(Convert.ToString(response.Result));
            }
            else
            {
                TempData["error"] = response?.Message;
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> RecipeDelete(RecipeDto recipeDto)
        {
            ResponseDto? response = await _recipeService.DeleteRecipeAsync(recipeDto.RecipeId);

            if (response != null && response.IsSuccess)
            {
                TempData["success"] = "Recipe deleted successfully";
                return RedirectToAction(nameof(RecipeIndex));
            }
            else
            {
                TempData["error"] = response?.Message;
            }
            return View(recipeDto);
        }

        public async Task<IActionResult> RecipeEdit(int recipeId)
        {
            RecipeDto? model = new();

            ResponseDto? response = await _recipeService.GetRecipeByIdAsync(recipeId);

            if (response != null && response.IsSuccess)
            {
                model = JsonConvert.DeserializeObject<RecipeDto>(Convert.ToString(response.Result));
            }
            else
            {
                TempData["error"] = response?.Message;
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> RecipeEdit(RecipeDto recipeDto)
        {
            ResponseDto? response = await _recipeService.UpdateRecipeAsync(recipeDto);

            if (response != null && response.IsSuccess)
            {
                TempData["success"] = "Recipe updated successfully";
                return RedirectToAction(nameof(RecipeIndex));
            }
            else
            {
                TempData["error"] = response?.Message;
            }
            return View(recipeDto);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
