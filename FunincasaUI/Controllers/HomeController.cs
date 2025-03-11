using System.Diagnostics;
using FunincasaUI.Models;
using FunincasaUI.Services.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FunincasaUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRecipeService _recipeService;

        public HomeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        public async Task<IActionResult> Index()
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

        [Authorize]
        public async Task<IActionResult> RecipeDetails(int recipeId)
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

        [Authorize]
        [HttpPost]
        [ActionName("RecipeDetails")]
        public IActionResult RecipeDetails(RecipeDto recipeDto )
        {
            
            return View(recipeDto);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
