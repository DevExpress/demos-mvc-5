using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DevExpress.Web.Demos {
    public class FormLayoutResponsiveLayout {    
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
