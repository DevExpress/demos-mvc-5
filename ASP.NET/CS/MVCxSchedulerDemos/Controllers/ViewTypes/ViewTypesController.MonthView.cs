using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ViewTypesController : DemoController {
        public ActionResult MonthView() {
            return DemoView("MonthView", MonthDemoOptions);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MonthView([Bind]SchedulerMonthViewDemoOptions options) {
            MonthDemoOptions = options;
            return DemoView("MonthView", options);
        }
        public ActionResult MonthViewPartial() {
            return PartialView("MonthViewPartial", MonthDemoOptions);
        }

        public const string MonthViewSessionName = "MonthViewDemoOptions";
        public SchedulerMonthViewDemoOptions MonthDemoOptions {
            get {
                SchedulerMonthViewDemoOptions demoOptions = Session[MonthViewSessionName] as SchedulerMonthViewDemoOptions;
                return demoOptions != null ? demoOptions : new SchedulerMonthViewDemoOptions();
            }
            set { Session[MonthViewSessionName] = value; }
        }
    }
}
