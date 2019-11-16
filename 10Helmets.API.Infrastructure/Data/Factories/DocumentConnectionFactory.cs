namespace _10Helmets.API.Infrastructure.Data.Factories
{
    using _10Helmets.API.Infrastructure.Data.Enums;
    using _10Helmets.API.Infrastructure.Data.Interfaces;

    /// <summary>
    /// 
    /// </summary>
    public static class DocumentConnectionFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tipoDocumento"></param>
        /// <returns></returns>
        public static IDocumentConnection GetDocumentConnection(DocumentTypeConnection documentTypeConnection)
        {
            IDocumentConnection _conexionDocumento = null;
            switch (documentTypeConnection)
            {
                case DocumentTypeConnection.Xml:
                    break;
                case DocumentTypeConnection.Csv:
                    break;
                case DocumentTypeConnection.Txt:
                    break;
            }

            return _conexionDocumento;
        }
    }
}
