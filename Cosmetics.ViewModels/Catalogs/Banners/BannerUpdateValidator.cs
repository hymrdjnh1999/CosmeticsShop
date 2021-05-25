using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.Banners
{
    class BannerUpdateValidator : AbstractValidator<BannerUpdateRequest>
    {
         public BannerUpdateValidator()
        {
            RuleFor(x => x.Description).NotEmpty()
                .WithMessage("Mô tả không được để trống");
        }
    }
}
