using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace BusinessLayer.ValidationRules;

public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTOs>
{
    public AppUserRegisterValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
        RuleFor(x => x.Surname).NotEmpty().WithMessage("soyad alanı boş geçilemez");
        RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez");
        RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez");
        RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez");
        RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre Tekrar alanı boş geçilemez");
        RuleFor(x => x.Username).MinimumLength(5).WithMessage("En az 5 karakter girilmelidir.");
        RuleFor(x => x.Username).MaximumLength(20).WithMessage("En fazla 20 karakter girilebilir.");
        RuleFor(x => x.Password).Equal(a => a.ConfirmPassword).WithMessage("Şifreler birbiriyle uyuşmuyor");
    }
}