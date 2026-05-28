using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class APIController : DemoController {
        public override string Name { get { return "API"; } }

        public ActionResult Index() {
            return RedirectToAction("ClientSideEvents");
        }
    }
}
