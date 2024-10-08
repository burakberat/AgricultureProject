using AgricultureEntityLayer.Concrete;
using FluentValidation;

namespace AgricultureBusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("İsim boş geçilemez.");
            RuleFor(x => x.PersonName).MaximumLength(50).WithMessage("Lütfen 50 karakterden daha kısa veri girişi yapınız.");
            RuleFor(x => x.PersonName).MinimumLength(5).WithMessage("Lütfen 5 karakterden daha uzun veri girişi yapınız.");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görev boş geçilemez.");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen 50 karakterden daha kısa veri girişi yapınız.");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen 5 karakterden daha uzun veri girişi yapınız.");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim boş geçilemez");
        }
    }
}
