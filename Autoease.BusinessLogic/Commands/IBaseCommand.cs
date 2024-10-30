using FluentValidation.Results;
using MediatR;

namespace Autoease.BusinessLogic.Commands;

public interface IBaseCommand : IRequest<ValidationResult>
{}