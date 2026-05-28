using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditorsController : DemoController {
        public ActionResult ComboBoxServerMode() {
            return DemoView("ComboBoxServerMode");
        }
        public ActionResult ComboBoxServerModePartial() {
            return PartialView();
        }
    }
}
