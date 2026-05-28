using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Web.Mvc;
using System;
using System.IO;
using System.Web;

namespace DevExpress.Web.Demos {
    public class HtmlEditorFeaturesDemosHelper {
        public const string ImagesDirectory = "~/Content/HtmlEditor/Images/";
        public const string ThumbnailsDirectory = "~/Content/HtmlEditor/Thumbnails/";
        public const string UploadDirectory = "~/Content/HtmlEditor/UploadFiles/";
        public const string HtmlLocation = "~/Content/HtmlEditor/DemoHtml/";

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

        public static MVCxHtmlEditorImageSelectorSettings SetHtmlEditorImageSelectorSettings(MVCxHtmlEditorImageSelectorSettings settingsImageSelector) {
            settingsImageSelector.UploadCallbackRouteValues = new { Controller = "Features", Action = "FeaturesImageSelectorUpload" };

            settingsImageSelector.Enabled = true;
            settingsImageSelector.CommonSettings.RootFolder = ImagesDirectory;
            settingsImageSelector.CommonSettings.ThumbnailFolder = ThumbnailsDirectory;
            settingsImageSelector.CommonSettings.AllowedFileExtensions = new string[] { ".jpg", ".jpeg", ".jpe", ".gif", ".png" };
            settingsImageSelector.EditingSettings.AllowCreate = true;
            settingsImageSelector.EditingSettings.AllowDelete = true;
            settingsImageSelector.EditingSettings.AllowMove = true;
            settingsImageSelector.EditingSettings.AllowRename = true;
            settingsImageSelector.UploadSettings.Enabled = true;
            settingsImageSelector.FoldersSettings.ShowLockedFolderIcons = true;

            settingsImageSelector.PermissionSettings.AccessRules.Add(
                new FileManagerFolderAccessRule {
                    Path = "",
                    Upload = Rights.Deny
                });
            return settingsImageSelector;
        }

        public static string GeHtmlContentByFileName(string fileName) {
            return System.IO.File.ReadAllText(System.Web.HttpContext.Current.Request.MapPath(string.Format("{0}{1}", HtmlLocation, fileName)));
        }
        public static string GeHtmlContentByFileName(string fileName, bool demoPageIsInRoot) {
            string result = GeHtmlContentByFileName(fileName);
            return demoPageIsInRoot ? result : result.Replace("Content/", "../Content/");
        }

