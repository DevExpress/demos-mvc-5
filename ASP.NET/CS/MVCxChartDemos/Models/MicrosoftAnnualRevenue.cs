using System.Collections.Generic;

namespace DevExpress.Web.Demos.Charts {
    public static class MicrosoftAnnualRevenueProvider {
        public static List<RevenueEntry> GetMicrosoftAnnualRevenue() {
            return new List<RevenueEntry>() {
                new RevenueEntry("2011", 69.943, 69.943),
                new RevenueEntry("2012", 73.723, 143.666),
                new RevenueEntry("2013", 77.849, 221.515),
                new RevenueEntry("2014", 86.833, 308.348),
                new RevenueEntry("2015", 93.58,  401.928)
            };
        }
    }

    public class RevenueEntry {
        string year;
        double annualRevenue;
        double summaryRevenue;

        public string Year { get { return year; } }
        public double AnnualRevenue { get { return annualRevenue; } }
        public double SummaryRevenue { get { return summaryRevenue; } }

        public RevenueEntry(string year, double annualRevenue, double summaryRevenue) {
            this.year = year;
            this.annualRevenue = annualRevenue;
            this.summaryRevenue = summaryRevenue;
        }
    }
}
