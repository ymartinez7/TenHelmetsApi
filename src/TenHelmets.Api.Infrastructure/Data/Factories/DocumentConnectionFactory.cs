using TenHelmets.API.Infrastructure.Data.Enums;
using TenHelmets.API.Infrastructure.Data.Interfaces;

namespace TenHelmets.API.Infrastructure.Data.Factories
{
    public static class DocumentConnectionFactory
    {
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
