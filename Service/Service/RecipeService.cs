using AutoMapper;
using Domain.Interfaces;
using Domain.Models;
using Service.Interfaces;
using Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class RecipeService : IRecipeService
    {
        private readonly IBaseRepository<Recipe> _baseRepository;
        private IRecipesRepository _recipesRepository;
        private readonly IMapper _mapper;
        public RecipeService(IBaseRepository<Recipe> baseRepository, IRecipesRepository recipesRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _recipesRepository = recipesRepository;
            _mapper = mapper;
        }

        public IEnumerable<RecipeViewModel> GetUser()
        {
            var recipe = _recipesRepository.GetRecipe();
            return _mapper.Map<IEnumerable<RecipeViewModel>>(recipe);
        }
    }
}
