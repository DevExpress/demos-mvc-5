using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class CustomizationController : DemoController {
        public ActionResult ColumnChooser() {
            return DemoView("ColumnChooser", NorthwindDataProvider.GetCustomers());
        }
        public ActionResult ColumnChooserPartial() {
            return PartialView("ColumnChooserPartial", NorthwindDataProvider.GetCustomers());
        }
    }
}
