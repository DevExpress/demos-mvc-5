namespace DevExpress.Web.Demos {
    public class PivotGridChartIntegrationDemoOptions {
        public PivotGridChartIntegrationDemoOptions() {
            ChartType = XtraCharts.ViewType.Bar;
            ShowRowGrandTotals = true;
        }
        public XtraCharts.ViewType ChartType { get; set; }
        public bool ShowColumnGrandTotals { get; set; }
        public bool GenerateSeriesFromColumns { get; set; }
        public bool ShowPointLabels { get; set; }
        public bool ShowRowGrandTotals { get; set; }
    }
}
