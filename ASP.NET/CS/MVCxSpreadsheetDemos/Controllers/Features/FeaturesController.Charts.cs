using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController : DemoController {
        public ActionResult Charts() {
            return DemoView("Charts");
        }
        public ActionResult ChartsPartial() {
            return PartialView("ChartsPartial");
        }
    }
}
