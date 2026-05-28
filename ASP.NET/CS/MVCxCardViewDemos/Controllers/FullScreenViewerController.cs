using System.Web.Mvc;
using System.Web.UI;
using DevExpress.Web.Internal;

namespace DevExpress.Web.Demos.Controllers {
    public class FullScreenViewerController : Controller {
        public ActionResult Index(int? height, int? width, string url) {
            return PartialView("FullScreenViewer", new FullScreenViewerModel(url, height ?? 0, width ?? 0));
        }
        public ActionResult GetQRCode(string url) {
            if(string.IsNullOrEmpty(url))
                return null;
            var image = FullScreenModeUtils.GetQRCodeImage(url);
            using(var memStream = new System.IO.MemoryStream()) {
                image.Save(memStream, System.Drawing.Imaging.ImageFormat.Png);
                return File(memStream.GetBuffer(), "image/png");
            }
        }
    }
}
