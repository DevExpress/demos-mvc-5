namespace DevExpress.Web.Demos {
    public enum Palette { Default, Gray, Red, Green, Blue }
    public class ColorEditorDemoOptions {
        public ColorEditorDemoOptions() {
            EnableCustomColors = true;
            ColumnCount = 10;
            Palettes = Palette.Default;
        }
        public bool EnableCustomColors { get; set; }
        public int ColumnCount { get; set; }
        public Palette Palettes { get; set; }
    }
}
