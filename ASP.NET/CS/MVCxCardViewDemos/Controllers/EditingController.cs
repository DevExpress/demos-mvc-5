using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingController: DemoController {
        public override string Name { get { return "Editing"; } }

        public ActionResult Index() {
            return RedirectToAction("EditModes");
        }
    }
}
