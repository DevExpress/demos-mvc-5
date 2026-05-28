using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingController : DemoController {
        public override string Name { get { return "Editing"; } }

        public ActionResult Index() {
            return RedirectToAction("InlineEditing");
        }

        public void SafeExecute(Action method) {
            try {
                method();
            } catch (Exception e) {
                ViewData["EditNodeError"] = e.Message;
            }
        }
    }
}
