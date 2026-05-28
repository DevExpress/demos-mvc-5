using System.Web.Mvc;
using System;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController: DemoController {
        public ActionResult Container() {
            return DemoView("Container", CreateDefaultEmployee());
        }
        public ActionResult ContainerSpellCheckerPartial() {
            return PartialView("ContainerSpellCheckerPartial");
        }

        SpellChecker.Employee CreateDefaultEmployee() {
            return new SpellChecker.Employee {
                Name = "Nancy Davolio",
                Position = "Sales Reprseentative",
                BirthDate = new DateTime(1964, 12, 08),
                Address = "USA, Seattle, 507-20th Ave. E. Apt. 2A",
                About = @"Education includes a BA in psyhology from Colorado State Univercity in 1970. She also completed ""The Art of the Cold Call."" Nancy is a member of Toastmasters Internationa."
            };
        }
    }
}
