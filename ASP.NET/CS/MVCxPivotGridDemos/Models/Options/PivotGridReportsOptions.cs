namespace DevExpress.Web.Demos {
    public enum CustomerReportKind { Customers, Filtered, Top2Products, Top10Customers };
    
    public class PivotGridReportsDemoOptions {
        public CustomerReportKind DemoKind { get; set; }
        public int FilterYearIndex { get; set; }
        public int FilterQuarterIndex { get; set; }
        public bool ReloadLayout { get; set; }

        public static PivotGridReportsDemoOptions Default {
            get {
                return new PivotGridReportsDemoOptions() {
                    DemoKind = CustomerReportKind.Filtered,
                    FilterYearIndex = 0,
                    FilterQuarterIndex = 0
                };
            }
        }
    }
}
