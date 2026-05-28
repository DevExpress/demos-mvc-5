using System;
using System.Threading;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DataViewController : DemoController {
        public ActionResult AdaptiveLayout() {
            return DemoView("AdaptiveLayout");
        }
        public ActionResult AdaptiveLayoutPage() {
            return View("AdaptiveLayoutPage");
        }
        public ActionResult AdaptiveLayoutPagePartial() {
            return PartialView("AdaptiveLayoutPagePartial");
        }
    }
}
