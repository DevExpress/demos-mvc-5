using DevExpress.Web.ASPxGantt;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class TimeHighlightingController : DemoController {
        public ActionResult WorkTimeSchedule() {
            ViewBag.ViewType = GanttViewType.Hours;
            return DemoView("WorkTimeSchedule");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult WorkTimeSchedule(GanttViewType viewType) {
            ViewBag.ViewType = viewType;
            return DemoView("WorkTimeSchedule");
        }
        public ActionResult WorkTimeSchedulePartial() {
            return PartialView("WorkTimeSchedulePartial");
        }
    }
}
