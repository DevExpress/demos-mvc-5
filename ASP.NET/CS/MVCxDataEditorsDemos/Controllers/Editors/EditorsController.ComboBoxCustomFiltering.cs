using DevExpress.Web.Demos.Mvc;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditorsController : DemoController {        
        public ActionResult ComboBoxCustomFiltering() {            
            return DemoView("ComboBoxCustomFiltering");
        }
        public ActionResult ComboBoxCustomFilteringPartial() {            
            return PartialView(NorthwindDataProvider.GetCustomers());
        }
    }
}
