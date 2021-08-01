﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Systems.Clients
{
    public class ClientLoginValidation : AbstractValidator<ClientLoginRequest>
    {
        public ClientLoginValidation()
        {
            const int passwordCharacters = 6;
            RuleFor(x => x.Email).NotEmpty().WithMessage("Tài khoản không được để trống!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Mật khẩu không được để trống!").MinimumLength(passwordCharacters).WithMessage($"Mật khẩu phải có ít nhất {passwordCharacters} ký tự");
        }
    }
}
