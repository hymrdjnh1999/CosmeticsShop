using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Systems.Users
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty()
                .WithMessage("Tên không được để trống")
                .MaximumLength(50).WithMessage("Tên không thể quá 50 ký tự");

            RuleFor(x => x.UserName).NotEmpty()
                .WithMessage("Tài khoản không được để trống")
                .MaximumLength(100).WithMessage("Tài khoản không thể quá 100 ký tự");

            RuleFor(x => x.Password).NotEmpty()
               .WithMessage("Mật khẩu không được để trống")
               .MinimumLength(8).WithMessage("Mật khẩu phải có ít nhất 8 ký tự")
               .MaximumLength(21).WithMessage("Mật khẩu không thể quá 21 ký tự")
               .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,21}").WithMessage("Mật khẩu phải có ít nhất 1 ký tự đặc biệt, 1 chữ hoa ,1 chữ số và chữ thường!");

            RuleFor(x => x.PhoneNumber).NotEmpty()
                .WithMessage("Số điện thoại không được để trống")
                .MaximumLength(100).WithMessage("Tài khoản không thể quá 100 ký tự");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Email không được để trống")
                .MaximumLength(100).WithMessage("Email không thể quá 100 ký tự")
                .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").WithMessage("Không đúng định dạng email!");

            RuleFor(x => x.Dob)
                .GreaterThan(DateTime.Now.AddYears(-100))
                .WithMessage("Ngày sinh không thể lớn hơn 100 năm");

            RuleFor(x => x.ConfirmPassword).NotEmpty()
              .WithMessage("Mật khẩu không được để trống")
              .MinimumLength(8).WithMessage("Mật khẩu phải có ít nhất 8 ký tự")
              .MaximumLength(21).WithMessage("Mật khẩu không thể quá 21 ký tự")
              .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,21}").WithMessage("Mật khẩu phải có ít nhất 1 ký tự đặc biệt, 1 chữ hoa ,1 chữ số và chữ thường!");

            RuleFor(x => x).Custom((request, context) =>
            {
                if (request.Password != request.ConfirmPassword)
                {
                    context.AddFailure("Mật khẩu nhập lại không chính xác !");
                }

            });
        }


    }
}
