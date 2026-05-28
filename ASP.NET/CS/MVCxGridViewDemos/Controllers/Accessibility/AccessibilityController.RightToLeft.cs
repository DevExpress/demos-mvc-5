using System;
using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AccessibilityController : DemoController {
        public ActionResult RightToLeft() {
            return DemoView("RightToLeft", NorthwindDataProvider.GetEditableCustomers());
        }
        public ActionResult RightToLeftPartial() {
            return PartialView("RightToLeftPartial", NorthwindDataProvider.GetEditableCustomers());
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult RightToLeftUpdatePartial([Bind] EditableCustomer customer) {
            if (ModelState.IsValid)
                SafeExecute(() => NorthwindDataProvider.UpdateCustomer(customer));                
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return RightToLeftPartial();
        }
    }
}
