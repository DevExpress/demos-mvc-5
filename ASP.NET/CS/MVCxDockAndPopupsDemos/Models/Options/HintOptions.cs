using System.ComponentModel.DataAnnotations;
using System.Web.UI.WebControls;

namespace DevExpress.Web.Demos {
    public class HintFeaturesDemoOptions {
        public const int DefaultAppearAfter = 100;
        public const int DefaultDisappearAfter = 100;

        public HintFeaturesDemoOptions() {
            Animation = true;
            ShowCallout = true;
            ShowTitle = false;
            AppearAfter = DefaultAppearAfter;
            DisappearAfter = DefaultDisappearAfter;
            Trigger = HintTriggerAction.Hover;
        }
        public bool Animation { get; set; }
        public bool ShowCallout { get; set; }
        public bool ShowTitle { get; set; }
        public HintTriggerAction Trigger { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Must be 0 or greater.")]
        public int AppearAfter { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Must be 0 or greater.")]
        public int DisappearAfter { get; set; }
    }
}
