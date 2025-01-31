using FluentValidation;
using SimpleStore.Domain.Models;

namespace SimpleStore.Application.Validations
{
    public class SupplierValidation : AbstractValidator<Supplier> {
        public SupplierValidation()
        {
            RuleFor(x => x.Name)
                .MaximumLength(80)
                .NotEmpty();

            RuleFor(x => x.ContactName)
                .MaximumLength(80)
                .NotEmpty();

            RuleFor(x => x.PhoneNumber)
               .MaximumLength(15)
               .NotEmpty();

            RuleFor(x => x.Email)
                .MaximumLength(80)
                .NotEmpty();


            RuleFor(x => x.Address)
                .MaximumLength(120)
                .NotEmpty();
        }
    }
    
}
