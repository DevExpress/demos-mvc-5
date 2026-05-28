using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SampleDocumentsController : DemoController {
        public override string Name { get { return "SampleDocuments"; } }

        public ActionResult Index() {
            return RedirectToAction("ProfitAndLoss");
        }
    }
}
