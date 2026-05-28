using System;
using System.Linq;
using System.Collections.Generic;
using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingController : DemoController {
        public ActionResult CascadingComboBoxesBatch() {
            return DemoView("CascadingComboBoxesBatch", WorldCitiesDataProvider.GetEditableCustomers());
        }
        [ValidateInput(false)]
        public ActionResult CascadingComboBoxesBatchPartial() {
            return PartialView("CascadingComboBoxesBatchPartial", WorldCitiesDataProvider.GetEditableCustomers());
        }

        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult CascadingComboBoxesBatchEditingUpdateModel([Bind] MVCxGridViewBatchUpdateValues<EditableWorldCustomer, int> updateValues) {
            foreach(var customer in updateValues.Insert) {
                if(updateValues.IsValid(customer))
                    InsertCustomer(customer, updateValues);
            }
            foreach(var customer in updateValues.Update) {
                if(updateValues.IsValid(customer))
                    UpdateCustomer(customer, updateValues);
            }
            return CascadingComboBoxesBatchPartial();
        }

        protected void InsertCustomer([Bind] EditableWorldCustomer customer, MVCxGridViewBatchUpdateValues<EditableWorldCustomer, int> updateValues) {
            try {
                WorldCitiesDataProvider.InsertCustomer(customer);
            }
            catch(Exception e) {
                updateValues.SetErrorText(customer, e.Message);
            }
        }
        protected void UpdateCustomer([Bind] EditableWorldCustomer customer, MVCxGridViewBatchUpdateValues<EditableWorldCustomer, int> updateValues) {
            try {
                WorldCitiesDataProvider.UpdateCustomer(customer);
            }
            catch(Exception e) {
                updateValues.SetErrorText(customer, e.Message);
            }
        }

        public ActionResult GetCitiesBatchEdit(string countryID) {
            return GridViewExtension.GetComboBoxCallbackResult(p => {
                p.ValueField = "CityId";
                p.TextField = "CityName";
                p.ValueType = typeof(int);
                int currentCountry = String.IsNullOrEmpty(countryID) ? -1 : System.Convert.ToInt32(countryID);
                p.BindList(WorldCitiesDataProvider.GetCities(currentCountry));
            });
        }
    }
}
