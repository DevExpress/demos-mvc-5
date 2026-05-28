using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DevExpress.Web.Demos {
    public partial class ImageZoomController : DemoController {
        public ActionResult BindingToBinaryData() {
            ViewBag.IsRequiredVerticalGrid = true;
            return DemoView("BindingToBinaryData", GetHeadphones());
        }

        public ActionResult BindingToBinaryDataPartial() {            
            return PartialView("BindingToBinaryDataPartial", GetHeadphones());
        }

        List<Headphone> GetHeadphones() {
            return HeadphonesDataProvider.Headphones.ToList();
        }
    }
}
