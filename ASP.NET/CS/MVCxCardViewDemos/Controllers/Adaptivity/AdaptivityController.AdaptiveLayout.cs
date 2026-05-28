using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AdaptivityController: DemoController {
        public ActionResult AdaptiveLayout() {
            return DemoView("AdaptiveLayout");
        }
        public ActionResult AdaptiveLayoutPage() {
            return View("AdaptiveLayoutPage", HomesDataProvider.Homes);
        }
        public ActionResult AdaptiveLayoutPagePartial() {
            return PartialView("AdaptiveLayoutPagePartial", HomesDataProvider.Homes);
        }
    }
}
