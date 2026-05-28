using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class CustomizationController: DemoController {
        public ActionResult Templates() {
            return DemoView("Templates", SchedulerDataHelper.DataObject);
        }
        public ActionResult TemplatesPartial() {
            return PartialView("TemplatesPartial", SchedulerDataHelper.DataObject);
        }
        public ActionResult TemplatesCustomActionPartial(string callbackParam) {
            ViewData["callbackParam"] = callbackParam;
            return PartialView("TemplatesPartial", SchedulerDataHelper.DataObject);
        }
    }
}
