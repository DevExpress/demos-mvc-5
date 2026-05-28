using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class MailMergeController : DemoController {
        public ActionResult BuiltInMailMerge() {
            return DemoView("BuiltInMailMerge", NorthwindContextProvider.GetEmployees());
        }
        public ActionResult BuiltInMailMergePartial() {
            return PartialView("BuiltInMailMergePartial", NorthwindContextProvider.GetEmployees());
        }
    }
}
