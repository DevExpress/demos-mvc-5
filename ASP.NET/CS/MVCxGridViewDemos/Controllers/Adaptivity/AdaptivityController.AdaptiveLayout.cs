using System.Web.Mvc;
using System;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AdaptivityController : DemoController {
        public ActionResult AdaptiveLayout() {
            return DemoView("AdaptiveLayout");
        }
        public ActionResult AdaptiveLayoutPage() {
            return View("AdaptiveLayoutPage", NorthwindDataProvider.GetProducts());
        }
        public ActionResult AdaptiveLayoutPagePartial() {
            return PartialView("AdaptiveLayoutPagePartial", NorthwindDataProvider.GetEditableProducts());
        }

        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult AdaptiveLayoutAddNewPartial([Bind] EditableProduct product) {
            if (ModelState.IsValid)
                SafeExecute(() => NorthwindDataProvider.InsertProduct(product));
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return AdaptiveLayoutPagePartial();
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult AdaptiveLayoutUpdatePartial([Bind] EditableProduct product) {
            if(ModelState.IsValid)
                SafeExecute(() => NorthwindDataProvider.UpdateProduct(product));
            else
                ViewData["EditError"] = "Please, correct all errors.";

            return AdaptiveLayoutPagePartial();
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult AdaptiveLayoutDeletePartial(int productID) {
            if(productID >= 0)
                SafeExecute(() => NorthwindDataProvider.DeleteProduct(productID));
            return AdaptiveLayoutPagePartial();
        }
    }
}
