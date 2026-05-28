using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ToolbarItemsController: DemoController {
        public override string Name { get { return "ToolbarItems"; } }

        public ActionResult Index() {
            return RedirectToAction("CustomCss");
        }
    }
}
