using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;
using DevExpress.Web.Mvc;
using System;

namespace DevExpress.Web.Demos {
    public partial class SelectionController : DemoController {
        public ActionResult MultipleCellSelection() {
            ViewBag.IsRequiredSpreadsheet = true;
            return DemoView("MultipleCellSelection", NorthwindDataProvider.GetEditableProducts());
        }
        public ActionResult MultipleCellSelectionPartial() {
            return PartialView("MultipleCellSelectionPartial", NorthwindDataProvider.GetEditableProducts());
        }

        [ValidateInput(false)]
        public ActionResult MultipleCellSelectionUpdateModel(MVCxGridViewBatchUpdateValues<EditableProduct, int> updateValues) {
            foreach (var product in updateValues.Update) {
                if (updateValues.IsValid(product))
                    UpdateProduct(product, updateValues);
            }
            return MultipleCellSelectionPartial();
        }

        protected void UpdateProduct(EditableProduct product, MVCxGridViewBatchUpdateValues<EditableProduct, int> updateValues) {
            try {
                NorthwindDataProvider.UpdateProduct(product);
            } catch (Exception e) {
                updateValues.SetErrorText(product, e.Message);
            }
        }

    }
}
