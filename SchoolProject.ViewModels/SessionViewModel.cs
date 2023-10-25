
using SchoolProject.Models;

namespace SchoolProject.ViewModels
{
    public class SessionViewModel
    {
        public int Id { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public List<GradeViewModel> gradeViewModel { get; set; }
        public string Combined
        {
            get
            {
                return Start + "-" + End;
            }
        }
        public SessionViewModel(Session model)
        {
            Id = model.Id;
            Start = model.Start;
            End = model.End;
        }
        public SessionViewModel()
        {
            
        }
    }
}
