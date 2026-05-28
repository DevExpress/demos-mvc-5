using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SchedulerController: DemoController {
        public override string Name { get { return "Scheduler"; } }

        public ActionResult Index() {
            return RedirectToAction("Grouping");
        }   
    }
}
