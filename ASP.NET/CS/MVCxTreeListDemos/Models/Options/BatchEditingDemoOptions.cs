using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class BatchEditingDemoOptions {
        public BatchEditingDemoOptions() {
            EditMode = GridViewBatchEditMode.Cell;
            StartEditAction = GridViewBatchStartEditAction.FocusedCellClick;
        }

        public GridViewBatchEditMode EditMode { get; set; }
        public GridViewBatchStartEditAction StartEditAction { get; set; }

        public void Assign(BatchEditingDemoOptions source) {
            EditMode = source.EditMode;
            StartEditAction = source.StartEditAction;
        }
    }
}
