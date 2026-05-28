using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class TemplatesController : DemoController {
        public ActionResult Templates() {
            ViewBag.PageSize = 2;
            return DemoView("Templates", NorthwindDataProvider.GetEmployees());
        }
        public ActionResult TemplatesPartial(int pageSize = 2) {
            if (pageSize <= 0)
                pageSize = 2;
            ViewBag.PageSize = pageSize;
            return PartialView("TemplatesPartial", NorthwindDataProvider.GetEmployees());
        }
    }
}
