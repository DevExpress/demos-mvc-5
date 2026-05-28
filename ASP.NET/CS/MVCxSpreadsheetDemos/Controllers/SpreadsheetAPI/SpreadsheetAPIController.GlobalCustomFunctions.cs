using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SpreadsheetAPIController: DemoController {
        public ActionResult GlobalCustomFunctions() {
            return DemoView("GlobalCustomFunctions");
        }
        public ActionResult GlobalCustomFunctionsPartial() {
            return PartialView("GlobalCustomFunctionsPartial");
        }
    }
}
