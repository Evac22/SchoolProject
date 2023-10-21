

using SchoolProject.Models;

namespace SchoolProject.ViewModels
{
    public class CreateStudentViewModel
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DateOfJoin { get; set; } = DateTime.Now;
        public bool Selected {  get; set; }
        public string KeyId { get; set; }
        public string UserName {  get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        
        public Student ConvertModel(CreateStudentViewModel student)
        {
            return new Student
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                DOB = student.DOB,
                DateofJoin = student.DateOfJoin,               
                KeyId = student.KeyId
            };
        }
    }
}
