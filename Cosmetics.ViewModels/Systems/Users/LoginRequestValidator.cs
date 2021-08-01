using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Systems.Users
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            const int passwordCharacters = 6;
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Tài khoản không được để trống!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Mật khẩu không được để trống!").MinimumLength(passwordCharacters).WithMessage($"Mật khẩu phải có ít nhất {passwordCharacters} ký tự");
        }
    }
}
