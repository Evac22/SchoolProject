using System.ComponentModel.DataAnnotations.Schema;


namespace SchoolProject.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public ICollection<GradeSubject> GradeSubjects { get; set; }
    }
}
