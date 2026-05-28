using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
namespace DevExpress.Web.Demos {
    public class ImageGalleryFolderBindingDemoOptions {

        public static readonly ImageGalleryFolderBindingDemoOptions Default = CreateDefault();

        [DisplayName("Apply watermark")]
        public bool ApplyWatermark { get; set; }
        [DisplayName("Select folder")]
        public string ImageSourceFolder { get; set; }

        public string ImageCacheFolder {
            get {
                return ApplyWatermark ? ImageGalleryDemoHelper.WatermarkImageCacheFolder
                    : ImageGalleryDemoHelper.DefaultImageCacheFolder;
            }
        }
        public List<SelectListItem> ImageSourceFolders { get { return ImageSliderDemoHelper.GetSourceFolders(); } }

        static ImageGalleryFolderBindingDemoOptions CreateDefault() {
            return new ImageGalleryFolderBindingDemoOptions() {
                ImageSourceFolder = ImageGalleryDemoHelper.LandscapeImageFolder,
                ApplyWatermark = false
            };
        }
    }
}
