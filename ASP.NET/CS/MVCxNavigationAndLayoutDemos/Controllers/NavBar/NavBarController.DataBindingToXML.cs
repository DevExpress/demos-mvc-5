using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class NavBarController: DemoController {
        public ActionResult DataBindingToXML() {
            ViewData["XPath"] = "/Cameras/*";
            return DemoView("DataBindingToXML", true);
        }
        public ActionResult DataBindingToXMLPartial() {
            ViewData["XPath"] = ComboBoxExtension.GetValue<string>("ddlXPath");
            return PartialView();
        }
    }
}
