using System.Runtime.InteropServices;

namespace TaskTracker.Models
{
    public class MissionSubTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTaskOwner { get; set; }
    }
}