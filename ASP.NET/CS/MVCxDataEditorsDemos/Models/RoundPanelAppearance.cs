using System.Drawing;

namespace DevExpress.Web.Demos {
    public class RoundPanelAppearance {
        public RoundPanelAppearance() {
            HeaderBackgroundColor = Color.FromArgb(222, 222, 222);
            HeaderFontColor = Color.FromArgb(0, 0, 0);
            BackgroundColor = Color.FromArgb(247, 247, 247);
            BorderColor = Color.FromArgb(128, 128, 128);
            FontColor = Color.FromArgb(0, 0, 0);
        }
        public Color HeaderBackgroundColor { get; set; }
        public Color HeaderFontColor { get; set; }
        public Color BackgroundColor { get; set; }
        public Color BorderColor { get; set; }
        public Color FontColor { get; set; }
    }
}
