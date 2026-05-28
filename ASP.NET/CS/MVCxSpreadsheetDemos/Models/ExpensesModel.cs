using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace DevExpress.Web.Demos {
    [XmlRoot("Expenses")]
    public class ExpensesReport {
        public ExpensesReport() {
            Info = new ExpensesInfo();
            Expenses = new List<Expense>();
        }

        [XmlElement]
        public ExpensesInfo Info { get; set; }
        [XmlElement("Expense")]
        public List<Expense> Expenses { get; set; }
    }

    public class ExpensesInfo {
        [XmlAttribute]
        public string Purpose { get; set; }
        [XmlAttribute]
        public int StatementNumber { get; set; }
        [XmlAttribute]
        public int EmployeeID { get; set; }
        [XmlAttribute]
        public string EmployeeName { get; set; }
        [XmlAttribute]
        public string EmployeePosition { get; set; }
        [XmlAttribute]
        public string SSN { get; set; }
        [XmlAttribute]
        public string EmployeeDepartment { get; set; }
        [XmlAttribute]
        public string Manager { get; set; }
    }

    public class Expense {
        [XmlAttribute(AttributeName = "Date")]
        public DateTime CreationDate { get; set; }
        [XmlAttribute]
        public int Account { get; set; }
        [XmlAttribute]
        public string Description { get; set; }
        [XmlAttribute]
        public double Hotel { get; set; }
        [XmlAttribute]
        public double Transport { get; set; }
        [XmlAttribute]
        public double Fuel { get; set; }
        [XmlAttribute]
        public double Meals { get; set; }
        [XmlAttribute]
        public double Phone { get; set; }
        [XmlAttribute]
        public double Misc { get; set; }
        [XmlAttribute]
        public double Entertainment { get; set; }
    }
}
