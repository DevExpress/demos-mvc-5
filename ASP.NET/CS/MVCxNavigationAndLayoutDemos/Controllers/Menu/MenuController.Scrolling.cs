using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class MenuController: DemoController {
        public ActionResult Scrolling() {
            Session["DXEnableScrolling"] = true;
            return DemoView("Scrolling", true);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Scrolling([Bind]bool? chEnableScrolling) {
            Session["DXEnableScrolling"] = chEnableScrolling;
            return DemoView("Scrolling", chEnableScrolling);
        }
        public ActionResult ScrollingFrame() {
            return DemoView("ScrollingFrame");
        }
    }
}
