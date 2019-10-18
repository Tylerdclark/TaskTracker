using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskTracker.Models;

namespace TaskTracker.ViewModels
{
    public class MissionListViewModel
    {
        public Mission Mission { get; set; }
        public List<MissionSubTask> MissionSubTasks { get; set; }
    }
}