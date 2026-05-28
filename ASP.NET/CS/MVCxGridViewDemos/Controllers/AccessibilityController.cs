using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AccessibilityController : DemoController {
        public override string Name { get { return "Accessibility"; } }

        public ActionResult Index() {
            return RedirectToAction("Compliance");
        }

        public void SafeExecute(Action method) {
            try {
                method();
            } catch (Exception e) {
                ViewData["EditError"] = e.Message;
            }
        }
    }
}
