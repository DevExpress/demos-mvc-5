using System.ComponentModel.DataAnnotations;

namespace DevExpress.Web.Demos {
    public enum FuelType { Petroleum, NaturalGas, Ethanol, Diesel }
    public class EditorTemplatesData {
        [Display(Name = "Car Model:")]
        [Required(ErrorMessage = "Car Model is required")]
        public string CarModel { get; set; }

        [Display(Name = "Price:")]
        [DisplayFormat(DataFormatString = "c")]
        [RegularExpression("(\\d)*", ErrorMessage = "Price must be a number")]
        [Range(500, 50000, ErrorMessage = "Must be between {1} <br /> and {2}")]
        public float? Price { get; set; }

        [Display(Name = "Fuel Type:")]
        [Required(ErrorMessage = "Type of fuel is required")]
        public FuelType? FuelType { get; set; }

        [UIHint("Mileage")]
        [Display(Name = "Mileage:")]
        [Range(10, 999, ErrorMessage = "Must be between {1} <br /> and {2}")]
        public float Mileage { get; set; }
    }
}
