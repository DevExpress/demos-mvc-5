using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class SpreadsheetWorksheetProtectionOptions {
        public bool FormatCells { get; set; }
        public bool FormatColumns { get; set; }
        public bool FormatRows { get; set; }
        public bool InsertColumns { get; set; }
        public bool InsertRows { get; set; }
        public bool InsertHyperlinks { get; set; }
        public bool DeleteColumns { get; set; }
        public bool DeleteRows { get; set; }
        public bool Sort { get; set; }
        public bool UseAutoFilter { get; set; }
        public bool EditObjects { get; set; }
    }
}
