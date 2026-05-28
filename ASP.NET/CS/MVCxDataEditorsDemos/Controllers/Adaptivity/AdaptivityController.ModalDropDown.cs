using DevExpress.Web.Demos.Mvc;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AdaptivityController : DemoController {

        public ActionResult ModalDropDown() {
            return DemoView("ModalDropDown");
        }

        public ActionResult ModalDropDownPage() {
            return View("ModalDropDownPage", WorldCitiesDataProvider.GetCountries());
        }
    }
}
