using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class MenuController: DemoController {     
        public ActionResult Overview() {
            return DemoView("Overview");
        }
    }
}
