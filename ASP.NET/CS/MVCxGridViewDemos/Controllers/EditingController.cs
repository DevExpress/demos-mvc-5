using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingController: DemoController {
        public override string Name { get { return "Editing"; } }

        public ActionResult Index() {
            return RedirectToAction("EditModes");
        }

        public ActionResult EditModesAddNewPartial() {
            return RedirectToAction("EditModes");
        }
        public ActionResult EditModesUpdatePartial() {
            return RedirectToAction("EditModes");
        }
        public ActionResult EditModesDeletePartial() {
            return RedirectToAction("EditModes");
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
