using System.Web.Mvc;
using DevExpress.XtraScheduler;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController: DemoController {
        public ActionResult Grouping() {
            return DemoView("Grouping", SchedulerDataHelper.DataObject);
        }
        public ActionResult GroupingPartial() {
            return PartialView("GroupingPartial", SchedulerDataHelper.DataObject);
        }
    }
}
