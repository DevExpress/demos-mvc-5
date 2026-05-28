using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class LayoutController : DemoController {
        public override string Name { get { return "Layout"; } }

        public ActionResult Index() {
            return RedirectToAction("FieldsCustomization");
        }
    }
}
