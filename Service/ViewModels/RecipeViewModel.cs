using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Service.ViewModels
{
    public class RecipeViewModel
    {
        [JsonPropertyName("Titulo")]
        public string title { get; set; }

        [JsonPropertyName("Ingredientes")]
        public string ingredients { get; set; }
    }
}
