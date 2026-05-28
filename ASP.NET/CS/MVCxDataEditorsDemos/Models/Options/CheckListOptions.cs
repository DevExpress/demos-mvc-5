using System.Web.UI.WebControls;

namespace DevExpress.Web.Demos {
    public class CheckListDemoOptions {        
        public CheckListDemoOptions() {
            RepeatLayout = RepeatLayout.Flow;
            RepeatDirection = RepeatDirection.Vertical;
            RepeatColumns = 4;
        }
        public RepeatLayout RepeatLayout { get; set; }
        public RepeatDirection RepeatDirection { get; set; }
        public int RepeatColumns { get; set; }
    }
}
