using Autoease.BusinessLogic.Commands.User;
using FluentValidation;

namespace Autoease.BusinessLogic.Validators.UserValidators;

public class RegisterUserValidator : AbstractValidator<RegisterUserCommand>
{
    public RegisterUserValidator()
    {
        RuleFor(user => user.Username).NotEmpty();
        RuleFor(user => user.Email).NotEmpty().EmailAddress();
        RuleFor(user => user.Password).NotEmpty();
        RuleFor(user => user.FirstName).NotEmpty();
        RuleFor(user => user.LastName).NotEmpty();
        RuleFor(user => user.Address).NotNull();
        RuleFor(user => user.UserIdCard).NotEmpty();
        RuleFor(user => user.Veichle).NotEmpty();
    }
}
