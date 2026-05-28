using System;
using System.Globalization;
using System.Threading;
using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AccessibilityController : DemoController {
        public ActionResult Localization(string Language = "en") {
            GridViewAccessibilityDemoHelper.ApplyCurrentCulture(Language);
            ViewBag.Language = Language;
            return DemoView("Localization", NorthwindDataProvider.GetEditableEmployees());
        }
        public ActionResult LocalizationPartial(string Language = "en") {
            GridViewAccessibilityDemoHelper.ApplyCurrentCulture(Language);
            return PartialView("LocalizationPartial", NorthwindDataProvider.GetEditableEmployees());
        }

        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult LocalizationUpdatePartial([Bind] EditableEmployee employee, string Language) {
            GridViewAccessibilityDemoHelper.ApplyCurrentCulture(Language);
            if (ModelState.IsValid)
                SafeExecute(() => NorthwindDataProvider.UpdateEditableEmployee(employee));
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return LocalizationPartial(Language);
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult LocalizationAddNewPartial([Bind] EditableEmployee employee, string Language) {
            GridViewAccessibilityDemoHelper.ApplyCurrentCulture(Language);
            if (ModelState.IsValid)
                SafeExecute(() => NorthwindDataProvider.InsertEditableEmployee(employee));
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return LocalizationPartial(Language);
        }
    }
}
