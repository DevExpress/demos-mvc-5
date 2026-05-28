using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AdaptivityController : DemoController {
        public ActionResult AdaptiveLayoutWithFormLayout() {
            return DemoView("AdaptiveLayoutWithFormLayout");
        }
        public ActionResult AdaptiveLayoutWithFormLayoutPage() {
            return View("AdaptiveLayoutWithFormLayoutPage", NorthwindDataProvider.GetEditableProducts());
        }
        public ActionResult AdaptiveLayoutWithFormLayoutPagePartial() {
            return PartialView("AdaptiveLayoutWithFormLayoutPagePartial", NorthwindDataProvider.GetEditableProducts());
        }

        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult AdaptiveLayoutWithFormLayoutPageAddNewPartial([Bind] EditableProduct product) {
            if(ModelState.IsValid)
                SafeExecute(() => NorthwindDataProvider.InsertProduct(product));
            else {
                ViewData["EditError"] = "Please, correct all errors.";
                ViewData["EditableProduct"] = product;
            }
            return AdaptiveLayoutWithFormLayoutPagePartial();
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult AdaptiveLayoutWithFormLayoutPageUpdatePartial([Bind] EditableProduct product) {
            if(ModelState.IsValid)
                SafeExecute(() => NorthwindDataProvider.UpdateProduct(product));
            else {
                ViewData["EditError"] = "Please, correct all errors.";
                ViewData["EditableProduct"] = product;
            }
            return AdaptiveLayoutWithFormLayoutPagePartial();
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult AdaptiveLayoutWithFormLayoutPageDeletePartial(int productID) {
            if(productID > 0)
                SafeExecute(() => NorthwindDataProvider.DeleteProduct(productID));
            return AdaptiveLayoutWithFormLayoutPagePartial();
        }

    }
}
