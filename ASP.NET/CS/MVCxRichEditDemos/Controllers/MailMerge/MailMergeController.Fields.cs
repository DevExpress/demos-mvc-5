using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class MailMergeController : DemoController {
        public ActionResult Fields() {
            return DemoView("Fields");
        }
        public ActionResult FieldsPartial() {
            return PartialView("FieldsPartial");
        }
    }
}
