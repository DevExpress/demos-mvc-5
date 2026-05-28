using DevExpress.Web.Mvc;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DataController : DemoController {
        public ActionResult DataBinding() {
            return DemoView("DataBinding");
        }        
        public ActionResult DataBindingPartial() {
            return PartialView("DataBindingPartial");
        }
        public ActionResult GanttBatchUpdate(
            MVCxGanttTaskUpdateValues<Task, string> taskUpdateValues,
            MVCxGanttDependencyUpdateValues<Dependency, string> dependencyUpdateValues,
            MVCxGanttResourceUpdateValues<Resource, string> resourceUpdateValues,
            MVCxGanttResourceAssignmentUpdateValues<ResourceAssignment, string> resourceAssignmentUpdateValues) {
            GanttBatchUpdateHelper.Update(taskUpdateValues, dependencyUpdateValues, resourceUpdateValues, resourceAssignmentUpdateValues);
            return PartialView("DataBindingPartial");
        }
    }
}
