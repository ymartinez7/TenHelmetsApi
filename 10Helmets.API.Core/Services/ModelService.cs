namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ModelService : BaseService<Model>, IModelService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelRepository"></param>
        public ModelService(IModelRepository modelRepository)
            : base(modelRepository)
        {

        }
    }
}
