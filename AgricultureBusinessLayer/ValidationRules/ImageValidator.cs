using AgricultureEntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricultureBusinessLayer.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlığı boş geçemezsiniz.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz.");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Dosya yolunu boş geçemezsiniz.");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter giriniz.");
            RuleFor(x => x.Title).MinimumLength(8).WithMessage("Lütfen en az 8 karakter giriniz.");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter giriniz.");
            RuleFor(x => x.Description).MinimumLength(20).WithMessage("Lütfen en az 20 karakter giriniz.");
        }
    }
}
