using DevExpress.Web.Mvc;
namespace DevExpress.Web.Demos {
    public class HtmlEditorDialogsDemosHelper {
        public const string ImagesDirectory = "~/Content/HtmlEditor/Images/";

        public static readonly UploadControlValidationSettings ImageUploadValidationSettings = new UploadControlValidationSettings {
            AllowedFileExtensions = new string[] { ".jpg", ".jpeg", ".jpe", ".gif", ".png" },
            MaxFileSize = 4000000
        };

        static HtmlEditorFileSaveSettings fileSaveSettings;
        public static HtmlEditorFileSaveSettings FileSaveSettings {
            get {
                if(fileSaveSettings == null) {
                    fileSaveSettings = new HtmlEditorFileSaveSettings();
                    fileSaveSettings.FileSystemSettings.UploadFolder = ImagesDirectory + "Upload/";
                }
                return fileSaveSettings;
            }
        }
    }
}
