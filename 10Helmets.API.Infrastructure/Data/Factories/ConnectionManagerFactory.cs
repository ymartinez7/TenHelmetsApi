namespace _10Helmets.API.Infrastructure.Data.Factories
{
    using _10Helmets.API.Infrastructure.Data.Enums;
    using _10Helmets.API.Infrastructure.Data.Interfaces;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ConnectionManagerFactory : IConnectionManager
    {
        #region Campos
        /// <summary>
        /// 
        /// </summary>
        private static readonly object _thread;

        /// <summary>
        /// 
        /// </summary>
        private static ConnectionManagerFactory _instancia;
        #endregion

        #region properties
        /// <summary>
        /// 
        /// </summary>
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
        #endregion

        #region constructores
        /// <summary>
        /// 
        /// </summary>
        private ConnectionManagerFactory()
        { }

        /// <summary>
        /// 
        /// </summary>
        static ConnectionManagerFactory()
        {
            _thread = new object();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContext"></param>
        /// <returns></returns>
        public IDbConnection GetDbConnection(DbContext dbContext)
        {
            return DbConnectionFactory.GetConnection(dbContext);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentTypeConnection"></param>
        /// <returns></returns>
        public IDocumentConnection GetDocumentConnection(DocumentTypeConnection documentTypeConnection)
        {
            return DocumentConnectionFactory.GetDocumentConnection(documentTypeConnection);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceTypeConnection"></param>
        /// <returns></returns>
        public IServiceConnection GetServiceConnection(ServiceTypeConnection serviceTypeConnection)
        {
            return ServiceConnectionFactory.GetServiceConnection(serviceTypeConnection);
        }
        #endregion
    }
}
