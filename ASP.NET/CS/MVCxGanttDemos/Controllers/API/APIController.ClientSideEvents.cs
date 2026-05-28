using DevExpress.Web.Mvc;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class APIController : DemoController {
        public ActionResult ClientSideEvents() {            
            ViewData["ShowEventListPanel"] = true;
            ViewData["ClientSideEvents"] = new string[] {
                "StartCellEditing", 
                "EndCellEditing", 
                "TaskInserting", 
                "TaskInserted", 
                "TaskDeleting", 
                "TaskDeleted", 
                "TaskMoving", 
                "TaskFocusing",
                "FocusedTaskChanged", 
                "TaskEditDialogShowing", 
                "TaskUpdating", 
                "TaskUpdated", 
                "TaskClick", 
                "TaskDblClick", 
                "ContextMenu", 
                "DependencyInserting", 
                "DependencyInserted", 
                "DependencyDeleting", 
                "DependencyDeleted", 
                "ResourceInserting", 
                "ResourceInserted", 
                "ResourceDeleting", 
                "ResourceDeleted", 
                "ResourceAssigning", 
                "ResourceAssigned", 
                "ResourceUnassigning",
                "ResourceUnassigned"
            };
            ViewData["ShowEventListPanel"] = false;
            return DemoView("ClientSideEvents");
        }        
        public ActionResult ClientSideEventsPartial() {
            return PartialView("ClientSideEventsPartial");
        }
        public ActionResult GanttBatchUpdate(
            MVCxGanttTaskUpdateValues<Task, string> taskUpdateValues,
            MVCxGanttDependencyUpdateValues<Dependency, string> dependencyUpdateValues,
            MVCxGanttResourceUpdateValues<Resource, string> resourceUpdateValues,
            MVCxGanttResourceAssignmentUpdateValues<ResourceAssignment, string> resourceAssignmentUpdateValues) {
            GanttBatchUpdateHelper.Update(taskUpdateValues, dependencyUpdateValues, resourceUpdateValues, resourceAssignmentUpdateValues);
            return PartialView("ClientSideEventsPartial");
        }
    }
}