        public static void SetupGlobalUploadBehaviour(HtmlEditorSettings settings) {
            settings.SettingsDialogs.InsertImageDialog.ShowFileUploadSection = true;
            settings.SettingsDialogs.InsertImageDialog.SettingsImageUpload.FileSystemSettings.Assign(HtmlEditorFeaturesDemosHelper.FileSaveSettings.FileSystemSettings);
            settings.SettingsDialogs.InsertImageDialog.SettingsImageUpload.ValidationSettings.Assign(HtmlEditorFeaturesDemosHelper.ImageUploadValidationSettings);

            long maxFileSize = 5 * 1024 * 1024;
            settings.SettingsDialogs.InsertImageDialog.SettingsImageUpload.ValidationSettings.MaxFileSize = maxFileSize;
            settings.SettingsDialogs.InsertImageDialog.SettingsImageSelector.UploadSettings.ValidationSettings.MaxFileSize = maxFileSize;
            settings.SettingsDialogs.InsertAudioDialog.SettingsAudioUpload.ValidationSettings.MaxFileSize = maxFileSize;
            settings.SettingsDialogs.InsertAudioDialog.SettingsAudioSelector.UploadSettings.ValidationSettings.MaxFileSize = maxFileSize;
            settings.SettingsDialogs.InsertFlashDialog.SettingsFlashUpload.ValidationSettings.MaxFileSize = maxFileSize;
            settings.SettingsDialogs.InsertFlashDialog.SettingsFlashSelector.UploadSettings.ValidationSettings.MaxFileSize = maxFileSize;
            settings.SettingsDialogs.InsertVideoDialog.SettingsVideoUpload.ValidationSettings.MaxFileSize = maxFileSize;
            settings.SettingsDialogs.InsertVideoDialog.SettingsVideoSelector.UploadSettings.ValidationSettings.MaxFileSize = maxFileSize;
            settings.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.UploadSettings.ValidationSettings.MaxFileSize = maxFileSize;
            settings.Init = (s, e) => {
                var htmlEditor = s as DevExpress.Web.ASPxHtmlEditor.ASPxHtmlEditor;
                htmlEditor.ImageFileSaving += OnImageFileSaving;
                htmlEditor.AudioFileSaving += OnAudioFileSaving;
                htmlEditor.FlashFileSaving += OnFlashFileSaving;
                htmlEditor.VideoFileSaving += OnVideoFileSaving;

                htmlEditor.AudioSelectorFileUploading += OnFileSelectorAction;
                htmlEditor.AudioSelectorItemRenaming += OnFileSelectorAction;
                htmlEditor.AudioSelectorItemMoving += OnFileSelectorAction;
                htmlEditor.AudioSelectorItemDeleting += OnFileSelectorAction;
                htmlEditor.AudioSelectorItemCopying += OnFileSelectorAction;

                htmlEditor.FlashSelectorFileUploading += OnFileSelectorAction;
                htmlEditor.FlashSelectorItemRenaming += OnFileSelectorAction;
                htmlEditor.FlashSelectorItemMoving += OnFileSelectorAction;
                htmlEditor.FlashSelectorItemDeleting += OnFileSelectorAction;
                htmlEditor.FlashSelectorItemCopying += OnFileSelectorAction;

                htmlEditor.ImageSelectorFileUploading += OnFileSelectorAction;
                htmlEditor.ImageSelectorItemRenaming += OnFileSelectorAction;
                htmlEditor.ImageSelectorItemMoving += OnFileSelectorAction;
                htmlEditor.ImageSelectorItemDeleting += OnFileSelectorAction;
                htmlEditor.ImageSelectorItemCopying += OnFileSelectorAction;

                htmlEditor.VideoSelectorFileUploading += OnFileSelectorAction;
                htmlEditor.VideoSelectorItemRenaming += OnFileSelectorAction;
                htmlEditor.VideoSelectorItemMoving += OnFileSelectorAction;
                htmlEditor.VideoSelectorItemDeleting += OnFileSelectorAction;
                htmlEditor.VideoSelectorItemCopying += OnFileSelectorAction;

                htmlEditor.DocumentSelectorFileUploading += OnFileSelectorAction;
                htmlEditor.DocumentSelectorItemRenaming += OnFileSelectorAction;
                htmlEditor.DocumentSelectorItemMoving += OnFileSelectorAction;
                htmlEditor.DocumentSelectorItemDeleting += OnFileSelectorAction;
                htmlEditor.DocumentSelectorItemCopying += OnFileSelectorAction;
            };
        }
        static void OnFileSelectorAction(object source, FileManagerActionEventArgsBase e) {
            e.Cancel = DevExpress.Web.Demos.Utils.IsSiteMode;
            e.ErrorText = DevExpress.Web.Demos.Utils.GetReadOnlyMessageText();
        }
        public static void OnImageFileSaving(object s, FileSavingEventArgs e) {
            PrepareFileToDelayedRemove(s as DevExpress.Web.ASPxHtmlEditor.ASPxHtmlEditor, he => he.SettingsDialogs.InsertImageDialog.SettingsImageUpload, e);
        }
        static void OnAudioFileSaving(object s, FileSavingEventArgs e) {
            PrepareFileToDelayedRemove(s as DevExpress.Web.ASPxHtmlEditor.ASPxHtmlEditor, he => he.SettingsDialogs.InsertAudioDialog.SettingsAudioUpload, e);
        }
        static void OnFlashFileSaving(object s, FileSavingEventArgs e) {
            PrepareFileToDelayedRemove(s as DevExpress.Web.ASPxHtmlEditor.ASPxHtmlEditor, he => he.SettingsDialogs.InsertFlashDialog.SettingsFlashUpload, e);
        }
        static void OnVideoFileSaving(object s, FileSavingEventArgs e) {
            PrepareFileToDelayedRemove(s as DevExpress.Web.ASPxHtmlEditor.ASPxHtmlEditor, he => he.SettingsDialogs.InsertVideoDialog.SettingsVideoUpload, e);
        }

        static void PrepareFileToDelayedRemove(DevExpress.Web.ASPxHtmlEditor.ASPxHtmlEditor htmlEditor, 
            Func<DevExpress.Web.ASPxHtmlEditor.ASPxHtmlEditor, ASPxHtmlEditorUploadSettingsBase> uploadSettingsGetter, 
            FileSavingEventArgs e) {

            e.FileName = string.Format("DEMOTMPFILE_{0}{1}", Guid.NewGuid(), Path.GetExtension(e.FileName));
            string filePath = Path.Combine(HttpContext.Current.Server.MapPath(uploadSettingsGetter(htmlEditor).UploadFolder), e.FileName);
            UploadingUtils.RemoveFileWithDelay(filePath, filePath, 1);
        }
    }
}
