using System;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AdaptivityController : DemoController {
        public override string Name { get { return "Adaptivity"; } }

        public ActionResult Index() {
            return RedirectToAction("ResponsiveLayout");
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
