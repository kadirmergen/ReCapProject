using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomersForCarValidator: AbstractValidator<CustomersForCar>
    {
        public CustomersForCarValidator()
        {
            RuleFor(c=>c.UserId).NotEmpty();
            RuleFor(c=>c.CompanyName).MinimumLength(5).MaximumLength(25);
        }
    }
}
