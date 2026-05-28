using System.ComponentModel.DataAnnotations;

namespace DevExpress.Web.Demos {
    public class FormLayoutFeaturesDemoOptions {
        public FormLayoutFeaturesDemoOptions() {
            GroupSettingsGroupBoxDecoration = GroupBoxDecoration.Box;
            GroupSettingsShowCaption = true;

            ItemCaptionSettingsShowCaption = true;
            ItemCaptionSettingsLocation = LayoutItemCaptionLocation.Left;
            ItemCaptionSettingsHorizontalAlign = FormLayoutHorizontalAlign.Left;
            ItemCaptionSettingsVerticalAlign = FormLayoutVerticalAlign.Top;

            ItemHelpTextSettingsShowHelpText = true;
        }

        [Display(Name = "Group Box Decoration")]
        public GroupBoxDecoration GroupSettingsGroupBoxDecoration { get; set; }
        [Display(Name = "Show Caption")]
        public bool GroupSettingsShowCaption { get; set; }

        [Display(Name = "Show Caption")]
        public bool ItemCaptionSettingsShowCaption { get; set; }
        [Display(Name = "Location")]
        public LayoutItemCaptionLocation ItemCaptionSettingsLocation { get; set; }
        [Display(Name = "Horizontal Align")]
        public FormLayoutHorizontalAlign ItemCaptionSettingsHorizontalAlign { get; set; }
        [Display(Name = "Vertical Align")]
        public FormLayoutVerticalAlign ItemCaptionSettingsVerticalAlign { get; set; }

        [Display(Name = "Show Help Text")]
        public bool ItemHelpTextSettingsShowHelpText { get; set; }
        [Display(Name = "Position")]
        public HelpTextPosition ItemHelpTextSettingsPosition { get; set; }
        [Display(Name = "Horizontal Align")]
        public HelpTextHorizontalAlign ItemHelpTextSettingsHorizontalAlign { get; set; }
        [Display(Name = "Vertical Align")]
        public HelpTextVerticalAlign ItemHelpTextSettingsVerticalAlign { get; set; }
    }
}
