using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class MailMergingController : DemoController {
        public override string Name { get { return "MailMerging"; } }

        public ActionResult Index() {
            return RedirectToAction("MailMerge");
        }
    }
}
