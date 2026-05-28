using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController: DemoController {
        public ActionResult CustomDictionary() {
            return DemoView("CustomDictionary", new MvcHtmlString(DefaultCustomDictionarySampleText));
        }
        public ActionResult CustomDictionarySpellCheckerPartial() {
            return PartialView("CustomDictionarySpellCheckerPartial");
        }

        public const string DefaultCustomDictionarySampleText = @"'What's going to be then, eh?' 
There was me, that is Alex, and my three droogs, that is Pete, Georgie, and Dim, Dim being really dim, and we sat in the Korova Milkbar making up rassoodocks what to do with the evening, a flip dark chill winter bastard through dry. The Korova Milkbar was a milk-plus mesto, and you may, O my brothers, have forgotten these mestos we like, things changing so skorry these days and everybody very quick to forget, newspapers not being read much neither.
(the beginning of A Clockwork Orange)";
    }
}
