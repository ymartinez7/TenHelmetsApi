namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class FileService : BaseService<File>, IFileService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileRepository"></param>
        public FileService(IFileRepository fileRepository)
            : base(fileRepository)
        {

        }
    }
}
