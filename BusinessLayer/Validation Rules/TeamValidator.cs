using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.Validation_Rules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez!");
            RuleFor(x => x.Name).MinimumLength(5).MaximumLength(30).WithMessage("İsim alanı 5 ile 30 karakter arasında olmalıdır!");

            RuleFor(x => x.Title).NotEmpty().WithMessage("Ünvan alanı boş geçilemez!");
            RuleFor(x => x.Title).MinimumLength(3).MaximumLength(20).WithMessage("Ünvan alanı 3 ile 20 karakter arasında olmalıdır!");

            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel alanı boş geçilemez!");
        }
    }
}
