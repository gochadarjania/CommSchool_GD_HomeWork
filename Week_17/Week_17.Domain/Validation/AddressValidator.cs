using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_17.Daomain;

namespace Week_17.Domain.Validation
{
    internal class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {

            RuleFor(x => x.Country)
                .NotEmpty().WithMessage("{PropertyName} is Empty");

            RuleFor(x => x.City)
                .NotEmpty().WithMessage("{PropertyName} is Empty");

            RuleFor(x => x.HomeNumber)
                .NotEmpty().WithMessage("{PropertyName} is Empty");
        }
    }
}
