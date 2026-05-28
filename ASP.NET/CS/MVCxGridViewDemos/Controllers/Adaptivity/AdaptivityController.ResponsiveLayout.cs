using System.Web.Mvc;
using System;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AdaptivityController : DemoController {
        public ActionResult ResponsiveLayout() {
            return DemoView("ResponsiveLayout");
        }
        public ActionResult ResponsiveLayoutPage() {
            return View("ResponsiveLayoutPage", NorthwindDataProvider.GetProducts());
        }
        public ActionResult ResponsiveLayoutPagePartial() {
            return PartialView("ResponsiveLayoutPagePartial", NorthwindDataProvider.GetEditableProducts());
        }

        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult ResponsiveLayoutAddNewPartial([Bind] EditableProduct product) {
            if (ModelState.IsValid)
                SafeExecute(() => NorthwindDataProvider.InsertProduct(product));
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return ResponsiveLayoutPagePartial();
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult ResponsiveLayoutUpdatePartial([Bind] EditableProduct product) {
            if(ModelState.IsValid)
                SafeExecute(() => NorthwindDataProvider.UpdateProduct(product));
            else
                ViewData["EditError"] = "Please, correct all errors.";

            return ResponsiveLayoutPagePartial();
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult ResponsiveLayoutDeletePartial(int productID) {
            if(productID >= 0)
                SafeExecute(() => NorthwindDataProvider.DeleteProduct(productID));
            return ResponsiveLayoutPagePartial();
        }
    }
}
