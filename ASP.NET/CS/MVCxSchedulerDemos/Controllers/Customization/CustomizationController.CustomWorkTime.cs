using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class CustomizationController : DemoController {
        public ActionResult CustomWorkTime() {
            ViewData["isCustomWorkTimeEnabled"] = false;
            return DemoView("CustomWorkTime", SchedulerDataHelper.DataObject);
        }
        public ActionResult CustomWorkTimePartial(bool isCustomWorkTimeEnabled) {
            ViewData["isCustomWorkTimeEnabled"] = isCustomWorkTimeEnabled;
            return PartialView("CustomWorkTimePartial", SchedulerDataHelper.DataObject);
        }
    }
}
