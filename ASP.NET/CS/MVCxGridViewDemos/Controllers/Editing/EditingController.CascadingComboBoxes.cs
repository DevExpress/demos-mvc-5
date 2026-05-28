using System;
using System.Linq;
using System.Collections.Generic;
using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingController : DemoController {
        public ActionResult CascadingComboBoxes() {
            return DemoView("CascadingComboBoxes", WorldCitiesDataProvider.GetEditableCustomers());
        }
        [ValidateInput(false)]
        public ActionResult CascadingComboBoxesPartial() {
            return PartialView("CascadingComboBoxesPartial", WorldCitiesDataProvider.GetEditableCustomers());
        }

        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult CascadingComboBoxesAddNewPartial([Bind] EditableWorldCustomer customer) {
            if(ModelState.IsValid && IsValidCustomerName(ModelState, customer))
                SafeExecute(() => WorldCitiesDataProvider.InsertCustomer(customer));
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return CascadingComboBoxesPartial();
        }

        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult CascadingComboBoxesUpdatePartial([Bind] EditableWorldCustomer customer) {
            if(ModelState.IsValid && IsValidCustomerName(ModelState, customer))
                SafeExecute(() => WorldCitiesDataProvider.UpdateCustomer(customer));
            else
                ViewData["EditError"] = "Please, correct all errors.";

            return CascadingComboBoxesPartial();
        }

        private bool IsValidCustomerName(ModelStateDictionary state, EditableWorldCustomer customer) {
            if(customer.CustomerName.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Length != 2) {
                ModelState.AddModelError("CustomerName", "The customer name should be in the following format: <First Name> <Last Name>");
                ViewData["lastSelectedCountry"] = customer.CountryId;
                return false;
            }
            return true;
        }

        public ActionResult GetCities(string countryID) {
            return GridViewExtension.GetComboBoxCallbackResult(p => {
                p.ValueField = "CityId";
                p.TextField = "CityName";
                p.ValueType = typeof(int);
                if(String.IsNullOrEmpty(countryID))
                    p.BindList(WorldCitiesDataProvider.GetAllCities());
                else {
                    p.BindList(WorldCitiesDataProvider.GetCities(System.Convert.ToInt32(countryID)));
                }
            });
        }
    }
}
