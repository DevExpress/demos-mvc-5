using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class TemplatesController: DemoController {
        public override string Name { get { return "Templates"; } }

        public ActionResult Index() {
            return RedirectToAction("Templates");
        }
    }
}
