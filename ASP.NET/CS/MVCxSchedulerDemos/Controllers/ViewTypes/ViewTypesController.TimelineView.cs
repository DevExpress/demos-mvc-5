using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ViewTypesController : DemoController {
        public ActionResult TimelineView() {
            return DemoView("TimelineView", TimelineDemoOptions);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TimelineView([Bind]SchedulerTimelineViewDemoOptions options) {
            TimelineDemoOptions = options;
            return DemoView("TimelineView", options);
        }
        public ActionResult TimelineViewPartial() {
            return PartialView("TimelineViewPartial", TimelineDemoOptions);
        }

        public const string TimelineViewSessionName = "TimelineViewDemoOptions";
        public SchedulerTimelineViewDemoOptions TimelineDemoOptions {
            get {
                SchedulerTimelineViewDemoOptions demoOptions = Session[TimelineViewSessionName] as SchedulerTimelineViewDemoOptions;
                return demoOptions != null ? demoOptions : new SchedulerTimelineViewDemoOptions();
            }
            set { Session[TimelineViewSessionName] = value; }
        }
    }
}
