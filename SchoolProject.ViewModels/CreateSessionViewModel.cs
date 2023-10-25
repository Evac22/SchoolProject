
using SchoolProject.Models;

namespace SchoolProject.ViewModels
{
    public class CreateSessionViewModel
    {
        public string Start { get; set; }
        public string End { get; set; }
        public Session Convert(CreateSessionViewModel vm)
        {
            return new Session
            {
                Start = vm.Start,
                End = vm.End
            };
        }
    }
}
