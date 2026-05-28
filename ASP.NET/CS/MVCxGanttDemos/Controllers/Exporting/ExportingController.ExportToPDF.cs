using DevExpress.Web.Mvc;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ExportingController : DemoController {
        public ActionResult ExportToPDF() {
            return DemoView("ExportToPDF");
        }
        public ActionResult ExportToPDFPartial() {
            return PartialView("ExportToPDFPartial");
        }
        public ActionResult GanttBatchUpdate(
            MVCxGanttTaskUpdateValues<Task, string> taskUpdateValues,
            MVCxGanttDependencyUpdateValues<Dependency, string> dependencyUpdateValues,
            MVCxGanttResourceUpdateValues<Resource, string> resourceUpdateValues,
            MVCxGanttResourceAssignmentUpdateValues<ResourceAssignment, string> resourceAssignmentUpdateValues) {
            GanttBatchUpdateHelper.Update(taskUpdateValues, dependencyUpdateValues, resourceUpdateValues, resourceAssignmentUpdateValues);
            return PartialView("ExportToPDFPartial");
        }
    }
}
