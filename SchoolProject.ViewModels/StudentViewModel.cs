

using SchoolProject.Models;

namespace SchoolProject.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DateOfJoin { get; set; } = DateTime.Now;
        public bool Selected { get; set; }
        public string KeyId { get; set; }
        public bool SelectAll {  get; set; }
        //public string Email { get; set;}
        public StudentViewModel()
        {
            
        }

        public StudentViewModel(Student student)
        {
            Id = student.Id;
            FirstName = student.FirstName;
            LastName = student.LastName;
            DOB = student.DOB;
            DateOfJoin = student.DateofJoin;          
            KeyId = student.KeyId;
            //Email = student.Email;
        }
    }
}
