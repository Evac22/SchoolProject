
using SchoolProject.Models;

namespace SchoolProject.ViewModels
{
    public class CreateGradeViewModel
    {
        public string Name { get; set; }
        public Grade Convert(CreateGradeViewModel vm)
        {
            return new Grade { Name = vm.Name };
        }
    }
}
