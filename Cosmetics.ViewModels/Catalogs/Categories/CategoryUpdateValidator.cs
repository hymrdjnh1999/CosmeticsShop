using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.Categories
{
    public class CategoryUpdateValidator : AbstractValidator<CategoryUpdateRequest>
    {
        public CategoryUpdateValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Không thể để trống trường này!");
        }
    }
}
