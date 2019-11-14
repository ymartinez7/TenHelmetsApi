namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public class DocumentTypeService : BaseService<DocumentType>, IDocumentTypeService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentTypeRepository"></param>
        public DocumentTypeService(IDocumentTypeRepository documentTypeRepository)
            : base(documentTypeRepository)
        {

        }
    }
}
