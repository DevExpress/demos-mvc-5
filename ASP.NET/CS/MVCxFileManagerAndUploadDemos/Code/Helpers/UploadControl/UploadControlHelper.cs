using System.Drawing;
using System.IO;
using System.Web;
using System.Web.UI;
using DevExpress.Web.Internal;

namespace DevExpress.Web.Demos {
    public partial class UploadControlHelper {
        public const string UploadDirectory = "~/Content/UploadControl/UploadFolder/";

        public static DevExpress.Web.UploadControlValidationSettings UploadValidationSettings = new DevExpress.Web.UploadControlValidationSettings() {
            AllowedFileExtensions = new string[] { ".jpg", ".jpeg", ".gif", ".png" },
            MaxFileSize = 4194304
        };
        public static string GetCallbackData(UploadedFile uploadedFile, string fileUrl) {
            string name = uploadedFile.FileName;
            long sizeInKilobytes = uploadedFile.ContentLength / 1024;
            string sizeText = sizeInKilobytes.ToString() + " KB";

            return name + "|" + fileUrl + "|" + sizeText;
        }
    }
}
