

using ServiceStack.DataAnnotations;

namespace SchoolProject.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DateofJoin { get; set; }
        public bool Selected { get; set; }
        [Unique]
        public string KeyId { get; set; }
        public string Qualification {  get; set; }
        public int YearOfEx {  get; set; }
        public ICollection<AssignGrade> AssignGrades { get; set;}
        public ICollection<TeacherSession> TeacherSessions
        {
            get;set;
        }

    }
}
