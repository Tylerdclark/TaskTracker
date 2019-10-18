using System;
using System.Collections.Generic;
using System.Web.Mvc;
using TaskTracker.Models;
using TaskTracker.ViewModels;

namespace TaskTracker.Controllers
{
    public class MissionController : Controller
    {
        // GET: Mission/MissionList
        public ActionResult MissionList()
        {
            var mission = new Mission() {Name = "First One!"};

            var detailList = new List<MissionSubTask>
            {
                new MissionSubTask{ Id = 1},
                new MissionSubTask{ Id = 2}
            };

            var viewModel = new MissionListViewModel
            {
                Mission = mission,
                MissionSubTasks = detailList
            };

            return View(viewModel);
        }
        [Route("tasks/created/{year}/{month:regex(\\d{2}):range(1, 12)}")]

        public ActionResult ByCreationDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            //for now this is just returning simple content. Later I will want to feed in a specific view.

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
    }
}