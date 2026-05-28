using System;
using System.Threading;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RatingControlController : DemoController {
        [HttpGet]
        public ActionResult Voting() {
            VotingDemoHelper.VotingValues.Clear();
            VotingDemoHelper.VotingValues.AddRange(VotingDemoHelper.InitialVotingValues);
            Session["FillPrecision"] = RatingControlItemFillPrecision.Half;
            return DemoView("Voting", VotingDemoHelper.GetRating());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Voting(RatingControlItemFillPrecision fillPrecision) {
            Session["FillPrecision"] = fillPrecision;
            return DemoView("Voting", VotingDemoHelper.GetRating());
        }
        public ActionResult UpdateRating(string value) {
            // Intentionally pauses server-side processing, 
            // to demonstrate the Rating Control functionality.
            Thread.Sleep(1000);
            int votingValue = (int)Decimal.Parse(value);
            if(votingValue > 0) {
                int maxVotesCount = VotingDemoHelper.InitialVotingValues.Count + 1;
                if(VotingDemoHelper.VotingValues.Count == maxVotesCount)
                    VotingDemoHelper.VotingValues[maxVotesCount - 1] = votingValue;
                else
                    VotingDemoHelper.VotingValues.Add(votingValue);
            }
            return Content(string.Format("{0} {1} {1:0.##}", VotingDemoHelper.VotingValues.Count, VotingDemoHelper.GetRating()));
        }
    }
}
