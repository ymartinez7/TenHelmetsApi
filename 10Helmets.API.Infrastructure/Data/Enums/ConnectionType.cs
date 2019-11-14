namespace _10Helmets.API.Infrastructure.Data.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConnectionType : int
    {
        /// <summary>
        /// Coresponde a una conexión de base de datos
        /// </summary>
        DBBBBB = 1,

        /// <summary>
        /// Corresponde a una conexión a un documento
        /// </summary>
        Document,

        /// <summary>
        /// Corresponde a una conexión a un servicio
        /// </summary>
        Service,
    }
}
