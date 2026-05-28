using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SummaryController : DemoController {
        public ActionResult BatchEditClientSummary() {
            return DemoView("BatchEditClientSummary", NorthwindDataProvider.GetEditableOrderDetailsExtended());
        }
        [ValidateInput(false)]
        public ActionResult BatchEditClientSummaryPartial() {
            return PartialView("BatchEditClientSummaryPartial", NorthwindDataProvider.GetEditableOrderDetailsExtended());
        }

        [ValidateInput(false)]
        public ActionResult BatchEditClientSummaryUpdateModel(MVCxGridViewBatchUpdateValues<EditableOrderDetailExtended, string> updateValues) {
            foreach(var order in updateValues.Update) {
                if(updateValues.IsValid(order))
                    UpdateProduct(order, updateValues);
            }
            foreach(var orderID in updateValues.DeleteKeys) {
                DeleteProduct(orderID, updateValues);
            }
            return BatchEditClientSummaryPartial();
        }

        protected void UpdateProduct(EditableOrderDetailExtended order, MVCxGridViewBatchUpdateValues<EditableOrderDetailExtended, string> updateValues) {
            try {
                NorthwindDataProvider.UpdateOrderDetailExtended(order);
            } catch (Exception e) {
                updateValues.SetErrorText(order, e.Message);
            }
        }
        protected void DeleteProduct(string orderIDproductID, MVCxGridViewBatchUpdateValues<EditableOrderDetailExtended, string> updateValues) {
            try {
                NorthwindDataProvider.DeleteOrderDetailExtended(orderIDproductID);
            } catch (Exception e) {
                updateValues.SetErrorText(orderIDproductID, e.Message);
            }
        }
    }
}
