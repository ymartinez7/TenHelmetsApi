using TenHelmets.API.Infrastructure.Data.Enums;
using TenHelmets.API.Infrastructure.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace TenHelmets.API.Infrastructure.Data.Factories
{
    public sealed class ConnectionManagerFactory : IConnectionManager
    {
        private static readonly object _thread;
        private static ConnectionManagerFactory _instancia;

        public static ConnectionManagerFactory ObtenerInstancia
        {
            get
            {
                if (_instancia == null)
                {
                    lock (_thread)
                    {
                        if (_instancia == null)
                        {
                            _instancia = new ConnectionManagerFactory();
                        }
                    }
                }
                return _instancia;
            }
        }


        private ConnectionManagerFactory()
        { }

        static ConnectionManagerFactory()
        {
            _thread = new object();
        }


        public IDbConnection GetDbConnection(DbContext dbContext)
        {
            return DbConnectionFactory.GetConnection(dbContext);
        }

        public IDocumentConnection GetDocumentConnection(DocumentTypeConnection documentTypeConnection)
        {
            return DocumentConnectionFactory.GetDocumentConnection(documentTypeConnection);
        }

        public IServiceConnection GetServiceConnection(ServiceTypeConnection serviceTypeConnection)
        {
            return ServiceConnectionFactory.GetServiceConnection(serviceTypeConnection);
        }
    }
}
