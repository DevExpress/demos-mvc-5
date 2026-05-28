using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos.Charts {
    public static class FuelOilPriceProvider {
        public static IList<FuelOilPrice> GetFuelOilPrices() {
            int lastYear = DateTime.Now.Year - 1;
            return new List<FuelOilPrice>(){
            new FuelOilPrice(new DateTime(lastYear, 1, 1, 0, 0, 0), 1.05),
            new FuelOilPrice(new DateTime(lastYear, 3, 3, 0, 0, 0), 1.07),
            new FuelOilPrice(new DateTime(lastYear, 3, 20, 0, 0, 0), 1.12),
            new FuelOilPrice(new DateTime(lastYear, 4, 15, 0, 0, 0), 1.15),
            new FuelOilPrice(new DateTime(lastYear, 5, 12, 0, 0, 0), 1.30),
            new FuelOilPrice(new DateTime(lastYear, 7, 15, 0, 0, 0), 1.25),
            new FuelOilPrice(new DateTime(lastYear, 7, 20, 0, 0, 0), 1.21),
            new FuelOilPrice(new DateTime(lastYear, 9, 15, 0, 0, 0), 1.20),
            new FuelOilPrice(new DateTime(lastYear, 10, 10, 0, 0, 0), 1.18),
            new FuelOilPrice(new DateTime(lastYear, 12, 30, 0, 0, 0), 1.12)
            };
        }
    }

    public class FuelOilPrice {
        DateTime date;
        double price;

        public DateTime Date { get { return date; } }
        public double Price { get { return price; } }

        public FuelOilPrice(DateTime date, double price) {
            this.date = date;
            this.price = price;
        }
    }
}
