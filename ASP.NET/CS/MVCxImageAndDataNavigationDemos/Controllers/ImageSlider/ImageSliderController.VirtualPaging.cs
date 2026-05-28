using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ImageSliderController : DemoController {
        public ActionResult VirtualPaging() {
            return DemoView("VirtualPaging", ImagesDataLarge.GetData("~/App_Data/cities.xml"));
        }
        public ActionResult VirtualPagingPartial() {
            return PartialView("VirtualPagingPartial", ImagesDataLarge.GetData("~/App_Data/cities.xml"));
        }
    }
}
