using System.ComponentModel.DataAnnotations;
using System.Web.UI.WebControls;

namespace DevExpress.Web.Demos {
    public class BatchEditingDemoOptions {
        public BatchEditingDemoOptions() {
            PagerMode = GridViewPagerMode.EndlessPaging;
            EditMode = GridViewBatchEditMode.Cell;
            StartEditAction = GridViewBatchStartEditAction.FocusedCellClick;
            HighlightDeletedRows = true;
            KeepChangesOnCallbacks = true;
        }
        public GridViewPagerMode PagerMode { get; set; }
        public GridViewBatchEditMode EditMode { get; set; }
        public GridViewBatchStartEditAction StartEditAction { get; set; }
        public bool HighlightDeletedRows { get; set; }
        public bool KeepChangesOnCallbacks { get; set; }

        public void Assign(BatchEditingDemoOptions source) {
            EditMode = source.EditMode;
            StartEditAction = source.StartEditAction;
            HighlightDeletedRows = source.HighlightDeletedRows;
            PagerMode = source.PagerMode;
        }
    }
}
