using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public sealed class ModelService : BaseService<Model>, IModelService
    {
        public ModelService(IModelRepository modelRepository)
            : base(modelRepository)
        {

        }
    }
}
