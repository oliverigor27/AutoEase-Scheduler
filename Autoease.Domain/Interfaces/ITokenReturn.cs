namespace Autoease.Domain.Interfaces;

public interface ITokenReturn
{
    bool IsValid { get; set; }
    string Token { get; set; }
}