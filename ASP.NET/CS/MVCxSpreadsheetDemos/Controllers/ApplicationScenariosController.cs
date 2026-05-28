using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ApplicationScenariosController : DemoController {
        public override string Name { get { return "ApplicationScenarios"; } }

        public ActionResult Index() {
            return RedirectToAction("DynamicSheetGeneration");
        }
    }
}
