namespace _10Helmets.API.Core.Interfaces.Cross_cutting
{
    public interface IApplicationLogger<T>
    {
        void LogInformation(string message, params object[] args);
        void LogWarning(string message, params object[] args);
    }
}
