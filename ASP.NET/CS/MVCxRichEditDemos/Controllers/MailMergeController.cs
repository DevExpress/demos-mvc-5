using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class MailMergeController : DemoController {
        public override string Name { get { return "MailMerge"; } }

        public ActionResult Index() {
            return RedirectToAction("Fields");
        }
    }
}
