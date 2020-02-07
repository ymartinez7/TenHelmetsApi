using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public sealed class FileService : BaseService<File>, IFileService
    {
        public FileService(IFileRepository fileRepository)
            : base(fileRepository)
        {

        }
    }
}
