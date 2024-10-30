using System;
using Autoease.BusinessLogic.Commands.User;
using FluentValidation.Results;
using MediatR;

namespace Autoease.BusinessLogic.Handlers.UserHandlers;

public sealed class RegisterUserHandler : IRequestHandler<RegisterUserCommand, ValidationResult>
{
    public Task<ValidationResult> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
