using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class MailMergingController : DemoController {
        public ActionResult CustomDataMerge() {
            return DemoView("CustomDataMerge");
        }
        public ActionResult CustomDataMergePartial() {
            return PartialView("CustomDataMergePartial");
        }
    }
}
