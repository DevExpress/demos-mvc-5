using System.ComponentModel.DataAnnotations;

namespace DevExpress.Web.Demos {
    public class FormLayoutOverviewModel {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Other Notes")]
        public string Note { get; set; }

        public static FormLayoutOverviewModel CreateDefaultModel() {
            FormLayoutOverviewModel model = new FormLayoutOverviewModel();
            model.FirstName = "Nancy";
            model.LastName = "Davolio";
            model.Note = "Education includes a BA in psychology from Colorado State University in 1970. She also completed 'The Art of the Cold Call.' Nancy is a member of Toastmasters International.";
            return model;
        }
    }
}
