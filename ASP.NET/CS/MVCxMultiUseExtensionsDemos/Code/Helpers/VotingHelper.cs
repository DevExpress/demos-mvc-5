using System.Collections.Generic;

namespace DevExpress.Web.Demos {
    public class VotingDemoHelper {
        static List<int> votingValues = new List<int>();
        public static readonly List<int> InitialVotingValues = new List<int> { 5, 4, 3, 2, 4, 3, 5, 3 };
        public static List<int> VotingValues { get { return votingValues; } }

        public static decimal GetRating() {
            decimal sum = 0;
            foreach(int value in VotingValues)
                sum += value;
            return sum / VotingValues.Count;
        }
    }
}
