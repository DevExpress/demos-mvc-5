using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FormLayoutController: DemoController {
        public ActionResult TabbedGroups() {
            return DemoView("TabbedGroups", new FormLayoutContactInfo());
        }
    }
}
