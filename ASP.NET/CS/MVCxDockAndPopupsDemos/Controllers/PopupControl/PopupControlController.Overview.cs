using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PopupControlController: DemoController {     
        public ActionResult Overview() {
            return DemoView("Overview");
        }
    }
}
