using System;
using System.ComponentModel.DataAnnotations;

namespace DevExpress.Web.Demos {
    public class FormLayoutAdaptiveLayout {    
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
    }
}
