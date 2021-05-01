using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.ProductImages
{
    public class ProductImageUpdateValidator : AbstractValidator<ProductImageUpdateRequest>
    {
        public ProductImageUpdateValidator()
        {
            RuleFor(x => x.Caption).NotEmpty()
                .WithMessage("Chú thích không được để trống");
        }
    }
}
