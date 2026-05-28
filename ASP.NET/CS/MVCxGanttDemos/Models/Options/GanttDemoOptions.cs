using DevExpress.Web.ASPxGantt;
using System;
using System.Collections.Generic;

namespace DevExpress.Web.Demos {
    public class GanttDemoOptions {
        public GanttDemoOptions() {
            ViewType = GanttViewType.Weeks;
            TitlePosition = GanttTaskTitlePosition.Inside;
            ToolbarAlignment = GanttToolbarAlignment.Left;
            ShowResources = true;
            ShowDependencies = true;
            AutoUpdateParentTasks = true;
            EnableDependencyValidation = true;
            ShowToolbar = true;
            CustomizeTaskTooltip = true;
            StartDateRange = new DateTime(DateTime.Now.Year, 2, 15);
            EndDateRange = new DateTime(DateTime.Now.Year, 7, 11);
        }
        public GanttViewType ViewType { get; set; }
        public GanttTaskTitlePosition TitlePosition { get; set; }
        public GanttToolbarAlignment ToolbarAlignment { get; set; }
        public bool ShowResources { get; set; }
        public bool ShowDependencies { get; set; }
        public bool AutoUpdateParentTasks { get; set; }
        public bool EnableDependencyValidation { get; set; }
        public bool ShowToolbar { get; set; }
        public bool CustomizeTaskTooltip { get; set; }

        public DateTime StartDateRange {get; set; }
        public DateTime EndDateRange {get; set; }

        static List<GanttViewType> availableViewTypes;
        static List<GanttTaskTitlePosition> availableTaskTitlePositions;
        public static List<GanttViewType> AvailableViewTypes {
            get {
                if(availableViewTypes == null)
                    availableViewTypes = new List<GanttViewType> {  GanttViewType.TenMinutes, GanttViewType.SixHours, GanttViewType.Hours, GanttViewType.Days, GanttViewType.Weeks, GanttViewType.Months };
                return availableViewTypes;
            }
        }
        public static List<GanttTaskTitlePosition> AvailableTaskTitlePositions {
            get {
                if(availableTaskTitlePositions == null)
                    availableTaskTitlePositions = new List<GanttTaskTitlePosition> { GanttTaskTitlePosition.Inside, GanttTaskTitlePosition.Outside, GanttTaskTitlePosition.None };
                return availableTaskTitlePositions;
            }
        }
        public static List<GanttViewType> AvailableWorkTimeViewTypes {
            get { return  new List<GanttViewType> {  GanttViewType.Hours, GanttViewType.SixHours, GanttViewType.Days }; }
        }
        public static List<GanttToolbarAlignment> AvailableToolbarAlignmentTypes {
            get { return new List<GanttToolbarAlignment> { GanttToolbarAlignment.Left, GanttToolbarAlignment.Justify, GanttToolbarAlignment.Right }; }
        }
    }
}
