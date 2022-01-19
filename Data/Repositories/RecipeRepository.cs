using Data.Context;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class RecipeRepository : BaseRepository<Recipe>, IRecipesRepository
    {
        public RecipeRepository(SqlContext sqlContext) : base(sqlContext)
        {
        }

        public Recipe GetById(int id)
        {
            var obj = CurrentSet
                 .Where(x => x.id == id) 
                 .FirstOrDefault(); 
            return obj;
        }

        public IEnumerable<Recipe> GetRecipe()
        {
            var obj = CurrentSet
               .ToList();
            return obj;
        }
    }
}
