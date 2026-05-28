using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DevExpress.Data.Utils;

namespace DevExpress.Web.Demos.Charts {
    public class DevAV {
        readonly static string[] regions = new string[] { "DevAV North", "DevAV South", "DevAV West", "DevAV East", "DevAV Center" };
        static Dictionary<string, List<string>> categorizedProducts;

        public static Dictionary<string, List<string>> CategorizedProducts {
            get {
                if (categorizedProducts == null) {
                    categorizedProducts = new Dictionary<string, List<string>>();
                    categorizedProducts["Cameras"] = new List<string>() { "Camera", "Camcorder", "Binoculars", "Flash", "Tripod" };
                    categorizedProducts["Cell Phones"] = new List<string>() { "Smartphone", "Mobile Phone", "Smart Watch", "Sim Card" };
                    categorizedProducts["Computers"] = new List<string>() { "Desktop", "Laptop", "Tablet", "Printer" };
                    categorizedProducts["TV, Audio"] = new List<string>() { "Television", "Home Audio", "Headphone", "DVD Player" };
                    categorizedProducts["Vehicle Electronics"] = new List<string>() { "GPS Unit", "Radar", "Car Alarm", "Car Accessories" };
                    categorizedProducts["Multipurpose Batteries"] = new List<string>() { "Battery", "Charger", "Converter", "Tester", "AC/DC Adapter" };
                }
                return categorizedProducts;
            }
        }

        public class RegionSales {
            public int Year { get; private set; }
            public string Region { get; private set; }
            public double Sales { get; private set; }
            public RegionSales(int year, string region, double sales) {
                Year = year;
                Region = region;
                Sales = sales;
            }
        }
        public class ProductRegionSales {
            public string ProductCategory { get; private set; }
            public string Region { get; private set; }
            public double Sales { get; private set; }
            public ProductRegionSales(string productCategory, string region, double sales) {
                ProductCategory = productCategory;
                Region = region;
                Sales = sales;
            }
        }
        public class CompanySales {
            public int Year { get; private set; }
            public string Company { get; private set; }
            public double Sales { get; private set; }
            public CompanySales(int year, string company, double sales) {
                Year = year;
                Company = company;
                Sales = sales;
            }
        }
        public class VendorCosts {
            public DateTime Year { get; private set; }
            public string Company { get; private set; }
            public double Costs { get; private set; }
            public VendorCosts(DateTime year, string company, double costs) {
                Year = year;
                Company = company;
                Costs = costs;
            }
        }

        public class TotalSales {            
            public static TotalSales CreateByNameProductCategoryRegionSales(DateTime date, string productName, string productCategory, string region, decimal sales) {
                TotalSales item = new TotalSales();
                item.SaleDate = date;
                item.ProductName = productName;
                item.ProductCategory = productCategory;
                item.Region = region;
                item.Sales = sales;
                return item;
            }

            public string Region { get; private set; }
            public decimal Sales { get; private set; }
            public string ProductCategory { get; private set; }
            public string ProductName { get; private set; }
            public DateTime SaleDate { get; private set; }

            TotalSales() { }
        }

