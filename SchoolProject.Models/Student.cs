using ServiceStack.DataAnnotations;


namespace SchoolProject.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB {  get; set; }
        public DateTime DateofJoin { get; set; }
        public bool Selected { get; set; }
        [Unique]
        public string KeyId { get; set; }
        public ICollection<Enroll> YearlySession { get; set; }

    }
}
