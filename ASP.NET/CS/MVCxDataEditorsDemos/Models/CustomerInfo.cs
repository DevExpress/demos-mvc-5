using System;
using System.ComponentModel.DataAnnotations;

namespace DevExpress.Web.Demos {
    public class CustomerInfo {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Birthday is required")]
        public DateTime Birthday { get; set; }
        [Required(ErrorMessage = "Occupation is required")]
        public int? Occupation { get; set; }
        public Gender? Gender { get; set; }
        [Required(ErrorMessage = "You need to agree to proceed")]
        public bool Accepted { get; set; }
    }
}
