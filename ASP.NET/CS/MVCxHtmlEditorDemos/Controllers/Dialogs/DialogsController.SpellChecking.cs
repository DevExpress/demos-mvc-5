using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DialogsController: DemoController {
        public ActionResult SpellChecking() {
            return DemoView("SpellChecking");
        }
        public ActionResult SpellCheckingPartial() {
            return PartialView("SpellCheckingPartial");
        }
    }
}
