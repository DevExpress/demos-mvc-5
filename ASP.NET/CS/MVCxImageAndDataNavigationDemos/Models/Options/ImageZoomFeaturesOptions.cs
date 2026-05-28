namespace DevExpress.Web.Demos {
    public class ImageZoomFeaturesOptions {
        public ImageZoomFeaturesOptions() {
            EnableExpandMode = true;
            ShowHint = true;
        }
        public bool EnableExpandMode { get; set; }
        public bool ShowHint { get; set; }
        public ZoomWindowPosition ZoomWindowPosition { get; set; }
        public MouseBoxOpacityMode MouseBoxOpacityMode { get; set; }
        public LargeImageLoadMode LargeImageLoadMode { get; set; }
    }
}
