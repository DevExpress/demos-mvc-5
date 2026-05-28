using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FormLayoutController: DemoController {     
        public ActionResult AdaptiveGridLayout() {
            return DemoView("AdaptiveGridLayout", null);
        }
    }
}
