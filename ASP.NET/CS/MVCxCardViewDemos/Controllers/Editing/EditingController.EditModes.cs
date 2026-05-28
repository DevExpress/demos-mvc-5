using System;
using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingController : DemoController {
        public ActionResult EditModes() {
            return DemoView("EditModes", NorthwindDataProvider.GetEditableEmployees());
        }
        [ValidateInput(false)]
        public ActionResult EditModesPartial() {
            return PartialView("EditModesPartial", NorthwindDataProvider.GetEditableEmployees());
        }
        [ValidateInput(false)]
        public ActionResult ChangeEditModePartial(CardViewEditingMode editMode) {
            EditingDemosHelper.EditMode = editMode;
            return PartialView("EditModesPartial", NorthwindDataProvider.GetEditableEmployees());
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult EditModesUpdatePartial([Bind] EditableEmployee employee) {
            if(ModelState.IsValid) {
                try {
                    NorthwindDataProvider.UpdateEditableEmployee(employee);
                }
                catch(Exception e) {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";

            return PartialView("EditModesPartial", NorthwindDataProvider.GetEditableEmployees());
        }
        public ActionResult BinaryImageColumnPhotoUpdate() {
            return BinaryImageEditExtension.GetCallbackResult();
        }
    }
}
