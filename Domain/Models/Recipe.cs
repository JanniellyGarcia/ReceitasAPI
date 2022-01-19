using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Recipe : BaseEntity
    {
        public string title { get; set; }
        public string ingredients { get; set; }
    }
}
