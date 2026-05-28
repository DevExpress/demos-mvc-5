using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos
{
    public partial class EditingController : DemoController {

        public EditingController() {
            DataProvider = new CompanyEmployeesDataProvider();
        }

        CompanyEmployeesDataProvider DataProvider { get; set; }

        public ActionResult EditFormLayout() {
            return DemoView("EditFormLayout", DataProvider.GetCompanyEmployees());
        }
        [ValidateInput(false)]
        public ActionResult EditFormLayoutPartial() {
            return PartialView("EditFormLayoutPartial", DataProvider.GetCompanyEmployees());
        }

        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult EditFormLayoutAddNewPartial([Bind] CompanyEmployee employee) {
            if (ModelState.IsValid)
                SafeExecute(() => DataProvider.InsertCompanyEmployee(employee));
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return EditFormLayoutPartial();
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult EditFormLayoutUpdatePartial([Bind] CompanyEmployee employee) {
            if(ModelState.IsValid)
                SafeExecute(() => DataProvider.UpdateCompanyEmployee(employee));
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return EditFormLayoutPartial();
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult EditFormLayoutDeletePartial([Bind] CompanyEmployee employee) {
            if(employee != null)
                SafeExecute(() => DataProvider.DeleteCompanyEmployee(employee));
            return EditFormLayoutPartial();
        }

    }
}
