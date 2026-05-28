using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class AdvancedViewTypesController : DemoController {
        [HttpGet]
        public ActionResult SideBySideGanttView() {
            object model = ProjectsProvider.GetProjectsTasks();
            return DemoView("SideBySideGanttView", model);
        }
    }
}

