using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DialogsController : DemoController {
        public ActionResult UploadProcessing() {
            return DemoView("UploadProcessing");
        }
        public ActionResult UploadProcessingPartial() {
            return PartialView("UploadProcessingPartial");
        }
        public ActionResult UploadProcessingImageUpload(string fileNamePrefix, string watermarkText, int maxWidth, int maxHeight) {
            FileSavingEventHandler onFileSaving = (s, e) => {
                using(Stream fileContent = e.UploadedFile.FileContent) {
                    ImageFormat imageFormat = null;
                    using(Image image = GetImageToSave(fileContent, maxWidth, maxHeight, out imageFormat)) {
                        if(!string.IsNullOrEmpty(watermarkText))
                            PhotoUtils.DrawWatermarkText(image, watermarkText);
                        MemoryStream memoryStream = new MemoryStream();
                        image.Save(memoryStream, imageFormat);

                        e.OutputStream = memoryStream;
                        if(!string.IsNullOrEmpty(fileNamePrefix))
                            e.FileName = string.Format("{0}_{1}", fileNamePrefix, e.FileName);
                    }
                }
            };
            HtmlEditorExtension.SaveUploadedFile(HtmlEditorDialogsDemosHelper.FileSaveSettings, HtmlEditorDialogsDemosHelper.ImageUploadValidationSettings, onFileSaving);            
            return null;
        }

        Image GetImageToSave(Stream stream, int maxWidth, int maxHeight, out ImageFormat originalFormat) {
            Image uploadedImage = Image.FromStream(stream);
            originalFormat = uploadedImage.RawFormat;
            if(uploadedImage.Height < maxHeight && uploadedImage.Width < maxWidth)
                return uploadedImage;
            using(uploadedImage)
                return PhotoUtils.GetReducedImage(uploadedImage, maxWidth, maxHeight);
        }
    }
}
