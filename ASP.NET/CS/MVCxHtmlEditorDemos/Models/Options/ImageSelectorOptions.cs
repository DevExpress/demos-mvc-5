using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class ImageSelectorOptions : BaseOptions {
        
        public bool ShowMoreOptions { get; set; }
        public bool EnableEditing { get; set; }
        public bool EnableUpload { get; set; }
        public FileListView FileListView { get; set; }
        public bool ShowToolbar { get; set; }
        public bool ShowFoldersArea { get; set; }
        public bool ShowBreadcrumbs { get; set; }

        public static ImageSelectorOptions CreateDefault() {
            ImageSelectorOptions defaultOptions = new ImageSelectorOptions();
            defaultOptions.Html = HtmlEditorFeaturesDemosHelper.GeHtmlContentByFileName("UploadProcessing.html");
            defaultOptions.ShowToolbar = true;
            defaultOptions.ShowBreadcrumbs = true;
            defaultOptions.ShowMoreOptions = true;
            defaultOptions.FileListView = FileListView.Thumbnails;
            return defaultOptions;
        }
    }
}
