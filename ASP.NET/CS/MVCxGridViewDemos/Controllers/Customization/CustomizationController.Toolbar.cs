using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class CustomizationController : DemoController {
        public ActionResult Toolbar() {
            return DemoView("Toolbar", NorthwindDataProvider.GetEditableProducts());
        }
        public ActionResult ToolbarPartial() {
            return PartialView("ToolbarPartial", NorthwindDataProvider.GetEditableProducts());
        }

        [ValidateInput(false)]
        public ActionResult ToolbarAddNewPartial(EditableProduct product) {
            if(ModelState.IsValid) 
                SafeExecute(() => NorthwindDataProvider.InsertProduct(product));            
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return ToolbarPartial();
        }
        [ValidateInput(false)]
        public ActionResult ToolbarUpdatePartial(EditableProduct product) {
            if(ModelState.IsValid) 
                SafeExecute(() => NorthwindDataProvider.UpdateProduct(product));            
            else
                ViewData["EditError"] = "Please, correct all errors.";

            return ToolbarPartial();
        }
        [ValidateInput(false)]
        public ActionResult ToolbarDeletePartial(int productID = -1) {
            if (productID >= 0)
                SafeExecute(() => NorthwindDataProvider.DeleteProduct(productID));
            return ToolbarPartial();
        }

        public ActionResult ExportTo(string customExportCommand) {
            switch(customExportCommand) {
                case "CustomExportToXLS":
                case "CustomExportToXLSX":
                    return GridViewExportDemoHelper.ExportFormatsInfo[customExportCommand](
                        GridViewToolbarHelper.ExportGridSettings, NorthwindDataProvider.GetEditableProducts());
                default:
                    return RedirectToAction("Toolbar");
            }
        }
    }
}
