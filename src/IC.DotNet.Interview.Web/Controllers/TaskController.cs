using IC.DotNet.Interview.Logic.BL;
using System.Web.Mvc;

namespace IC.DotNet.Interview.Web.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskLogic _taskLogic;

        public TaskController(ITaskLogic taskLogic)
        {
            _taskLogic = taskLogic;
        }

        public ActionResult Index()
        {
            return View(_taskLogic.Get());
        }
    }
}