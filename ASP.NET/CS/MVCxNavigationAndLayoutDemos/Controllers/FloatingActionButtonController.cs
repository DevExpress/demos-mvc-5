using System;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FloatingActionButtonController: DemoController {
        public override string Name { get { return "FloatingActionButton"; } }

        public ActionResult Index() {
            return RedirectToAction("Features");
        }

        public void SafeExecute(Action method) {
            try {
                method();
            }
            catch (Exception e) {
                ViewData["EditError"] = e.Message;
            }
        }
    }
}
