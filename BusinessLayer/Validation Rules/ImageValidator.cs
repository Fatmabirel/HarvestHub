using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.Validation_Rules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(i => i.Title).NotEmpty().WithMessage("Başlık alanı boş geçilemez!");
            RuleFor(x => x.Title).MinimumLength(5).MaximumLength(20).WithMessage("Başlık alanı 5 ile 20 karakter arasında olmalıdır!");

            RuleFor(i => i.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez!");
            RuleFor(x => x.Description).MinimumLength(20).MaximumLength(50).WithMessage("Açıklama alanı 20 ile 50 karakter arasında olmalıdır!");

            RuleFor(i => i.ImageUrl).NotEmpty().WithMessage("Görsel alanı boş geçilemez!");

        }
    }
}
