using SchoolProject.Utilities;
using SchoolProject.ViewModels;

namespace SchoolProject.Services
{
    public interface ISessionService
    {
        Task Add(CreateSessionViewModel vm);
        PagedResult<SessionViewModel> GetAll(int pageNumber, int pageSize);
        IEnumerable<SessionViewModel> GetAll();
        SessionViewModel GetById(int sessionId);
    }
}
