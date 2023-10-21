using SchoolProject.Utilities;
using SchoolProject.ViewModels;

namespace SchoolProject.Services
{
    public interface IStudentService
    {
        Task AddStudent(CreateStudentViewModel student);
        PagedResult<StudentViewModel> GetAll(int pageNumber, int pageSize);
        int GetAllStudents();
    }
}
