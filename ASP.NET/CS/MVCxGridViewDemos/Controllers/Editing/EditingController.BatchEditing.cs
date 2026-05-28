using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingController : DemoController {
        public ActionResult BatchEditing([Bind] BatchEditingDemoOptions options) {
            return DemoView("BatchEditing", options);
        }
        [ValidateInput(false)]
        public ActionResult BatchEditingPartial([Bind] BatchEditingDemoOptions options) {
            ViewBag.BatchEditingOptions = options;
            return PartialView("BatchEditingPartial", NorthwindDataProvider.GetEditableProducts());
        }

        [ValidateInput(false)]
        public ActionResult BatchEditingUpdateModel(MVCxGridViewBatchUpdateValues<EditableProduct, int> updateValues, BatchEditingDemoOptions options) {
            foreach(var product in updateValues.Insert) {
                if(updateValues.IsValid(product))
                    InsertProduct(product, updateValues);
            }
            foreach(var product in updateValues.Update) {
                if(updateValues.IsValid(product))
                    UpdateProduct(product, updateValues);
            }
            foreach(var productID in updateValues.DeleteKeys) {
                DeleteProduct(productID, updateValues);
            }
            return BatchEditingPartial(options);
        }
        protected void InsertProduct(EditableProduct product, MVCxGridViewBatchUpdateValues<EditableProduct, int> updateValues) {
            try {
                NorthwindDataProvider.InsertProduct(product);
            }
            catch(Exception e) {
                updateValues.SetErrorText(product, e.Message);
            }
        }
        protected void UpdateProduct(EditableProduct product, MVCxGridViewBatchUpdateValues<EditableProduct, int> updateValues) {
            try {
                NorthwindDataProvider.UpdateProduct(product);
            }
            catch(Exception e) {
                updateValues.SetErrorText(product, e.Message);
            }
        }
        protected void DeleteProduct(int productID, MVCxGridViewBatchUpdateValues<EditableProduct, int> updateValues) {
            try {
                NorthwindDataProvider.DeleteProduct(productID);
            }
            catch(Exception e) {
                updateValues.SetErrorText(productID, e.Message);
            }
        }
    }
}
