using System;
using System.Web.Mvc;
using System.Collections.Generic;

namespace DevExpress.Web.Demos {
    public partial class MailMergingController : DemoController {
        public ActionResult MailMerge() {
            return DemoView("MailMerge", (object)MailMergeDemoHelper.GetMailMergeModes()[0].Value);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MailMerge(string mailMergeMode) {
            return DemoView("MailMerge", (object)mailMergeMode);
        }
        public ActionResult MailMergePartial(string mailMergeMode) {
            return PartialView("MailMergePartial", mailMergeMode);
        }
    }
}
