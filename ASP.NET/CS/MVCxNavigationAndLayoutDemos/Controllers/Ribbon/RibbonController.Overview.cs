using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RibbonController: DemoController {     
        public ActionResult Overview() {
            return DemoView("Overview");
        }
    }
}
