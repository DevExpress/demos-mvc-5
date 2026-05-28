using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ColumnsController : DemoController {
        public ActionResult TextEllipsis() {
            return DemoView("TextEllipsis", NorthwindDataProvider.GetCustomers());
        }
        public ActionResult TextEllipsisPartial() {
            return PartialView("TextEllipsisPartial", NorthwindDataProvider.GetCustomers());
        }
    }
}
