using System.Web.UI.WebControls;

namespace DevExpress.Web.Demos {
    public class PagingAndScrollingOptions {
        public PagingAndScrollingOptions() {
            EndlessPagingMode = CardViewEndlessPagingMode.OnClick;
            EnableScrolling = false;
        }

        public CardViewEndlessPagingMode EndlessPagingMode { get; set; }
        public bool EnableScrolling { get; set; }
        public DevExpress.Web.ScrollBarMode VerticalScrollBarMode {
            get {
                return EnableScrolling ? ScrollBarMode.Visible : ScrollBarMode.Hidden;
            }
        }
    }
}
