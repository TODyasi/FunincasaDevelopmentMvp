using AutoMapper;
using FunincasaDevelopment.RecipeAPI.Models;
using FunincasaDevelopment.RecipeAPI.Models.Dtos;

namespace FunincasaDevelopment.RecipeAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                // Define the mappings for Recipe and RecipeDto
                config.CreateMap<RecipeModel, RecipeDto>();  // Mapping from Recipe to RecipeDto
                config.CreateMap<RecipeDto, RecipeModel>();  // Mapping from RecipeDto to Recipe
            });

            return mappingConfig;
        }
    }
}