        public static IList<RegionSales> GetSales() {
            int prevYear = DateTime.Now.Year - 1;
            return new List<RegionSales>() {
                new RegionSales(prevYear - 2, "Asia", 4.2372),
                new RegionSales(prevYear - 2, "Australia", 1.7871),
                new RegionSales(prevYear - 2, "Europe", 3.0884),
                new RegionSales(prevYear - 2, "North America", 3.4855),
                new RegionSales(prevYear - 2, "South America", 1.6027),
                new RegionSales(prevYear - 1, "Asia", 4.7685),
                new RegionSales(prevYear - 1, "Australia", 1.9576),
                new RegionSales(prevYear - 1, "Europe", 3.3579),
                new RegionSales(prevYear - 1, "North America", 3.7477),
                new RegionSales(prevYear - 1, "South America", 1.8237),
                new RegionSales(prevYear, "Asia", 5.2890),
                new RegionSales(prevYear, "Australia", 2.2727),
                new RegionSales(prevYear, "Europe", 3.7257),
                new RegionSales(prevYear, "North America", 4.1825),
                new RegionSales(prevYear, "South America", 2.1172)
            };
        }
        public static IList<ProductRegionSales> GetSalesMixByRegion() {
            return new List<ProductRegionSales>() {

            new ProductRegionSales("Video players", "Asia", 853D),
            new ProductRegionSales("Video players", "Australia", 321D),
            new ProductRegionSales("Video players", "Europe", 655D),
            new ProductRegionSales("Video players", "North America", 1325D),
            new ProductRegionSales("Video players", "South America", 653D),

            new ProductRegionSales("Automation", "Asia", 172D),
            new ProductRegionSales("Automation", "Australia", 255D),
            new ProductRegionSales("Automation", "Europe", 981D),
            new ProductRegionSales("Automation", "North America", 963D),
            new ProductRegionSales("Automation", "South America", 123D),
            
            new ProductRegionSales("Monitors", "Asia", 1011D),
            new ProductRegionSales("Monitors", "Australia", 359D),
            new ProductRegionSales("Monitors", "Europe", 721D),
            new ProductRegionSales("Monitors", "North America", 565D),
            new ProductRegionSales("Monitors", "South America", 532D),
            
            new ProductRegionSales("Projectors", "Asia", 998D),
            new ProductRegionSales("Projectors", "Australia", 222D),
            new ProductRegionSales("Projectors", "Europe", 865D),
            new ProductRegionSales("Projectors", "North America", 787D),
            new ProductRegionSales("Projectors", "South America", 332D),
            
            new ProductRegionSales("Televisions", "Asia", 1356D),
            new ProductRegionSales("Televisions", "Australia", 232D),
            new ProductRegionSales("Televisions", "Europe", 1323D),
            new ProductRegionSales("Televisions", "North America", 1125D),
            new ProductRegionSales("Televisions", "South America", 865D)

            };
        }
        public static List<CompanySales> GetBranchesSales() {
            int lastYear = DateTime.Now.Year - 1;
            return new List<CompanySales>() {
                new CompanySales(lastYear - 10, "DevAV North", 1.010),
                new CompanySales(lastYear - 10, "DevAV Center", 3.032),
                new CompanySales(lastYear - 10, "DevAV South", 1.31),
                
                new CompanySales(lastYear - 9, "DevAV North", 1.512),
                new CompanySales(lastYear - 9, "DevAV Center", 3.050),
                new CompanySales(lastYear - 9, "DevAV South", 1.34),
                
                new CompanySales(lastYear - 8, "DevAV North", 1.723),
                new CompanySales(lastYear - 8, "DevAV West", 0.005),
                new CompanySales(lastYear - 8, "DevAV Center", 3.054),
                new CompanySales(lastYear - 8, "DevAV South", 1.30),
                
                new CompanySales(lastYear - 7, "DevAV West", 0.31),
                new CompanySales(lastYear - 7, "DevAV North", 2.001),
                new CompanySales(lastYear - 7, "DevAV Center", 2.975),
                new CompanySales(lastYear - 7, "DevAV South", 1.283),
                
                new CompanySales(lastYear - 6, "DevAV West", 0.41),
                new CompanySales(lastYear - 6, "DevAV North", 2.612),
                new CompanySales(lastYear - 6, "DevAV Center", 2.066),
                new CompanySales(lastYear - 6, "DevAV South", 0.88),
                
                new CompanySales(lastYear - 5, "DevAV West", 0.95),
                new CompanySales(lastYear - 5, "DevAV North", 2.666),
                new CompanySales(lastYear - 5, "DevAV Center", 2.078),
                new CompanySales(lastYear - 5, "DevAV South", 1.09),
                
                new CompanySales(lastYear - 4, "DevAV West", 1.53),
                new CompanySales(lastYear - 4, "DevAV North", 3.665),
                new CompanySales(lastYear - 4, "DevAV Center", 3.888),
                new CompanySales(lastYear - 4, "DevAV South", 1.01),
                
                new CompanySales(lastYear - 3, "DevAV East", 0.003),
                new CompanySales(lastYear - 3, "DevAV West", 1.75),
                new CompanySales(lastYear - 3, "DevAV North", 3.555),
                new CompanySales(lastYear - 3, "DevAV Center", 3.008),
                new CompanySales(lastYear - 3, "DevAV South", 1.11),
                
                new CompanySales(lastYear - 2, "DevAV East", 0.32),
                new CompanySales(lastYear - 2, "DevAV West", 1.31),
                new CompanySales(lastYear - 2, "DevAV North", 3.485),
                new CompanySales(lastYear - 2, "DevAV Center", 3.088),
                new CompanySales(lastYear - 2, "DevAV South", 1.12),
                
                new CompanySales(lastYear - 1, "DevAV East", 0.51),
                new CompanySales(lastYear - 1, "DevAV West", 1.31),
                new CompanySales(lastYear - 1, "DevAV North", 3.747),
                new CompanySales(lastYear - 1, "DevAV Center", 3.357),
                new CompanySales(lastYear - 1, "DevAV South", 1.12),
                
                new CompanySales(lastYear, "DevAV East", 1.71),
                new CompanySales(lastYear, "DevAV West", 1.22),
                new CompanySales(lastYear, "DevAV North", 4.182),
                new CompanySales(lastYear, "DevAV Center", 3.725),
                new CompanySales(lastYear, "DevAV South", 1.111),
            };
        }
        public static List<RegionSales> GetSalesByLast10Years() {
            int lastYear = DateTime.Now.Year - 1;
            return new List<RegionSales>() {
                new RegionSales(lastYear - 10, "North America", 3.010E6),
                new RegionSales(lastYear - 10, "Europe", 3.032E6),
                new RegionSales(lastYear - 10, "Australia", 1.31E6),

                new RegionSales(lastYear - 9, "North America", 3.212E6),
                new RegionSales(lastYear - 9, "Europe", 3.050E6),
                new RegionSales(lastYear - 9, "Australia", 1.64E6),
            
                new RegionSales(lastYear - 8, "North America", 3.223E6),
                new RegionSales(lastYear - 8, "Europe", 3.054E6),
                new RegionSales(lastYear - 8, "Australia", 1.70E6),
            
                new RegionSales(lastYear - 7, "North America", 3.001E6),
                new RegionSales(lastYear - 7, "Europe", 2.775E6),
                new RegionSales(lastYear - 7, "Australia", 1.083E6),
            
                new RegionSales(lastYear - 6, "North America", 2.612E6),
                new RegionSales(lastYear - 6, "Europe", 2.066E6),
                new RegionSales(lastYear - 6, "Australia", 0.88E6),
            
                new RegionSales(lastYear - 5, "North America", 2.666E6),
                new RegionSales(lastYear - 5, "Europe", 2.078E6),
                new RegionSales(lastYear - 5, "Australia", 1.09E6),
            
                new RegionSales(lastYear - 4, "North America", 3.665E6),
                new RegionSales(lastYear - 4, "Europe", 3.888E6),
                new RegionSales(lastYear - 4, "Australia", 2.01E6),
            
                new RegionSales(lastYear - 3, "North America", 3.555E6),
                new RegionSales(lastYear - 3, "Europe", 3.008E6),
                new RegionSales(lastYear - 3, "Australia", 1.85E6),
            
                new RegionSales(lastYear - 2, "North America", 3.485E6),
                new RegionSales(lastYear - 2, "Europe", 3.088E6),
                new RegionSales(lastYear - 2, "Australia", 1.78E6),
            
                new RegionSales(lastYear - 1, "North America", 3.747E6),
                new RegionSales(lastYear - 1, "Europe", 3.357E6),
                new RegionSales(lastYear - 1, "Australia", 1.957E6),
            
                new RegionSales(lastYear, "North America", 4.182E6),
                new RegionSales(lastYear, "Europe", 3.725E6),
                new RegionSales(lastYear, "Australia", 2.272E6)
            };
        }
        public static List<VendorCosts> GetOutsideVendorCosts() {
            int lastYear = DateTime.Now.Year - 1;
            return new List<VendorCosts>() {
                new VendorCosts(new DateTime(lastYear - 6, 1, 1), "DevAV North", 362.5),
                new VendorCosts(new DateTime(lastYear - 5, 1, 1), "DevAV North", 348.4),
                new VendorCosts(new DateTime(lastYear - 4, 1, 1), "DevAV North", 279.0),
                new VendorCosts(new DateTime(lastYear - 3, 1, 1), "DevAV North", 230.9),
                new VendorCosts(new DateTime(lastYear - 2, 1, 1), "DevAV North", 203.5),
                new VendorCosts(new DateTime(lastYear - 1, 1, 1), "DevAV North", 197.1),
                new VendorCosts(new DateTime(lastYear - 6, 1, 1), "DevAV South", 277.0),
                new VendorCosts(new DateTime(lastYear - 5, 1, 1), "DevAV South", 328.5),
                new VendorCosts(new DateTime(lastYear - 4, 1, 1), "DevAV South", 297.0),
                new VendorCosts(new DateTime(lastYear - 3, 1, 1), "DevAV South", 255.3),
                new VendorCosts(new DateTime(lastYear - 2, 1, 1), "DevAV South", 173.5),
                new VendorCosts(new DateTime(lastYear - 1, 1, 1), "DevAV South", 131.8)
            };
        }

