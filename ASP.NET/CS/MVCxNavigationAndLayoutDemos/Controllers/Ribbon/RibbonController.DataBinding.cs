using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RibbonController: DemoController {
        public ActionResult DataBinding() {
            return DemoView("DataBinding");
        }
    }
}
