namespace TenHelmets.API.Core.Interfaces.Services
{
    public interface IApplicationLogger<T>
    {
        void LogInformation(string message, params object[] args);
        void LogWarning(string message, params object[] args);
    }
}
