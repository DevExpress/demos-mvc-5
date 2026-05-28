using System;
using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingController : DemoController {
        public ActionResult EditModes() {
            ViewBag.EditMode = GridViewEditingMode.EditFormAndDisplayRow;
            return DemoView("EditModes", NorthwindDataProvider.GetEditableProducts());
        }
        [ValidateInput(false)]
        public ActionResult EditModesPartial([Bind] GridViewEditingMode editMode) {
            ViewBag.EditMode = editMode;
            return PartialView("EditModesPartial", NorthwindDataProvider.GetEditableProducts());
        }

        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult EditModesAddNewPartial([Bind] EditableProduct product, [Bind] GridViewEditingMode editMode) {
            if (ModelState.IsValid)
                SafeExecute(() => NorthwindDataProvider.InsertProduct(product));
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return EditModesPartial(editMode);
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult EditModesUpdatePartial([Bind] EditableProduct product, [Bind] GridViewEditingMode editMode) {
            if(ModelState.IsValid)
                SafeExecute(() => NorthwindDataProvider.UpdateProduct(product));
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return EditModesPartial(editMode);
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult EditModesDeletePartial([Bind] GridViewEditingMode editMode, int productID = -1) {
            if (productID >= 0)
                SafeExecute(() => NorthwindDataProvider.DeleteProduct(productID));
            return EditModesPartial(editMode);
        }
    }
}
