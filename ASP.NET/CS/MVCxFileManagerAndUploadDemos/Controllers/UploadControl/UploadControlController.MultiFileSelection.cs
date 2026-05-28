using System.Web.Mvc;
using DevExpress.Web.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using DevExpress.Web.Internal;
using System.Web;
using System.Web.UI;

namespace DevExpress.Web.Demos {
    public partial class UploadControlController : DemoController {
        public ActionResult MultiFileSelection() {
            return DemoView("MultiFileSelection");
        }
        public ActionResult MultiSelectionImageUpload() {
            UploadControlExtension.GetUploadedFiles("ucMultiSelection", UploadControlHelper.UploadValidationSettings, FileUploadCompleteMultiSelect);
            return null;
        }
        public void FileUploadCompleteMultiSelect(object sender, DevExpress.Web.FileUploadCompleteEventArgs e) {
            string uploadDirectory = UploadControlHelper.UploadDirectory;
#pragma warning disable DX0025 // used const + UploadedFile.FileName, which is safe due to internal path sanitization with Path.GetFileName(), no path traversal risk
            string resultFileUrl = uploadDirectory + e.UploadedFile.FileName;
#pragma warning restore DX0025 // used const + UploadedFile.FileName, which is safe due to internal path sanitization with Path.GetFileName(), no path traversal risk
            string resultFilePath = Request.MapPath(resultFileUrl);

            e.UploadedFile.SaveAs(resultFilePath);

            UploadingUtils.RemoveFileWithDelay(e.UploadedFile.FileName, resultFilePath, 5);

            IUrlResolutionService urlResolver = sender as IUrlResolutionService;
            if(urlResolver != null) {
                string url = urlResolver.ResolveClientUrl(resultFileUrl);
                e.CallbackData = UploadControlHelper.GetCallbackData(e.UploadedFile, url);
            }
        }
    }
}
