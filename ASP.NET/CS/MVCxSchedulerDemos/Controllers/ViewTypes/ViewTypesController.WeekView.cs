using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ViewTypesController : DemoController {
        public ActionResult WeekView() {
            return DemoView("WeekView", WeekDemoOptions);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult WeekView([Bind]SchedulerWeekViewDemoOptions options) {
            WeekDemoOptions = options;
            return DemoView("WeekView", options);
        }
        public ActionResult WeekViewPartial() {
            return PartialView("WeekViewPartial", WeekDemoOptions);
        }

        public const string WeekViewSessionName = "WeekViewDemoOptions";
        public SchedulerWeekViewDemoOptions WeekDemoOptions {
            get {
                SchedulerWeekViewDemoOptions demoOptions = Session[WeekViewSessionName] as SchedulerWeekViewDemoOptions;
                return demoOptions != null ? demoOptions : new SchedulerWeekViewDemoOptions();
            }
            set { Session[WeekViewSessionName] = value; }
        }
    }
}
