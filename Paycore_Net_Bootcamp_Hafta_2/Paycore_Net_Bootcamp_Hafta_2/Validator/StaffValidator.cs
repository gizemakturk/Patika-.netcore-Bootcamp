using FluentValidation;
using FluentValidation.Validators;
using Paycore_Net_Bootcamp_Hafta_2.Models;
using System;


namespace Paycore_Net_Bootcamp_Hafta_2.Validator
{
    public class StaffValidator : AbstractValidator<Staff>
    {
        /// <summary>
        /// Validate  values of Staff wanted values
        /// </summary>
        public StaffValidator()
        {
            var minYear = new DateTime(1945, 11, 11);
            var maxYear = new DateTime(2002, 10, 10);

            RuleFor(x => x.Name).NotEmpty().Length(4, 120).WithMessage("Please specify a  name");
            RuleFor(x => x.Lastname).NotEmpty().Length(4, 120).WithMessage("Please specify a last name");
            RuleFor(x => x.DateOfBirth).NotEmpty().GreaterThan(minYear).LessThan(maxYear).WithMessage("Please specify a first name");
            RuleFor(x => x.Email).Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").WithMessage("Please specify a valid  email");
            RuleFor(x => x.PhoneNumber).Matches(@"^\+90?[0-9]{10}$").WithMessage("Please specify a valid  number");
            RuleFor(x => x.Salary).GreaterThan(2000).LessThan(9000).WithMessage("Please specify a valid salary");
        }

    }
}
