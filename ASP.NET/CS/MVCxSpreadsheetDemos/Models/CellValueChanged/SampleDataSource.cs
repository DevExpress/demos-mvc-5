using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using DevExpress.Spreadsheet;
using DevExpress.Web.Office;
using DevExpress.XtraSpreadsheet;

namespace DevExpress.Web.Demos {
    public class Shipment {
        public const string DefaultEmptyValueString = "n/a";

        public string Id { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public double Weight { get; set; }
        public DateTime ShippingDate { get; set; }
        public DateTime DeliveryDate { get; set; }

        public Shipment() {
            Id = string.Empty;
            Sender = DefaultEmptyValueString;
            Recipient = DefaultEmptyValueString;
        }
        public Shipment(string id, string sender, string recipient, double weight, DateTime shippingDate, DateTime deliveryDate) {
            Id = id;
            Sender = sender;
            Recipient = recipient;
            Weight = weight;
            ShippingDate = shippingDate;
            DeliveryDate = deliveryDate;
        }
        bool IsEmpty() {
            return string.IsNullOrEmpty(Id);
        }
        public string GetShipmentWeight() {
            if (IsEmpty()) return DefaultEmptyValueString;
            return string.Format("{0} lbs ({1} kg)", Weight.ToString("0.00"), (0.45359237 * Weight).ToString("0.00"));
        }
        string FormatDate(DateTime date) {
            if (IsEmpty())
                return DefaultEmptyValueString;
            else
                return date.ToShortDateString();
        }
        public string GetShippingDate() {
            return FormatDate(ShippingDate);
        }
        public string GetDeliveryDate() {
            return FormatDate(DeliveryDate);
        }
    }
    public static class SampleDataSource {
        static List<Shipment> data;
        public static List<Shipment> Data {
            get {
                if (data == null)
                    data = GenerateSampleData();
                return data;
            }
        }

        static List<Shipment> GenerateSampleData() {
            data = new List<Shipment>();
            data.Add(new Shipment("P101406", "Quebec, CA", "Baltimore, MD, US", 6.8, new DateTime(2016, 10, 4), new DateTime(2016, 10, 13)));
            data.Add(new Shipment("P101201", "New Orleans, LA, US", "Los Angeles, CA, US", 2.3, new DateTime(2016, 10, 1), new DateTime(2016, 10, 3)));
            data.Add(new Shipment("P121203", "Pittsburgh, PA, US", "Edmonton, CA", 0.8, new DateTime(2016, 10, 8), new DateTime(2016, 10, 15)));
            data.Add(new Shipment("P207524", "Dallas, TX, US", "Barselona, ES", 5.1, new DateTime(2016, 10, 10), new DateTime(2016, 10, 23)));
            data.Add(new Shipment("P301189", "Rome, IT", "Los Angeles, CA, US", 4.5, new DateTime(2016, 10, 14), new DateTime(2016, 11, 1)));
            data.Add(new Shipment("P526101", "Ljubljana, SI", "Omaha, NE, US", 3.3, new DateTime(2016, 10, 18), new DateTime(2016, 11, 13)));

            return data;
        }

        public static Shipment Lookup(string key) {
            Shipment shipment = Data.Find(p => p.Id == key);
            if (shipment == null) shipment = new Shipment();
            return shipment;
        }
    }  
}
