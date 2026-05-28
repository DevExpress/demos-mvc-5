using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ViewTypesController : DemoController {
        public ActionResult FullWeekView() {
            return DemoView("FullWeekView", FullWeekDemoOptions);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FullWeekView([Bind]SchedulerFullWeekViewDemoOptions options) {
            FullWeekDemoOptions = options;
            return DemoView("FullWeekView", options);
        }
        public ActionResult FullWeekViewPartial() {
            return PartialView("FullWeekViewPartial", FullWeekDemoOptions);
        }

        public const string FullWeekViewSessionName = "FullWeekViewDemoOptions";
        public SchedulerFullWeekViewDemoOptions FullWeekDemoOptions {
            get {
                SchedulerFullWeekViewDemoOptions demoOptions = Session[FullWeekViewSessionName] as SchedulerFullWeekViewDemoOptions;
                return demoOptions != null ? demoOptions : new SchedulerFullWeekViewDemoOptions();
            }
            set { Session[FullWeekViewSessionName] = value; }
        }
    }
}
