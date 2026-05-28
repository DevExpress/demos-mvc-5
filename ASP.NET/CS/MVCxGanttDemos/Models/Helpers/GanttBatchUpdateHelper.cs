using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

public static class GanttBatchUpdateHelper {
    public static void Update(
        MVCxGanttTaskUpdateValues<Task, string> taskUpdateValues,
        MVCxGanttDependencyUpdateValues<Dependency, string> dependencyUpdateValues,
        MVCxGanttResourceUpdateValues<Resource, string> resourceUpdateValues,
        MVCxGanttResourceAssignmentUpdateValues<ResourceAssignment, string> resourceAssignmentUpdateValues) {
        ProcessTaskValues(taskUpdateValues);
        ProcessDependencyValues(dependencyUpdateValues);
        ProcessResourceValues(resourceUpdateValues);
        ProcessResourceAssignmentValues(resourceAssignmentUpdateValues);
    }
    public static void ProcessTaskValues(MVCxGanttTaskUpdateValues<Task, string> taskUpdateValues) {
        foreach(var item in taskUpdateValues.Update) {
            if(IsTaskUpdateAllowed(item))
                GanttDataProvider.UpdateTask(item);
        }
        foreach(var itemKey in taskUpdateValues.DeleteKeys) {
            if(IsTaskDeleteAllowed(itemKey))
                GanttDataProvider.DeleteTaskByKey(itemKey);
        }
        foreach(var item in taskUpdateValues.Insert) {
            if(IsTaskInsertAllowed(item))
                taskUpdateValues.MapInsertedItemKey(item, GanttDataProvider.InsertTask(item));
        }
    }

    public static void ProcessDependencyValues(MVCxGanttDependencyUpdateValues<Dependency, string> dependencyUpdateValues) {
        foreach(var itemKey in dependencyUpdateValues.DeleteKeys) {
            if(IsDependencyDeleteAllowed(itemKey))
                GanttDataProvider.DeleteDependencyByKey(itemKey);
        }
        foreach(var item in dependencyUpdateValues.Insert) {
            if(IsDependencyInsertAllowed(item))
                dependencyUpdateValues.MapInsertedItemKey(item, GanttDataProvider.InsertDependency(item));
        }
    }

    public static void ProcessResourceValues(MVCxGanttResourceUpdateValues<Resource, string> resourceUpdateValues) {
        foreach(var item in resourceUpdateValues.Update) {
            if(IsResourceUpdateAllowed(item))
                GanttDataProvider.UpdateResource(item);
        }
        foreach(var itemKey in resourceUpdateValues.DeleteKeys) {
            if(IsResourceDeleteAllowed(itemKey))
                GanttDataProvider.DeleteResourceByKey(itemKey);
        }
        foreach(var item in resourceUpdateValues.Insert) {
            if(IsResourceInsertAllowed(item))
                resourceUpdateValues.MapInsertedItemKey(item, GanttDataProvider.InsertResource(item));
        }
    }
    public static void ProcessResourceAssignmentValues(MVCxGanttResourceAssignmentUpdateValues<ResourceAssignment, string> resourceAssignmentUpdateValues) {
        foreach(var itemKey in resourceAssignmentUpdateValues.DeleteKeys) {
            if(IsResourceAssignmentDeleteAllowed(itemKey))
                GanttDataProvider.DeleteResourceAssignmentByKey(itemKey);
        }
        foreach(var item in resourceAssignmentUpdateValues.Insert) {
            if(IsResourceAssignmentInsertAllowed(item))
                resourceAssignmentUpdateValues.MapInsertedItemKey(item, GanttDataProvider.InsertResourceAssignment(item));
        }
    }

    static bool IsTaskInsertAllowed(Task item) {
        // Implement server-side validation here
        return true;
    }
    static bool IsTaskUpdateAllowed(Task item) {
        // Implement server-side validation here
        return true;
    }
    static bool IsTaskDeleteAllowed(string itemKey) {
        // Implement server-side validation here
        return true;
    }

    static bool IsResourceInsertAllowed(Resource item) {
        // Implement server-side validation here
        return true;
    }
    static bool IsResourceUpdateAllowed(Resource item) {
        // Implement server-side validation here
        return true;
    }
    static bool IsResourceDeleteAllowed(string itemKey) {
        // Implement server-side validation here
        return true;
    }

    static bool IsDependencyInsertAllowed(Dependency item) {
        // Implement server-side validation here
        return true;
    }
    static bool IsDependencyDeleteAllowed(string itemKey) {
        // Implement server-side validation here
        return true;
    }

    static bool IsResourceAssignmentInsertAllowed(ResourceAssignment item) {
        // Implement server-side validation here
        return true;
    }
    static bool IsResourceAssignmentDeleteAllowed(string itemKey) {
        // Implement server-side validation here
        return true;
    }
}
