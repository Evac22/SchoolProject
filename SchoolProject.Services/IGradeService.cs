using SchoolProject.Utilities;
using SchoolProject.ViewModels;

namespace SchoolProject.Services
{
    public interface IGradeService
    {
        Task Add(CreateGradeViewModel vm);
        int AddGradeWithStudent(GradeViewModel grade, int sessionId, List<int> StudentList);
        PagedResult<GradeViewModel> GetAll(int pageNumber, int pageSize);
        IEnumerable<GradeViewModel> GetAll();
        GradeViewModel GetById(int gradeId);
    }
}
