using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Takım Arkadaşı İsmini Boş Geçemezsiniz");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görev Kısmını Boş Geçemezsiniz");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim Kısmını Boş Geçemezsiniz");
            RuleFor(x => x.PersonName).MaximumLength(50).WithMessage("Lütfen 50 karakterden az veri girişi yapınız");
            RuleFor(x => x.PersonName).MinimumLength(5).WithMessage("Lütfen  en az 5 karakterli veri girişi yapınız");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen 50 karakterden az veri girişi yapınız");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Lütfen  en az 3 karakterli veri girişi yapınız");
        }
    }
}
