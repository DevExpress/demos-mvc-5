using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ImageSliderController : DemoController {
        public ActionResult Features() {
            return DemoView("Features", new ImageSliderFeaturesDemoOptions());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Features([Bind] ImageSliderFeaturesDemoOptions options) {
            ImageSliderFeaturesDemoOptions predefinedOptions = !string.IsNullOrEmpty(options.PredefinedScenario) 
                ? new ImageSliderFeaturesDemoOptions() { PredefinedScenario = options.PredefinedScenario }
                : options;
            switch(options.PredefinedScenario) {
                case "FillAndCropDots":
                    predefinedOptions.SettingsImageArea.ImageSizeMode = ImageSizeMode.FillAndCrop;
                    predefinedOptions.SettingsImageArea.NavigationButtonVisibility = ElementVisibilityMode.Always;
                    predefinedOptions.SettingsImageArea.ItemTextVisibility = ElementVisibilityMode.Always;
                    predefinedOptions.SettingsNavigationBar.Mode =  DevExpress.Web.NavigationBarMode.Dots;
                    break;
                case "VerticalScrolling":
                    predefinedOptions.SettingsImageArea.NavigationDirection = NavigationDirection.Vertical;
                    predefinedOptions.SettingsImageArea.ImageSizeMode = ImageSizeMode.FillAndCrop;
                    predefinedOptions.SettingsImageArea.NavigationButtonVisibility = ElementVisibilityMode.Faded;
                    predefinedOptions.SettingsImageArea.ItemTextVisibility = ElementVisibilityMode.None;
                    predefinedOptions.SettingsNavigationBar.Position = NavigationBarPosition.Left;
                    predefinedOptions.SettingsNavigationBar.ThumbnailsModeNavigationButtonVisibility = ElementVisibilityMode.Faded;
                    break;
                default: 
                    break;
            }
            return DemoView("Features", predefinedOptions);
        }
    }
}
