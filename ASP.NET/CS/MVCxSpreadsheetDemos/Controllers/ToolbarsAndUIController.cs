using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ToolbarsAndUIController : DemoController {
        public override string Name { get { return "ToolbarsAndUI"; } }

        public ActionResult Index() {
            return RedirectToAction("UICustomization");
        }
    }
}
