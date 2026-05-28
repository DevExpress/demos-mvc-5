using System.ComponentModel.DataAnnotations;
using System.Web.UI.WebControls;

namespace DevExpress.Web.Demos {
    public class BatchEditingDemoOptions {
        public BatchEditingDemoOptions() {
            BatchEditMode = CardViewBatchEditMode.Cell;
            StartEditAction = GridViewBatchStartEditAction.FocusedCellClick;
            HighlightDeletedCards = true;
        }

        public CardViewBatchEditMode BatchEditMode { get; set; }
        public GridViewBatchStartEditAction StartEditAction { get; set; }
        public bool HighlightDeletedCards { get; set; }

        public void Assign(BatchEditingDemoOptions source) {
            BatchEditMode = source.BatchEditMode;
            StartEditAction = source.StartEditAction;
            HighlightDeletedCards = source.HighlightDeletedCards;
        }
    }
}
