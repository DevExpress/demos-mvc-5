using System.Web.Mvc;
using System.Collections;

namespace DevExpress.Web.Demos {
    public partial class ViewTypesController: DemoController {
        public override string Name { get { return "ViewTypes"; } }

        public ActionResult Index() {
            return RedirectToAction("DayView");
        }
    }
}
