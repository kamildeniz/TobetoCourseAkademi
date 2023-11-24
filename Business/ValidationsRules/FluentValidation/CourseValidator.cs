using Entities.Concrete;
using Entities.Concrete.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationsRules.FluentValidation
{
    public class CourseValidator:AbstractValidator<CourseDTO>
    {
        public CourseValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Name).MinimumLength(4);
            RuleFor(c => c.Price).GreaterThan(0);
            RuleFor(c => c.CategoryId).GreaterThan(0);
            RuleFor(c => c.Description).MaximumLength(100);
            RuleFor(c => c.Description).MinimumLength(50).MaximumLength(100).When(c=>c.CategoryId==1);
        }
    }
}
