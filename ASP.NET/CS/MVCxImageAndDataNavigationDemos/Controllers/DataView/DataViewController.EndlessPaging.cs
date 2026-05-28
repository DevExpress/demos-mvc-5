using System.Threading;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DataViewController: DemoController {
        public ActionResult EndlessPaging() {
            DataViewDemoHelper.EndlessPagingMode = DataViewEndlessPagingMode.OnClick;
            return DemoView("EndlessPaging");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EndlessPaging(DataViewEndlessPagingMode endlessPagingMode) {
            DataViewDemoHelper.EndlessPagingMode = endlessPagingMode;
            return DemoView("EndlessPaging");
        }
        public ActionResult EndlessPagingPartial() {
            // Intentionally pauses server-side processing,
            // to demonstrate the Loading Panel functionality.
            Thread.Sleep(500);

            return PartialView("EndlessPagingPartial");
        }
    }
}
