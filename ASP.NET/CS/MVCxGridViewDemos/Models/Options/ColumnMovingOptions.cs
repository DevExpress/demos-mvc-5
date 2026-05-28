using System.Web.UI.WebControls;

namespace DevExpress.Web.Demos {
    public class ColumnMovingDemoOptions {
        public ColumnMovingDemoOptions() {
            ProcessColumnMoveOnClient = true;
            ColumnMoveMode = GridColumnMoveMode.AmongSiblings;
        }

        public bool ProcessColumnMoveOnClient { get; set; }
        public GridColumnMoveMode ColumnMoveMode { get; set; }
    }
}
