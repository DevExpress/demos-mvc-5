using System.Web.Mvc;
using DevExpress.Web.Mvc;
using System;

namespace DevExpress.Web.Demos {
    public partial class CommonController: DemoController {
        public ActionResult UnobtrusiveValidation() {
            return DemoView("UnobtrusiveValidation", new UnobtrusiveValidationData());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UnobtrusiveValidation([Bind] UnobtrusiveValidationData validationData) {
            if (Request.Params["btnUpdate"] == null) { // Theme changing
                ModelState.Clear();
                return DemoView("UnobtrusiveValidation", validationData);
            }

            if (ModelState.IsValid) {
                object redirectActionName = "UnobtrusiveValidation";
                return DemoView("UnobtrusiveValidation", "ValidationSuccess", redirectActionName);
            }
            return DemoView("UnobtrusiveValidation", validationData);
        }
        public JsonResult CheckUserName(string Name) {
            bool isValid = !string.Equals(Name, "admin", StringComparison.OrdinalIgnoreCase);
            return Json(isValid, JsonRequestBehavior.AllowGet);
        }
    }
}
