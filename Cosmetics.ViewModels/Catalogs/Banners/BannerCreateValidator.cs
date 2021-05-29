using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.Banners
{
    public class BannerCreateValidator : AbstractValidator<BannerCreateRequest>
    {
        public BannerCreateValidator() { 
            RuleFor(x => x.ImageFile).NotEmpty()
                .WithMessage("Ảnh banner quảng cáo không được để trống");

            RuleFor(x => x.Description).NotEmpty()
                .WithMessage("Mô tả không được để trống");
        }
    }
}
