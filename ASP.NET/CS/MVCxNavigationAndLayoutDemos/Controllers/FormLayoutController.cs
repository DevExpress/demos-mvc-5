using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    [ValidateInput(false)]
    public partial class FormLayoutController : DemoController {
        public override string Name { get { return "FormLayout"; } }

        public ActionResult Index() {
            return RedirectToAction("Features");
        }
    }
}
