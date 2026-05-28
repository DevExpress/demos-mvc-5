using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ColumnsController : DemoController {
        public override string Name { get { return "Columns"; } }
        public ActionResult TextEllipsis() {
            return DemoView("TextEllipsis", NorthwindDataProvider.GetCustomers());
        }
    }
}
