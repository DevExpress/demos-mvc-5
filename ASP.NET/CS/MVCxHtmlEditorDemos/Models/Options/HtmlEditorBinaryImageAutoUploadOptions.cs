using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public class HtmlEditorBinaryImageAutoUploadOptions {

        [Display(Name = "AllowSaveBinaryImageToServer")]
        public bool AllowSaveBinaryImageToServer { get; set; }
        [Display(Name = "Max Height"), Range(100, 1000)]
        public int MaxHeight { get; set; }
        [Display(Name = "Max Width"), Range(100, 1000)]
        public int MaxWidth { get; set; }
        public string DemoHtml { get; set; }

        public void ProcessUploadedFile(object sender, FileSavingEventArgs args) {
            using(Stream fileContent = args.UploadedFile.FileContent) {
                ImageFormat imageFormat = null;
                using(Image image = GetImageToSave(fileContent, out imageFormat)) {
                    MemoryStream memoryStream = new MemoryStream();
                    image.Save(memoryStream, imageFormat);
                    args.OutputStream = memoryStream;
                    args.FileName = string.Format("{0}_{1}{2}", Path.GetFileNameWithoutExtension(args.FileName), Guid.NewGuid(), Path.GetExtension(args.FileName));
                }
            }
            Thread.Sleep(2000);
        }

        Image GetImageToSave(Stream stream, out ImageFormat originalFormat) {
            Image uploadedImage = Image.FromStream(stream);
            originalFormat = uploadedImage.RawFormat;
            if(uploadedImage.Height < MaxHeight && uploadedImage.Width < MaxWidth)
                return uploadedImage;
            using(uploadedImage)
                return PhotoUtils.GetReducedImage(uploadedImage, MaxWidth, MaxHeight);
        }

        public static HtmlEditorBinaryImageAutoUploadOptions CreateDefault() {
            HtmlEditorBinaryImageAutoUploadOptions result = new HtmlEditorBinaryImageAutoUploadOptions();
            result.DemoHtml = HtmlEditorFeaturesDemosHelper.GeHtmlContentByFileName("BinaryImageAutoUploadContent.html");
            result.MaxWidth = 480;
            result.MaxHeight = 320;
            result.AllowSaveBinaryImageToServer = true;
            return result;
        }
    }
}
