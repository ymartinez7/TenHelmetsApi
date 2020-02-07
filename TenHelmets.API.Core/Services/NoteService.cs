using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public sealed class NoteService : BaseService<Note>, INoteService
    {
        public NoteService(INoteRepository noteRepository)
            : base(noteRepository)
        {

        }
    }
}
