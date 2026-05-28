using DevExpress.XtraPivotGrid.Customization;

namespace DevExpress.Web.Demos {
    public class PivotGridFieldsCustomizationDemoOptions {
        public PivotGridFieldsCustomizationDemoOptions() {
            CustomizationFormStyle = CustomizationFormStyle.Simple;
            AllowDragFields = true;
            AllowDragFieldsInCustomizationForm = true;
        }

        public bool AllowDragFields { get; set; }
        public bool AllowDragFieldsInCustomizationForm { get; set; }
        public CustomizationFormLayout CustomizationFormLayout { get; set; }
        public CustomizationFormStyle CustomizationFormStyle { get; set; }
    }
}
