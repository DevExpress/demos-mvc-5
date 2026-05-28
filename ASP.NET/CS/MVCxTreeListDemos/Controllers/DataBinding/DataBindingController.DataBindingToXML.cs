using System.Threading;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DataBindingController : DemoController {
        public ActionResult DataBindingToXML() {
            return DemoView("DataBindingToXML");
        }
        public ActionResult DataBindingToXMLPartial() {
            if(DevExpressHelper.IsCallback)
                // Intentionally pauses server-side processing,
                // to demonstrate the Loading Panel functionality.
                System.Threading.Thread.Sleep(500);
            return PartialView("DataBindingToXMLPartial");
        }
    }
}
