namespace DevExpress.Web.Demos.RichEditDemo {
    using DevExpress.Web.Mvc;

    public static class FileManagerHelper {
        public static FileManagerSettings CreateDownloadSettings() {
            var settings = new FileManagerSettings() { Name = "FileManager" };
            settings.SettingsEditing.AllowDownload = true;
            return settings;
        }
    }
}
