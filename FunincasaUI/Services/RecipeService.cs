using FunincasaUI.Models;
using FunincasaUI.Services.IService;
using FunincasaUI.Utility;

namespace FunincasaUI.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IBaseService _baseService;

        public RecipeService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto?> CreateRecipeAsync(RecipeDto recipeDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SharedDetails.ApiType.POST,
                Data = recipeDto,
                Url = SharedDetails.RecipeAPIBase + "/api/RecipeAPI/Add",
                ContentType = SharedDetails.ContentType.MultipartFormData
            });
        }

        public async Task<ResponseDto?> DeleteRecipeAsync(int recipeId)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SharedDetails.ApiType.DELETE,
                Url = SharedDetails.RecipeAPIBase + "/api/RecipeAPI/Delete/" + recipeId,
            });
        }

        public async Task<ResponseDto?> GetAllRecipesAsync()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SharedDetails.ApiType.GET,
                Url = SharedDetails.RecipeAPIBase + "/api/RecipeAPI/GetAll", 
            });
        }

        public async Task<ResponseDto?> GetRecipeAsync(int recipeId)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SharedDetails.ApiType.GET,  
                Url = SharedDetails.RecipeAPIBase + "/api/RecipeAPI/" + recipeId , 
            });
        }

        public async Task<ResponseDto?> GetRecipeByIdAsync(int recipeId)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SharedDetails.ApiType.GET,  
                Url = SharedDetails.RecipeAPIBase + "/api/RecipeAPI/Get/" + recipeId + recipeId,  
            });
        }

        public async Task<ResponseDto?> UpdateRecipeAsync(RecipeDto recipeDto, int recipeId)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SharedDetails.ApiType.PUT,  
                Url = SharedDetails.RecipeAPIBase + "/api/RecipeAPI/Update" + recipeId,  
                ContentType = SharedDetails.ContentType.MultipartFormData,
                Data = recipeDto
            });
        }

        public Task<ResponseDto?> UpdateRecipeAsync(RecipeDto recipeDto)
        {
            throw new NotImplementedException();
        }
    }
}
