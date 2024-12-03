using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.Validation_Rules
{
    public class AnnouncementValidator : AbstractValidator<Announcement>
    {
        public AnnouncementValidator()
        {
            RuleFor(a=>a.Title).NotEmpty().WithMessage("Başlık alanı boş geçilemez");
            RuleFor(x => x.Title).MinimumLength(5).MaximumLength(30).WithMessage("Başlık alanı 5 ile 30 karakter arasında olmalıdır!");

            RuleFor(a=>a.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
            RuleFor(x => x.Description).MinimumLength(5).MaximumLength(500).WithMessage("Açıklama alanı 5 ile 500 karakter arasında olmalıdır!");


        }
    }
}
