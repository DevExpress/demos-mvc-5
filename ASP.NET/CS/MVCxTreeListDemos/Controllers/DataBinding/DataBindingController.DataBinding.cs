using System.Threading;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DataBindingController : DemoController {
        public ActionResult DataBinding() {
            Session["TreeListState"] = null;
            ViewBag.ShowServiceColumns = false;
            return DemoView("DataBinding", DepartmentsProvider.GetDepartments());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DataBinding(bool showServiceColumns = false) {
            ViewBag.ShowServiceColumns = showServiceColumns;
            return DemoView("DataBinding", DepartmentsProvider.GetDepartments());
        }
        public ActionResult DataBindingPartial(bool showServiceColumns = false) {
            if(DevExpressHelper.IsCallback)
                // Intentionally pauses server-side processing,
                // to demonstrate the Loading Panel functionality.
                System.Threading.Thread.Sleep(500);
            ViewBag.ShowServiceColumns = showServiceColumns;
            return PartialView("DataBindingPartial", DepartmentsProvider.GetDepartments());
        }
    }
}
