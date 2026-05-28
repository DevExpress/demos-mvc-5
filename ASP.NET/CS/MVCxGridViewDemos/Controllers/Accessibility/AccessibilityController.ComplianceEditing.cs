using System;
using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AccessibilityController : DemoController {
        public ActionResult ComplianceEditing(GridViewEditingMode editMode = GridViewEditingMode.Batch) {
            ViewBag.EditMode = editMode;
            return DemoView("ComplianceEditing", NorthwindDataProvider.GetEditableProducts());
        }
        public ActionResult ComplianceEditingPartial(GridViewEditingMode editMode = GridViewEditingMode.Batch) {
            ViewBag.EditMode = editMode;
            return PartialView("ComplianceEditingPartial", NorthwindDataProvider.GetEditableProducts());
        }

        [ValidateInput(false)]
        public ActionResult ComplianceEditingUpdateModel(EditableProduct product, GridViewEditingMode editMode) {
            if (ModelState.IsValid)
                SafeExecute(() => NorthwindDataProvider.UpdateProduct(product));
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return ComplianceEditingPartial(editMode);
        }
        [ValidateInput(false)]
        public ActionResult ComplianceBatchEditingUpdateModel(MVCxGridViewBatchUpdateValues<EditableProduct, int> updateValues, GridViewEditingMode editMode) {
            foreach(var product in updateValues.Update) {
                if(updateValues.IsValid(product)) {
                    try {
                        NorthwindDataProvider.UpdateProduct(product);
                    } catch(Exception e) {
                        updateValues.SetErrorText(product, e.Message);
                    }
                }
            }
            return ComplianceEditingPartial(editMode);
        }
    }
}
