using TenHelmets.API.Infrastructure.Data.Enums;
using TenHelmets.API.Infrastructure.Data.Interfaces;

namespace TenHelmets.API.Infrastructure.Data.Factories
{
    public static class ServiceConnectionFactory
    {
        public static IServiceConnection GetServiceConnection(ServiceTypeConnection serviceTypeConnection)
        {
            IServiceConnection _serviceConnection = null;
            switch (serviceTypeConnection)
            {
                case ServiceTypeConnection.Soap:
                    break;
                case ServiceTypeConnection.Rest:
                    break;
            }
            return _serviceConnection;
        }
    }
}