        static List<TotalSales> totalSales;
        public static List<TotalSales> GetTotalSales() {
            if (totalSales == null) {
                NonCryptographicRandom rnd = NonCryptographicRandom.Default;
                DateTime now = DateTime.Now;
                DateTime endDate = new DateTime(now.Year, now.Month, 1);
                List<TotalSales> items = new List<TotalSales>();
                foreach (string region in regions) {
                    double companyFactor = rnd.NextDouble() * 0.6 + 1;
                    foreach (string productCategory in CategorizedProducts.Keys) {
                        double categoryFactor = rnd.NextDouble() * 0.6 + 1;
                        foreach (string productName in CategorizedProducts[productCategory]) {
                            int maxSales = rnd.Next(60, 140);
                            for (int i = 0; i < 1000; i++) {
                                if (i % 100 == 0)
                                    maxSales = Math.Max(40, rnd.Next(maxSales - 20, maxSales + 20));
                                DateTime date = endDate.AddDays(-i - 1);
                                decimal sales = Convert.ToDecimal(rnd.Next(20, maxSales) * companyFactor * categoryFactor);
                                items.Add(TotalSales.CreateByNameProductCategoryRegionSales(date, productName, productCategory, region, sales));
                            }
                        }
                    }
                }
                totalSales = items;
            }
            return totalSales;
        }
    }
}
