

namespace SchoolProject.Models
{
    public class TeacherSession
    {
        public int Id { get; set; }
        public int? TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public int? SessionId { get; set; }
        public Session? Session { get; set; }

    }
}
