using System.Web.Mvc;
using System.Collections;

namespace DevExpress.Web.Demos {
    public partial class StandaloneControlsController: DemoController {
        public override string Name { get { return "StandaloneControls"; } }

        public ActionResult Index() {
            return RedirectToAction("StorageControl");
        }
    }
}
