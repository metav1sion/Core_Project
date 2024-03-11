using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje Adı Boş Geçilemez").MinimumLength(5).WithMessage("Proje Adı En Az 5 Karakterden Oluşmak Zorundadır.").MaximumLength(100).WithMessage("Proje Adı En Fazla 100 Karakterden Oluşmak Zorundadır.");

            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel alanı boş geçilemez.");
        }
    }
}