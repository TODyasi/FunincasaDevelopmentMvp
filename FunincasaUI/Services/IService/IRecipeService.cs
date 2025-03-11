using FunincasaUI.Models;

namespace FunincasaUI.Services.IService
{
    public interface IRecipeService
    {
        Task<ResponseDto?> GetRecipeAsync(int recipeId);
        Task<ResponseDto?> GetAllRecipesAsync();
        Task<ResponseDto?> GetRecipeByIdAsync(int recipeId);
        Task<ResponseDto?> CreateRecipeAsync(RecipeDto recipeDto);
        Task<ResponseDto?> UpdateRecipeAsync(RecipeDto recipeDto, int recipeId);
        Task<ResponseDto?> DeleteRecipeAsync(int recipeId);
        Task<ResponseDto?> UpdateRecipeAsync(RecipeDto recipeDto);
    }
}
