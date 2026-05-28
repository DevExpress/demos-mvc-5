using DevExpress.Web.Mvc;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DataController : DemoController {
        public ActionResult Validation(ValidationDemoOptions options) {
            ViewBag.ValidationDemoOptions = options;
            return DemoView("Validation");
        }        
        public ActionResult ValidationPartial(ValidationDemoOptions options) {
            ViewBag.ValidationDemoOptions = options;
            return PartialView("ValidationPartial");
        }
         public ActionResult ProjectDataUpdate(
            MVCxGanttTaskUpdateValues<Task, string> taskUpdateValues,
            MVCxGanttDependencyUpdateValues<Dependency, string> dependencyUpdateValues, ValidationDemoOptions options) {
            ProcessProjectTaskValues(taskUpdateValues);
            ProcessProjectDependencyValues(dependencyUpdateValues);
            ViewBag.ValidationDemoOptions = options;
            return PartialView("ValidationPartial");
        }

        void ProcessProjectTaskValues(MVCxGanttTaskUpdateValues<Task, string> taskUpdateValues) {
            foreach(var item in taskUpdateValues.Update)
                ConstructionProjectDataProvider.UpdateTask(item);
            foreach(var itemKey in taskUpdateValues.DeleteKeys)
                ConstructionProjectDataProvider.DeleteTaskByKey(itemKey);
            foreach(var item in taskUpdateValues.Insert) {
                taskUpdateValues.MapInsertedItemKey(item, ConstructionProjectDataProvider.InsertTask(item));
            }
        }

        void ProcessProjectDependencyValues(MVCxGanttDependencyUpdateValues<Dependency, string> dependencyUpdateValues) {
            foreach(var itemKey in dependencyUpdateValues.DeleteKeys)
                ConstructionProjectDataProvider.DeleteDependencyByKey(itemKey);
            foreach(var item in dependencyUpdateValues.Insert) {
                dependencyUpdateValues.MapInsertedItemKey(item, ConstructionProjectDataProvider.InsertDependency(item));
            }
        }
    }
}
