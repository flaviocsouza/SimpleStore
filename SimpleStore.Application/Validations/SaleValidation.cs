using FluentValidation;
using SimpleStore.Domain.Models;

namespace SimpleStore.Application.Validations
{
    public class SaleValidation : AbstractValidator<Sale> {
        public SaleValidation()
        {
            RuleFor(x => x.CustomerId)
                .NotEmpty();

            RuleFor(x => x.SaleDate)
                .NotEmpty();

            RuleFor(x => x.SaleItems)
                .NotEmpty()
                .NotEmpty();
        }
    }
    
}
