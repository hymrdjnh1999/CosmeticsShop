﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.Banners
{
    public class BannerUpdateValidator : AbstractValidator<BannerUpdateRequest>
    {
         public BannerUpdateValidator()
        {
            RuleFor(x => x.Description).NotEmpty()
                .WithMessage("Tên không được để trống");
            RuleFor(x => x.Description).NotEmpty()
                .WithMessage("Mô tả không được để trống");
        }
    }
}
