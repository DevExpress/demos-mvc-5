using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using DevExpress.Web.Internal;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class UploadControlController : DemoController {
        public ActionResult DragAndDrop() {
            return DemoView("DragAndDrop");
        }
        public ActionResult DragAndDropImageUpload() {
            UploadControlExtension.GetUploadedFiles("ucDragAndDrop", UploadControlHelper.UploadValidationSettings, FileUploadCompleteDragDrop);
            return null;
        }
        public void FileUploadCompleteDragDrop(object sender, DevExpress.Web.FileUploadCompleteEventArgs e) {
            string uploadDirectory = UploadControlHelper.UploadDirectory;
            if(e.UploadedFile.IsValid) {
                string fileName = Path.ChangeExtension(Path.GetRandomFileName(), ".jpg");

#pragma warning disable DX0025 // used const + Path.GetRandomFileName(), no path traversal risk
                string resultFilePath = uploadDirectory + fileName;
#pragma warning restore DX0025 // used const + Path.GetRandomFileName(), no path traversal risk
                using(Image original = Image.FromStream(e.UploadedFile.FileContent)) {
                    using(Image thumbnail = new ImageThumbnailCreator(original).CreateImageThumbnail(new Size(350, 350))) {
                        ImageUtils.SaveToJpeg(thumbnail, Request.MapPath(resultFilePath));
                    }
                }
                UploadingUtils.RemoveFileWithDelay(fileName, Request.MapPath(resultFilePath), 5);
                IUrlResolutionService urlResolver = sender as IUrlResolutionService;
                if(urlResolver != null)
                    e.CallbackData = urlResolver.ResolveClientUrl(resultFilePath);
            }
        }
    }
}
