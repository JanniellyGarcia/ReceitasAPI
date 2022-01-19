using Domain.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Validations
{
    public class RecipeValidator : AbstractValidator<Recipe>
    {
        public RecipeValidator()
        {
            RuleFor(c => c.title)
                .NotEmpty().WithMessage("Por favor, insira o nome da sua receita:")
                .NotNull().WithMessage("Por favor, insira o nome da sua receita:");
            RuleFor(c => c.ingredients)
                .NotEmpty().WithMessage("Por favor, insira os ingredientes separados por vírgula:")
                .NotNull().WithMessage("Por favor, insira os ingredientes separados por vírgula:");
        }
    }
}
