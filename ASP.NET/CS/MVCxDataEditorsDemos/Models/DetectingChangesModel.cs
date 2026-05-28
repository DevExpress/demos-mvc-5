using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class DetectingChangesModel {
        [Display(Name = "Text Box")]
        public string TextBoxValue { get; set; }

        [Display(Name = "Combo Box")]
        public string ComboBoxValue { get; set; }

        [Display(Name = "Date Edit")]
        public DateTime? DateEditValue { get; set; }

        [Display(Name = "Track Bar")]
        public Decimal? TrackBarValue { get; set; }
    }
}
