using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ViewTypesController : DemoController {
        public ActionResult DayView() {
            return DemoView("DayView", DayViewDemoOptions);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DayView([Bind]SchedulerDayViewDemoOptions options) {
            DayViewDemoOptions = options;
            return DemoView("DayView", options);
        }
        public ActionResult DayViewPartial() {
            return PartialView("DayViewPartial", DayViewDemoOptions);
        }

        const string DayViewSessionName = "DayViewDemoOptions";
        public SchedulerDayViewDemoOptions DayViewDemoOptions { 
            get {
                SchedulerDayViewDemoOptions demoOptions = Session[DayViewSessionName] as SchedulerDayViewDemoOptions;
                return demoOptions != null ? demoOptions : new SchedulerDayViewDemoOptions();
            }
            set { Session[DayViewSessionName] = value; }
        }
    }
}
