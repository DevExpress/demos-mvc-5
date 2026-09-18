using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos.Charts {
    public static class SourceOfEnergy {
        public const string EuropeBrent = "Europe Brent";
        public const string OKWTI = "OK WTI";

        public class CoalProduction {
            DateTime date;
            double southAfrica;
            double poland;
            double australia;

            public DateTime Date { get { return date; } }
            public double SouthAfrica { get { return southAfrica; } }
            public double Poland { get { return poland; } }
            public double Australia { get { return australia; } }

            public CoalProduction(DateTime date, double southAfrica, double poland, double australia) {
                this.date = date;
                this.southAfrica = southAfrica;
                this.poland = poland;
                this.australia = australia;
            }
        }
        public class GasolinePrice {
            DateTime date;
            double price;

            public DateTime Date { get { return date; } }
            public double Price { get { return price; } }

            public GasolinePrice(DateTime date, double price) {
                this.date = date;
                this.price = price;
            }
        }
        public class OilPrice {
            string name;
            DateTime date;
            double min, max;

            public string Name { get { return name; } }
            public DateTime Date { get { return date; } }
            public double Min { get { return min; } }
            public double Max { get { return max; } }

            public OilPrice(string name, DateTime date, double min, double max) {
                this.name = name;
                this.date = date;
                this.min = min;
                this.max = max;
            }
        }
        public static List<CoalProduction> GetCoalProduction() {
            return new List<CoalProduction>(){
                new CoalProduction(new DateTime(2015, 12, 31, 0, 0, 0), 252.099, 135.523, 446.320),
                new CoalProduction(new DateTime(2014, 12, 31, 0, 0, 0), 261.523, 137.148, 442.230),
                new CoalProduction(new DateTime(2013, 12, 31, 0, 0, 0), 256.562, 142.906, 421.110),
                new CoalProduction(new DateTime(2012, 12, 31, 0, 0, 0), 258.575, 144.093, 385.200),
                new CoalProduction(new DateTime(2011, 12, 31, 0, 0, 0), 252.756, 139.289, 368.100),
                new CoalProduction(new DateTime(2010, 12, 31, 0, 0, 0), 254.521, 133.238, 382.430),
                new CoalProduction(new DateTime(2009, 12, 31, 0, 0, 0), 247.820, 135.172, 362.800),
                new CoalProduction(new DateTime(2008, 12, 31, 0, 0, 0), 252.213, 144.013, 355.610),
                new CoalProduction(new DateTime(2007, 12, 31, 0, 0, 0), 247.666, 145.850, 345.900),
                new CoalProduction(new DateTime(2006, 12, 31, 0, 0, 0), 244.774, 156.065, 335.800),
                new CoalProduction(new DateTime(2005, 12, 31, 0, 0, 0), 244.985, 159.540, 321.400),
                new CoalProduction(new DateTime(2004, 12, 31, 0, 0, 0), 242.821, 161.284, 308.200),
                new CoalProduction(new DateTime(2003, 12, 31, 0, 0, 0), 238.751, 163.790, 292.800),
                new CoalProduction(new DateTime(2002, 12, 31, 0, 0, 0), 220.212, 161.920, 281.300),
                new CoalProduction(new DateTime(2001, 12, 31, 0, 0, 0), 223.560, 163.540, 271.900),
                new CoalProduction(new DateTime(2000, 12, 31, 0, 0, 0), 224.199, 162.820, 245.500),
                new CoalProduction(new DateTime(1999, 12, 31, 0, 0, 0), 223.514, 172.730, 238.100),
                new CoalProduction(new DateTime(1998, 12, 31, 0, 0, 0), 222.976, 178.550, 226.400),
                new CoalProduction(new DateTime(1997, 12, 31, 0, 0, 0), 220.072, 200.930, 217.100),
                new CoalProduction(new DateTime(1996, 12, 31, 0, 0, 0), 206.362, 201.720, 201.300),
                new CoalProduction(new DateTime(1995, 12, 31, 0, 0, 0), 206.210, 200.720, 194.800),
                new CoalProduction(new DateTime(1994, 12, 31, 0, 0, 0), 195.805, 200.700, 180.200),
                new CoalProduction(new DateTime(1993, 12, 31, 0, 0, 0), 188.214, 198.580, 180.800),
                new CoalProduction(new DateTime(1992, 12, 31, 0, 0, 0), 184.045, 198.380, 182.300),
                new CoalProduction(new DateTime(1991, 12, 31, 0, 0, 0), 178.390, 209.790, 172.600),
                new CoalProduction(new DateTime(1990, 12, 31, 0, 0, 0), 174.780, 215.320, 166.800)
            };
        }

        public static List<GasolinePrice> GetGasolinePrices() {
            return new List<GasolinePrice>() {
                new GasolinePrice(new DateTime(2015, 01, 1), 2.208),
                new GasolinePrice(new DateTime(2015, 02, 1), 2.301),
                new GasolinePrice(new DateTime(2015, 03, 1), 2.546),
                new GasolinePrice(new DateTime(2015, 04, 1), 2.555),
                new GasolinePrice(new DateTime(2015, 05, 1), 2.802),
                new GasolinePrice(new DateTime(2015, 06, 1), 2.885),
                new GasolinePrice(new DateTime(2015, 07, 1), 2.880),
                new GasolinePrice(new DateTime(2015, 08, 1), 2.726),
                new GasolinePrice(new DateTime(2015, 09, 1), 2.462),
                new GasolinePrice(new DateTime(2015, 10, 1), 2.387),
                new GasolinePrice(new DateTime(2015, 11, 1), 2.260),
                new GasolinePrice(new DateTime(2015, 12, 1), 2.144)
            };
        }
        public static List<OilPrice> GetEuropeBrentPrices() {
            return new List<OilPrice>() {
                new OilPrice(EuropeBrent, new DateTime(2015, 01, 1), 45.13, 55.38),
                new OilPrice(EuropeBrent, new DateTime(2015, 02, 1), 51.74, 61.89),
                new OilPrice(EuropeBrent, new DateTime(2015, 03, 1), 52.00, 61.18),
                new OilPrice(EuropeBrent, new DateTime(2015, 04, 1), 55.73, 63.97),
                new OilPrice(EuropeBrent, new DateTime(2015, 05, 1), 60.12, 66.33),
                new OilPrice(EuropeBrent, new DateTime(2015, 06, 1), 59.03, 64.68),
                new OilPrice(EuropeBrent, new DateTime(2015, 07, 1), 53.29, 61.73),
                new OilPrice(EuropeBrent, new DateTime(2015, 08, 1), 41.59, 49.49),
                new OilPrice(EuropeBrent, new DateTime(2015, 09, 1), 45.87, 50.41),
                new OilPrice(EuropeBrent, new DateTime(2015, 10, 1), 45.54, 52.13),
                new OilPrice(EuropeBrent, new DateTime(2015, 11, 1), 40.28, 48.00),
                new OilPrice(EuropeBrent, new DateTime(2015, 12, 1), 35.26, 42.97)
            };
        }
        public static List<OilPrice> GetOkWtiPrices() {
            return new List<OilPrice> {
                new OilPrice(OKWTI, new DateTime(2015, 01, 1), 44.08, 52.72),
                new OilPrice(OKWTI, new DateTime(2015, 02, 1), 47.65, 49.84),
                new OilPrice(OKWTI, new DateTime(2015, 03, 1), 43.39, 51.53),
                new OilPrice(OKWTI, new DateTime(2015, 04, 1), 49.13, 59.62),
                new OilPrice(OKWTI, new DateTime(2015, 05, 1), 57.29, 60.93),
                new OilPrice(OKWTI, new DateTime(2015, 06, 1), 58.00, 61.36),
                new OilPrice(OKWTI, new DateTime(2015, 07, 1), 47.11, 56.94),
                new OilPrice(OKWTI, new DateTime(2015, 08, 1), 38.22, 49.20),
                new OilPrice(OKWTI, new DateTime(2015, 09, 1), 44.07, 47.12),
                new OilPrice(OKWTI, new DateTime(2015, 10, 1), 43.19, 49.67),
                new OilPrice(OKWTI, new DateTime(2015, 11, 1), 39.27, 47.88),
                new OilPrice(OKWTI, new DateTime(2015, 12, 1), 34.55, 41.08)
            };            
        }
        public static List<OilPrice> GetOilPrices() {
            List<OilPrice> result = new List<OilPrice>();
            result.AddRange(GetEuropeBrentPrices());
            result.AddRange(GetOkWtiPrices());
            return result;
        }
    }
}
