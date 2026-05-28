using System;
using System.Collections.Generic;

namespace DevExpress.Web.Demos.Charts {
    public class BubbleDataItem {
        DateTime year;
        double budget;
        double grosses;
        string title;

        public DateTime Year { get { return year; } }
        public double Budget { get { return budget; } }
        public double Grosses { get { return grosses; } }
        public string Title { get { return title; } }

        public BubbleDataItem(DateTime year, double budget, double grosses, string title) {
            this.year = year;
            this.budget = budget;
            this.grosses = grosses;
            this.title = title;
        }
    }

    public static class BubbleData {
        public static List<BubbleDataItem> GetData() {
            return new List<BubbleDataItem>() {
                new BubbleDataItem(new DateTime(2007, 1, 1), 300, 0.963, "Pirates of the Caribbean: At World's End"),
                new BubbleDataItem(new DateTime(2008, 1, 1), 185, 1.004, "The Dark Knight"),
                new BubbleDataItem(new DateTime(2009, 1, 1), 237, 2.788, "Avatar"),
                new BubbleDataItem(new DateTime(2010, 1, 1), 200, 1.067, "Toy Story 3"),
                new BubbleDataItem(new DateTime(2011, 1, 1), 250, 1.341, "Harry Potter and the Deathly Hallows Part 2"),
                new BubbleDataItem(new DateTime(2012, 1, 1), 220, 1.519, "Marvel's The Avengers"),
                new BubbleDataItem(new DateTime(2013, 1, 1), 150, 1.276, "Frozen"),
                new BubbleDataItem(new DateTime(2014, 1, 1), 210, 1.104, "Transformers: Age of Extinction"),
                new BubbleDataItem(new DateTime(2015, 1, 1), 245, 2.068, "Star Wars: The Force Awakens"),
                new BubbleDataItem(new DateTime(2016, 1, 1), 250, 1.153, "Captain America: Civil War"),
            };
        }
    }
}
