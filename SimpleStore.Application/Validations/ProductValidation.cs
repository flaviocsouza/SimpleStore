using FluentValidation;
using SimpleStore.Domain.Models;

namespace SimpleStore.Application.Validations
{
    public class ProductValidation : AbstractValidator<Product> {
        public ProductValidation()
        {
            RuleFor(x => x.Name)
                .MaximumLength(80)
                .NotEmpty();

            RuleFor(x => x.Description)
                .MaximumLength(120)
                .NotEmpty();

            RuleFor(x => x.Price)
                .GreaterThan(0)
                .NotEmpty();

            RuleFor(x => x.StockQuantity)
                .GreaterThanOrEqualTo(0)
                .NotEmpty();
        }
    }
    
}
