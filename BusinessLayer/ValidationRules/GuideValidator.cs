using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules;

public class GuideValidator : AbstractValidator<Guide>
{
    public GuideValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen rehber adını giriniz");
        RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen rehber açıklamasını giriniz");
        RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen rehber görselini seçiniz");
        RuleFor(x => x.Name).MaximumLength(30).WithMessage("En fazla 30 karakter girilebilir");
        RuleFor(x => x.Name).MinimumLength(8).WithMessage("En az 8 karakter girilmelidir");
    }
}