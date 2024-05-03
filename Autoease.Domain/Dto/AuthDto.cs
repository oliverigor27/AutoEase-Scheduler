namespace Autoease.Domain.Dto;

public record AuthDto
{
    public string Email { get; private set; } = string.Empty;
    public string Password { get; private set; } = string.Empty;
}