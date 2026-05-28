using System;
using System.ComponentModel.DataAnnotations;

namespace DevExpress.Web.Demos.SpellChecker {
    public class Employee {
        public string Name { get; set; }
        public string Position { get; set; }
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string About { get; set; }
    }
}
