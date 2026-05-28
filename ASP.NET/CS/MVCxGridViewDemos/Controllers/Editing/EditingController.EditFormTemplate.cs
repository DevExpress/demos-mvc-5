using System;
using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingController : DemoController {
        public ActionResult EditFormTemplate() {
            return DemoView("EditFormTemplate", NorthwindDataProvider.GetEditableProducts());
        }
        [ValidateInput(false)]
        public ActionResult EditFormTemplatePartial() {
            return PartialView("EditFormTemplatePartial", NorthwindDataProvider.GetEditableProducts());
        }

        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult EditFormTemplateAddNewPartial([Bind] EditableProduct product) {
            if (ModelState.IsValid)
                SafeExecute(() => NorthwindDataProvider.InsertProduct(product));
            else {
                ViewData["EditError"] = "Please, correct all errors.";
                ViewData["EditableProduct"] = product;
            }
            return EditFormTemplatePartial();
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult EditFormTemplateUpdatePartial([Bind] EditableProduct product) {
            if(ModelState.IsValid)
                SafeExecute(() => NorthwindDataProvider.UpdateProduct(product));
            else {
                ViewData["EditError"] = "Please, correct all errors.";
                ViewData["EditableProduct"] = product;
            }
            return EditFormTemplatePartial();
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult EditFormTemplateDeletePartial(int productID) {
            if (productID > 0)
                SafeExecute(() => NorthwindDataProvider.DeleteProduct(productID));
            return EditFormTemplatePartial();
        }
    }
}
