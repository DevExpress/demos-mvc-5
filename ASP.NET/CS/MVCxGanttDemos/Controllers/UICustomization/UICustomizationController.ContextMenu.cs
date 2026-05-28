using DevExpress.Web.Mvc;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class UICustomizationController : DemoController {
        public ActionResult ContextMenu() {
            return DemoView("ContextMenu");
        }        
        public ActionResult ContextMenuPartial() {
            return PartialView("ContextMenuPartial");
        }
        public ActionResult GanttBatchUpdate(
            MVCxGanttTaskUpdateValues<Task, string> taskUpdateValues,
            MVCxGanttDependencyUpdateValues<Dependency, string> dependencyUpdateValues,
            MVCxGanttResourceUpdateValues<Resource, string> resourceUpdateValues,
            MVCxGanttResourceAssignmentUpdateValues<ResourceAssignment, string> resourceAssignmentUpdateValues) {
            GanttBatchUpdateHelper.Update(taskUpdateValues, dependencyUpdateValues, resourceUpdateValues, resourceAssignmentUpdateValues);
            return PartialView("ContextMenuPartial");
        }
    }
}
