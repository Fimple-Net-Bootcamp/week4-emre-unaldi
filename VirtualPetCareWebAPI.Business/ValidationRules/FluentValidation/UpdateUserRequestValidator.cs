﻿using FluentValidation;
using VirtualPetCareWebAPI.Entity.Concretes.Requests;

namespace VirtualPetCareWebAPI.Business.ValidationRules.FluentValidation
{
    public class UpdateUserRequestValidator : AbstractValidator<UpdateUserRequest>
    {
        public UpdateUserRequestValidator()
        {
            RuleFor(request => request.Id)
                .GreaterThan(0).WithMessage("Enter a valid user id");

            RuleFor(request => request.FirstName)
                .NotEmpty().WithMessage("The firstname cannot be empty")
                .MaximumLength(50).WithMessage("The firstname must be a maximum of 50 characters");

            RuleFor(request => request.LastName)
                .NotEmpty().WithMessage("LastName cannot be empty")
                .MaximumLength(50).WithMessage("LastName must be a maximum of 50 characters");

            RuleFor(request => request.Email)
                .NotEmpty().WithMessage("Email cannot be empty")
                .EmailAddress().WithMessage("Enter a valid e-mail address");

            RuleFor(request => request.PhoneNumber)
                .NotEmpty().WithMessage("Phone number cannot be empty")
                .Matches(@"^[0-9]*$").WithMessage("Enter a valid phone number");
        }
    }
}
