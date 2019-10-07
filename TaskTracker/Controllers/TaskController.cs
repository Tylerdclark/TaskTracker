using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskTracker.Models;

namespace TaskTracker.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task/IndexList
        public ActionResult IndexList()
        {
            var mission = new Mission() {Name = "First One!"};

            return View(mission);
        }
    }
}