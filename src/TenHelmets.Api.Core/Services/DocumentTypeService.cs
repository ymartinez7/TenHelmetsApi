using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public class DocumentTypeService : BaseService<DocumentType>, IDocumentTypeService
    {
        public DocumentTypeService(IDocumentTypeRepository documentTypeRepository)
            : base(documentTypeRepository)
        {

        }
    }
}
