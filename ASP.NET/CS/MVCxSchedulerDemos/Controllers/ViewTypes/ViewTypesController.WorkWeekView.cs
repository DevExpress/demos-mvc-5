using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ViewTypesController : DemoController {
        public ActionResult WorkWeekView() {
            return DemoView("WorkWeekView", WorkWeekDemoOptions);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult WorkWeekView([Bind]SchedulerWorkWeekViewDemoOptions options) {
            WorkWeekDemoOptions = options;
            return DemoView("WorkWeekView", options);
        }
        public ActionResult WorkWeekViewPartial() {
            return PartialView("WorkWeekViewPartial", WorkWeekDemoOptions);
        }

        public const string WorkWeekViewSessionName = "WorkWeekViewDemoOptions";
        public SchedulerWorkWeekViewDemoOptions WorkWeekDemoOptions {
            get {
                SchedulerWorkWeekViewDemoOptions demoOptions = Session[WorkWeekViewSessionName] as SchedulerWorkWeekViewDemoOptions;
                return demoOptions != null ? demoOptions : new SchedulerWorkWeekViewDemoOptions();
            }
            set { Session[WorkWeekViewSessionName] = value; }
        }
    }
}
