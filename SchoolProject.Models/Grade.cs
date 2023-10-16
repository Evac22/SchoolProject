

using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public ICollection<AssignGrade> AssignGrades { get; set;} = new HashSet<AssignGrade>();
        [NotMapped]
        public ICollection<Enroll> Enrolls { get; set; } = new HashSet<Enroll>();
        public ICollection<GradeSubject> GradeSubjects { get; set; }
    }
}
