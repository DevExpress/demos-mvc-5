using System.Web.Mvc;
using System;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FloatingActionButtonController : DemoController {
        public ActionResult FloatingActionButtonForGridView() {
            return DemoView("FloatingActionButtonForGridView");
        }
        public ActionResult FloatingActionButtonForGridViewPage() {
            return View("FloatingActionButtonForGridViewPage", NorthwindDataProvider.GetProducts());
        }
        public ActionResult FloatingActionButtonForGridViewPagePartial() {
            return PartialView("FloatingActionButtonForGridViewPagePartial", NorthwindDataProvider.GetEditableProducts());
        }

        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult FloatingActionButtonForGridViewAddNewPartial([Bind] EditableProduct product) {
            if (ModelState.IsValid)
                SafeExecute(() => NorthwindDataProvider.InsertProduct(product));
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return FloatingActionButtonForGridViewPagePartial();
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult FloatingActionButtonForGridViewUpdatePartial([Bind] EditableProduct product) {
            if (ModelState.IsValid)
                SafeExecute(() => NorthwindDataProvider.UpdateProduct(product));
            else
                ViewData["EditError"] = "Please, correct all errors.";

            return FloatingActionButtonForGridViewPagePartial();
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult FloatingActionButtonForGridViewDeletePartial(int productID) {
            if (productID >= 0)
                SafeExecute(() => NorthwindDataProvider.DeleteProduct(productID));
            return FloatingActionButtonForGridViewPagePartial();
        }
    }
}
