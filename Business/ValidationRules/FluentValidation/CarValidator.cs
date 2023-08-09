using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p=>p.CarId).NotEmpty();
            RuleFor(p => p.ModelYear).GreaterThanOrEqualTo(1995);
            RuleFor(p=>p.BrandId).NotEmpty();
            RuleFor(p=>p.Description).MaximumLength(15);
            RuleFor(p=>p.DailyPrice).GreaterThanOrEqualTo(30000);
            
        }
    }
}
