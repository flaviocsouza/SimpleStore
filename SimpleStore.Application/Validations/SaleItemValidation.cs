using FluentValidation;
using SimpleStore.Domain.Models;

namespace SimpleStore.Application.Validations
{
    public class SaleItemValidation : AbstractValidator<SaleItem> {
        public SaleItemValidation()
        {
            RuleFor(x => x.SaleId)
                .NotEmpty();

            RuleFor(x => x.ProductId)
                .NotEmpty();

            RuleFor(x => x.Quantity)
                .NotEmpty()
                .GreaterThan(0);
        }
    }
    
}
