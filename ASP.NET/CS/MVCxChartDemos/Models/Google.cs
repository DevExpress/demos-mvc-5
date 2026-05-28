using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DevExpress.Web.Demos.Charts {
    public static class GoogleStockPricesProvider {
        static DataTable googlePricesTable;
        static DataTable GooglePricesTable {
            get {
                if (googlePricesTable == null)
                    googlePricesTable = LoadGooglePricesTable();
                return googlePricesTable;
            }
        }

        static DataTable LoadGooglePricesTable() {  // data for end of 2016
            return XMLUtils.LoadDataTableFromXml("GoogleStock.xml", "StockPrice");
        }


        public static IList GetGoogleStockPrices() {
            return GooglePricesTable.AsEnumerable()
                .Select(row => new StockPrice(row.Field<DateTime>("Date"), row.Field<double>("Low"), row.Field<double>("High"), row.Field<double>("Open"), row.Field<double>("Close"))).ToList();
        }
    }

    public class StockPrice {
        DateTime date;
        double lowValue;
        double highValue;
        double openValue;
        double closeValue;

        public DateTime Date { get { return date; } }
        public double LowValue { get { return lowValue; } }
        public double HighValue { get { return highValue; } }
        public double OpenValue { get { return openValue; } }
        public double CloseValue { get { return closeValue; } }

        public StockPrice(DateTime date, double lowValue, double highValue, double openValue, double closeValue) {
            this.date = date;
            this.lowValue = lowValue;
            this.highValue = highValue;
            this.openValue = openValue;
            this.closeValue = closeValue;
        }
    }
}
