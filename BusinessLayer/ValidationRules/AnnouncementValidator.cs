using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;

namespace BusinessLayer.ValidationRules;

public class AnnouncementValidator : AbstractValidator<AnnouncementAddDTOs>
{
    public AnnouncementValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen Başlığı boş geçmeyin");
        RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen duyuru içeriğini boş geçmeyin");
        RuleFor(x => x.Title).MinimumLength(5).WithMessage("En az 5 karakter girmelisiniz");
        RuleFor(x => x.Title).MaximumLength(50).WithMessage("En fazla 50 karakter girilebilir");
        RuleFor(x => x.Content).MinimumLength(5).WithMessage("En az 5 karakter girmelisiniz");
        RuleFor(x => x.Content).MaximumLength(500).WithMessage("En fazla 500 karakter girilebilir");
    }
}