namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class NoteService : BaseService<Note>, INoteService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="noteRepository"></param>
        public NoteService(INoteRepository noteRepository)
            : base(noteRepository)
        {

        }
    }
}
