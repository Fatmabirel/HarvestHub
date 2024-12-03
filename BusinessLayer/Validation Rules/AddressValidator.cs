using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.Validation_Rules
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {

            RuleFor(x => x.Description1).NotEmpty().WithMessage("Açıklama 1 boş olamaz");
            RuleFor(x => x.Description2).NotEmpty().WithMessage("Açıklama 2 boş olamaz");
            RuleFor(x => x.Description3).NotEmpty().WithMessage("Açıklama 3 boş olamaz");
            RuleFor(x => x.Description4).NotEmpty().WithMessage("Açıklama 4 boş olamaz");
            RuleFor(x => x.MapInfo).NotEmpty().WithMessage("Harita bilgisi boş olamaz");

            RuleFor(x => x.Description1).MaximumLength(40).WithMessage("Açıklama 1 maksimum 40 karakter olmalıdır");
            RuleFor(x => x.Description2).MaximumLength(40).WithMessage("Açıklama 2 maksimum 40 karakter olmalıdır");
            RuleFor(x => x.Description3).MaximumLength(40).WithMessage("Açıklama 3 maksimum 40 karakter olmalıdır");
            RuleFor(x => x.Description4).MaximumLength(40).WithMessage("Açıklama 4 maksimum 40 karakter olmalıdır");
        }
    }
}
