using AutoMapper;
using FunincasaDevelopment.RecipeAPI.Data;
using FunincasaDevelopment.RecipeAPI.Models;
using FunincasaDevelopment.RecipeAPI.Models.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static Azure.Core.HttpHeader;

namespace FunincasaDevelopment.RecipeAPI.Controllers
{
    public class RecipeAPIController : Controller
    {
        private readonly ApplicationDbContext _database;
        private IMapper _mapper;
        private ResponseDto _response;

        public RecipeAPIController(ApplicationDbContext database, IMapper mapper)
        {
            _database = database;
            _mapper = mapper;
            _response = new ResponseDto();
        }

        // HTTP GET method to retrieve a list of recipes
        [HttpGet]
        
        public ResponseDto GetAll()
        {
            try
            {
                // Fetching all recipes from the database as a list
                IEnumerable<RecipeModel> recipeObjList = _database.Recipes.ToList();

                // Mapping the list of Recipe objects to a list of RecipeDto objects for the response
                // _mapper is assumed to be a service for mapping entities to DTOs
                _response.Result = _mapper.Map<IEnumerable<RecipeDto>>(recipeObjList);
            }
            catch (Exception ex)
            {
                // If any exception occurs during the database fetch or mapping, we handle it here
                _response.IsSuccess = false; // Indicate that the request was not successful
                _response.Message = ex.Message; // Capture and return the exception message for debugging
            }

            // Returning the response containing either the list of recipes or an error message
            return _response;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ResponseDto GetById(int id)
        {
            try
            {
                RecipeModel recipe = _database.Recipes.First(u => u.RecipeId == id);
                _response.Result = _mapper.Map<RecipeDto>(recipe);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }
        [HttpPut]
        [Route("Update{id:int}")]
        public ResponseDto Put(int id,RecipeDto recipeDto)
        {
            try
            {
                if (recipeDto == null)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Invalid request data.";
                    return _response;
                }

                // Retrieve the existing record
                var existingRecipe = _database.Recipes.FirstOrDefault(r => r.RecipeId == id);
                if (existingRecipe == null)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Recipe not found.";
                    return _response;
                }

                var dtoProperties = typeof(RecipeDto).GetProperties();
                foreach (var prop in dtoProperties)
                {
                    var newValue = prop.GetValue(recipeDto);
                    var existingProp = typeof(RecipeModel).GetProperty(prop.Name);

                    if (existingProp != null && prop.Name != "RecipeId")
                    {
                        var currentValue = existingProp.GetValue(existingRecipe);

                        // Update only if the new value is different and not null
                        if (newValue != null && !newValue.Equals(currentValue))
                        {
                            existingProp.SetValue(existingRecipe, newValue);
                        }
                    }
                }

                _database.SaveChanges();
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPut]
        [Route("Add")]
        public ResponseDto Post([FromBody] RecipeDto recipeDto)
        {
            try
            {
                if (recipeDto == null)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Invalid request data.";
                    return _response;
                }

                // Map DTO to Model
                RecipeModel newRecipe = _mapper.Map<RecipeModel>(recipeDto);

                // Add the new recipe to the database
                _database.Recipes.Add(newRecipe);
                _database.SaveChanges();

                _response.IsSuccess = true;
                _response.Message = "Recipe added successfully.";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }
        [HttpDelete]
        [Route("Delete/{id:int}")]
        public ResponseDto Delete(int id)
        {
            try
            {
                var existingRecipe = _database.Recipes.FirstOrDefault(r => r.RecipeId == id);
                if (existingRecipe == null)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Recipe not found.";
                    return _response;
                }

                // Remove the recipe from the database
                _database.Recipes.Remove(existingRecipe);
                _database.SaveChanges();

                _response.IsSuccess = true;
                _response.Message = "Recipe deleted successfully.";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }




    }
}
