using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Görsel başlığını boş geçemezsin");
            RuleFor(x=>x.Description).NotEmpty().WithMessage("Açıklamayı boş geçemezsin");
            RuleFor(x=>x.ImageUrl).NotEmpty().WithMessage("Görsel yolunu boş geçemezsin");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter girşi yapınız ");
            RuleFor(x => x.Title).MinimumLength(8).WithMessage("Lütfen en az 8 karakter girşi yapınız ");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girşi yapınız ");
            RuleFor(x => x.Description).MinimumLength(20).WithMessage("Lütfen en az 20 karakter girşi yapınız ");
        }
    }
}
