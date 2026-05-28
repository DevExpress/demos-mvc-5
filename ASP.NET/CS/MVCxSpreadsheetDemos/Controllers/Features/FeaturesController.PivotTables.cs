using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController : DemoController {
        public ActionResult PivotTables() {
            return DemoView("PivotTables");
        }
        public ActionResult PivotTablesPartial() {
            return PartialView("PivotTablesPartial");
        }
    }
}
