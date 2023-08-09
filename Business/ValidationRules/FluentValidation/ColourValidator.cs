using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ColourValidator: AbstractValidator<Colour>
    {
        public ColourValidator()
        {
            RuleFor(c=>c.ColourId).NotEmpty();
            RuleFor(c => c.ColourName).MinimumLength(2).NotEmpty();
        }
    }
}
