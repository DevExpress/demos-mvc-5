using System.Web.Mvc;
using System.Linq;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FormLayoutController: DemoController {
        public ActionResult DataBinding() {
            return DemoView("DataBinding", NorthwindDataProvider.GetEditableEmployees().First());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DataBindingApplyChanges([Bind] EditableEmployee employee) {
            if(!ModelState.IsValid)
                return DemoView("DataBinding", employee);
            NorthwindDataProvider.UpdateEditableEmployee(employee);
            return DemoView("DataBinding", NorthwindDataProvider.GetEditableEmployeeByID(employee.EmployeeID));
        }
        public ActionResult DataBindingPartial(int employeeID) {
            return PartialView("DataBindingPartial", NorthwindDataProvider.GetEditableEmployeeByID(employeeID));
        }
    }
}
