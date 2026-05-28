using System;
using System.Threading;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DataViewController : DemoController {
        public ActionResult CustomCallback() {
            Session["SortField"] = string.Empty;
            Session["SortOrder"] = string.Empty;
            return DemoView("CustomCallback", GetData());
        }
        public ActionResult CustomCallbackPartial() {
            // Intentionally pauses server-side processing,
            // to demonstrate the Loading Panel functionality.
            Thread.Sleep(500);
            return PartialView("CustomCallbackPartial", GetData());
        }
        public ActionResult SortData(string sortField, string sortOrder) {
            // Intentionally pauses server-side processing,
            // to demonstrate the Loading Panel functionality.
            Thread.Sleep(500);
            Session["SortField"] = sortField;
            Session["SortOrder"] = sortOrder;
            return PartialView("CustomCallbackPartial", GetData());
        }
        System.Collections.IEnumerable GetData() {
            return Headphones.GetData((string)Session["SortField"], (string)Session["SortOrder"]);
        }
    }
}
