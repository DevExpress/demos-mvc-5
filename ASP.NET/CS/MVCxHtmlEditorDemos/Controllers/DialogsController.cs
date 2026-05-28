using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DialogsController: DemoController {
        public override string Name { get { return "Dialogs"; } }

        public ActionResult Index() {
            return RedirectToAction("SpellChecking");
        }
    }
}
