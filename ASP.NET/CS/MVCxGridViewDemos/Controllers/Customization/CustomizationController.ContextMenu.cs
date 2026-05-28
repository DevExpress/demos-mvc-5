using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class CustomizationController : DemoController {
        public ActionResult ContextMenu() {
            return DemoView("ContextMenu", NorthwindDataProvider.GetEditableProducts());
        }
        public ActionResult ContextMenuPartial() {
            return PartialView("ContextMenuPartial", NorthwindDataProvider.GetEditableProducts());
        }

        [ValidateInput(false)]
        public ActionResult AddNewRowContextMenuPartial(EditableProduct product) {
            if (ModelState.IsValid)
                SafeExecute(() => NorthwindDataProvider.InsertProduct(product));
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return ContextMenuPartial();
        }
        [ValidateInput(false)]
        public ActionResult UpdateRowContextMenuPartial(EditableProduct product) {
            if (ModelState.IsValid)
                SafeExecute(() => NorthwindDataProvider.UpdateProduct(product));
            else
                ViewData["EditError"] = "Please, correct all errors.";

            return ContextMenuPartial();
        }
        [ValidateInput(false)]
        public ActionResult DeleteRowContextMenuPartial(int productID) {
            if (productID >= 0)
                SafeExecute(() => NorthwindDataProvider.DeleteProduct(productID));
            return ContextMenuPartial();
        }
    }
}
