using FluentValidation;
using SimpleStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStore.Application.Validations
{
    public class CustomerValidation : AbstractValidator<Customer> 
    {
        public CustomerValidation()
        {
            RuleFor(x => x.FullName)
                .MaximumLength(80)
                .NotEmpty();

            RuleFor(x => x.Email)
                .MaximumLength(80)
                .NotEmpty();

            RuleFor(x => x.PhoneNumber)
                .MaximumLength(15)
                .NotEmpty();

            RuleFor(x => x.Address)
                .MaximumLength(120)
                .NotEmpty();
        }
    }
    
}
