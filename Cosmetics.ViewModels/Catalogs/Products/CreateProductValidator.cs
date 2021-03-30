using Cosmetics.ViewModels.Catalogs.Products.Manage;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.Products
{
    public class CreateProductValidator : AbstractValidator<ProductCreateRequest>
    {
        public CreateProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty()
                .WithMessage("Product name is require")
                .MaximumLength(200).WithMessage("Product name max is 200 character");

            RuleFor(x => x.Price).NotEmpty()
                .WithMessage("Price is require").GreaterThan(100000).WithMessage("Product price is must greater than 100000!");

            RuleFor(x => x.ForGender).NotEmpty()
                .WithMessage("Product for gender is require");
            RuleFor(x => x.OriginalPrice).NotEmpty()
                .WithMessage("Original price is require").GreaterThan(100000).WithMessage("Product original price is must greater than 100000!"); 

            RuleFor(x => x).Custom((request, context) =>
            {
                if (request.OriginalPrice > request.Price)
                {
                    context.AddFailure("Original price is not less than price");
                }

            });

            RuleFor(x => x.Stock).NotEmpty().WithMessage("Stock is require").GreaterThan(-1).WithMessage("Stock is can not negative");

        }
    }
}
