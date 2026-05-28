using System.IO;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ImageGalleryController : DemoController {
        public ActionResult CustomImageViewer() {
            return DemoView("CustomImageViewer");
        }
        public ActionResult CustomImageViewerPartial() {
            return PartialView("CustomImageViewerPartial");
        }
        public ContentResult GetImageUrlByIndex(int index) {
            string sourceFolder = ImageGalleryDemoHelper.LandscapeImageFolder;
            string imageFilePath = Directory.GetFiles(Server.MapPath(sourceFolder))[index];
            return Content(Url.Content(Path.Combine(sourceFolder, Path.GetFileName(imageFilePath))));
        }
    }
}
