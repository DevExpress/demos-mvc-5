using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingController: DemoController {
        public ActionResult BinaryImageColumn() {
            return DemoView("BinaryImageColumn", NorthwindDataProvider.GetEditableEmployees());
        }

        public ActionResult BinaryImageColumnPartial() {
            return PartialView("BinaryImageColumnpartial", NorthwindDataProvider.GetEditableEmployees());
        }

        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult BinaryImageColumnUpdatePartial([Bind] EditableEmployee employee) {
            if (ModelState.IsValid)
                SafeExecute(() => NorthwindDataProvider.UpdateEditableEmployee(employee));
            else 
                ViewData["EditError"] = "Please, correct all errors.";
            return BinaryImageColumnPartial();
        }

        public ActionResult BinaryImageColumnPhotoUpdate() {
            return BinaryImageEditExtension.GetCallbackResult();
        }
    }
}
