using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_17.Domain;

namespace Week_17.Service
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x => x.CreateDate)
                .NotEmpty().WithMessage("{PropertyName} is Empty")
                .Must(ValidCreateDate).WithMessage("{PropertyName} Invalid");

            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("{PropertyName} is Empty")
                .Length(0, 50).WithMessage("Length ({TotalLength}) of {PropertyName} invalid")
                .Must(ValidSymbolOfName).WithMessage("{PropertyName} contains Invalid character");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("{PropertyName} is Empty")
                .Length(0, 50).WithMessage("Length ({TotalLength}) of {PropertyName} invalid")
                .Must(ValidSymbolOfName).WithMessage("{PropertyName} contains Invalid character");

            RuleFor(x => x.JobPosition)
                .NotEmpty().WithMessage("{PropertyName} is Empty")
                .Length(0, 50).WithMessage("Length ({TotalLength}) of {PropertyName} invalid")
                .Must(ValidSymbolOfName).WithMessage("{PropertyName} contains Invalid character");

            RuleFor(x => x.Salary)
                .NotEmpty().WithMessage("{PropertyName} is Empty")
                .Must(ValidSalary).WithMessage("{PropertyName} Invalid");

            RuleFor(x => x.WorkExperince)
                .NotEmpty().WithMessage("{PropertyName} is Empty");

            //RuleFor(x => x.PersonAddress.Country)
            //    .NotEmpty().WithMessage("{PropertyName} is Empty");

            //RuleFor(x => x.PersonAddress.City)
            //    .NotEmpty().WithMessage("{PropertyName} is Empty");

            //RuleFor(x => x.PersonAddress.HomeNumber)
            //    .NotEmpty().WithMessage("{PropertyName} is Empty");
        }

        protected bool ValidSymbolOfName(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");

            return name.All(Char.IsLetter);
        }

        protected bool ValidCreateDate(DateTime data)
        {
            var nowData = DateTime.Now;

            if (data < nowData)
            {
                return true;
            }

            return false;
        }
        protected bool ValidSalary(double salary)
        {
            if (0 < salary && salary < 10000)
            {
                return true;
            }

            return false;
        }
    }
}
