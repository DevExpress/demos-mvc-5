using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ToolbarItemsController: DemoController {
        public ActionResult CustomCss() {
            return DemoView("CustomCss");
        }
        public ActionResult CustomCssPartial() {
            return PartialView("CustomCssPartial");
        }
    }

    public class HtmlEditorToolbarItemsDemosHelper {
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
