using System.ComponentModel.DataAnnotations;

namespace DevExpress.Web.Demos {
    public class MenuFeaturesDemoOptions {
        public const int DefaultAppearAfter = 300;
        public const int DefaultDisappearAfter = 500;
        public const int DefaultMaximumDisplayLevels = 0;

        public MenuFeaturesDemoOptions() {
            AllowSelectItem = true;
            EnableHotTrack = true;
            EnableAnimation = true;
            AppearAfter = DefaultAppearAfter;
            DisappearAfter = DefaultDisappearAfter;
            MaximumDisplayLevels = DefaultMaximumDisplayLevels;
            AutoSeparators = AutoSeparatorMode.None;
        }

        public bool AllowSelectItem { get; set; }
        public bool EnableHotTrack { get; set; }
        public bool EnableAnimation { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Must be 0 or greater.")]
        public int AppearAfter { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Must be 0 or greater.")]
        public int DisappearAfter { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Must be 0 or greater.")]
        public int MaximumDisplayLevels { get; set; }
        public AutoSeparatorMode AutoSeparators { get; set; }
    }

}
