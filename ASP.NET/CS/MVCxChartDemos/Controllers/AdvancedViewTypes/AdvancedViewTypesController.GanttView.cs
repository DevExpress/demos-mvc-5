using System;
using System.Web.Mvc;
using DevExpress.Web.Demos.Charts;

namespace DevExpress.Web.Demos.Charts {
    public partial class AdvancedViewTypesController : DemoController {
        [HttpGet]
        public ActionResult OverlappedGanttView() {
            Session[ChartDemoHelper.CompletedDateKey] = ProjectsProvider.DefaultCompletedDate;
            return DemoView("OverlappedGanttView", ProjectsProvider.GetProjectTasks(ProjectsProvider.DefaultCompletedDate));
        }
        public ActionResult GanttViewsPartial() {
            string datetime = Request.Params["CompletedDate"];
            DateTime completedDate = datetime != "" ? DateTime.Parse(Request.Params["CompletedDate"], System.Globalization.CultureInfo.InvariantCulture) : ProjectsProvider.DefaultCompletedDate;
            Session[ChartDemoHelper.CompletedDateKey] = completedDate;
            return PartialView("GanttViewsPartial", ProjectsProvider.GetProjectTasks(completedDate));
        }
    }
}

