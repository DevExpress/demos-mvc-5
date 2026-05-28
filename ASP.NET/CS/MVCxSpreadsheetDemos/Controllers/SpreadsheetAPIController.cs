using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SpreadsheetAPIController : DemoController {
        public override string Name { get { return "SpreadsheetAPI"; } }

        public ActionResult Index() {
            return RedirectToAction("CellValue");
        }
    }
}
