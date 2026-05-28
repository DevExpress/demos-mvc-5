using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

public static class GanttDataProvider {
    const string
        TasksSessionName = "Tasks",
        DependenciesSessionName = "Dependencies",
        ResourcesSessionName = "Resources",
        ResourceAssignmentsSessionName = "ResourceAssignments";

    static HttpSessionState Session { get { return HttpContext.Current.Session; } }

    public static object GetTasks() { return Tasks; }
    public static object GetDependencies() { return Dependencies; }
    public static object GetResources() { return Resources; }
    public static object GetResourceAssignments() { return ResourceAssignments; }

    public static List<Task> Tasks {
        get {
            if(Session[TasksSessionName] == null)
                Session[TasksSessionName] = CreateTasks();
            return (List<Task>)Session[TasksSessionName];
        }
    }
    public static List<Dependency> Dependencies {
        get {
            if(Session[DependenciesSessionName] == null)
                Session[DependenciesSessionName] = CreateDependencies();
            return (List<Dependency>)Session[DependenciesSessionName];
        }
    }
    public static List<Resource> Resources {
        get {
            if(Session[ResourcesSessionName] == null)
                Session[ResourcesSessionName] = CreateResources();
            return (List<Resource>)Session[ResourcesSessionName];
        }
    }
    public static List<ResourceAssignment> ResourceAssignments {
        get {
            if(Session[ResourceAssignmentsSessionName] == null)
                Session[ResourceAssignmentsSessionName] = CreateResourceAssignments();
            return (List<ResourceAssignment>)Session[ResourceAssignmentsSessionName];
        }
    }

    static List<Task> CreateTasks() {
        var result = new List<Task>();
        int year = DateTime.Now.Year;
        result.Add(CreateTask("0", "", "Software Development", new DateTime(year, 2, 21, 8, 0, 0), new DateTime(year, 7, 4, 15, 0, 0), 31, ""));
        result.Add(CreateTask("1", "0", "Scope", new DateTime(year, 2, 21, 8, 0, 0), new DateTime(year, 2, 26, 12, 0, 0), 60, ""));
        result.Add(CreateTask("2", "1", "Determine project scope", new DateTime(year, 2, 21, 8, 0, 0), new DateTime(year, 2, 21, 12, 0, 0), 100, "1"));
        result.Add(CreateTask("3", "1", "Secure project sponsorship", new DateTime(year, 2, 21, 13, 0, 0), new DateTime(year, 2, 22, 12, 0, 0), 100, "1"));
        result.Add(CreateTask("4", "1", "Define preliminary resources", new DateTime(year, 2, 22, 13, 0, 0), new DateTime(year, 2, 25, 12, 0, 0), 60, "2"));
        result.Add(CreateTask("5", "1", "Secure core resources", new DateTime(year, 2, 25, 13, 0, 0), new DateTime(year, 2, 26, 12, 0, 0), 0, "2"));
        result.Add(CreateTask("6", "1", "Scope complete", new DateTime(year, 2, 26, 12, 0, 0), new DateTime(year, 2, 26, 12, 0, 0), 0, ""));
        result.Add(CreateTask("7", "0", "Analysis/Software Requirements", new DateTime(year, 2, 26, 13, 0, 0), new DateTime(year, 3, 18, 12, 0, 0), 80, ""));
        result.Add(CreateTask("8", "7", "Conduct needs analysis", new DateTime(year, 2, 26, 13, 0, 0), new DateTime(year, 3, 5, 12, 0, 0), 100, "3"));
        result.Add(CreateTask("9", "7", "Draft preliminary software specifications", new DateTime(year, 3, 5, 13, 0, 0), new DateTime(year, 3, 8, 12, 0, 0), 100, "3"));
        result.Add(CreateTask("10", "7", "Develop preliminary budget", new DateTime(year, 3, 8, 13, 0, 0), new DateTime(year, 3, 12, 12, 0, 0), 100, "2"));
        result.Add(CreateTask("11", "7", "Review software specifications/budget with team", new DateTime(year, 3, 12, 13, 0, 0), new DateTime(year, 3, 12, 17, 0, 0), 100, "2,3"));
        result.Add(CreateTask("12", "7", "Incorporate feedback on software specifications", new DateTime(year, 3, 13, 8, 0, 0), new DateTime(year, 3, 13, 17, 0, 0), 70, "3"));
        result.Add(CreateTask("13", "7", "Develop delivery timeline", new DateTime(year, 3, 14, 8, 0, 0), new DateTime(year, 3, 14, 17, 0, 0), 0, "2"));
        result.Add(CreateTask("14", "7", "Obtain approvals to proceed (concept, timeline, budget)", new DateTime(year, 3, 15, 8, 0, 0), new DateTime(year, 3, 15, 12, 0, 0), 0, "1,2"));
        result.Add(CreateTask("15", "7", "Secure required resources", new DateTime(year, 3, 15, 13, 0, 0), new DateTime(year, 3, 18, 12, 0, 0), 0, "2"));
        result.Add(CreateTask("16", "7", "Analysis complete", new DateTime(year, 3, 18, 12, 0, 0), new DateTime(year, 3, 18, 12, 0, 0), 0, ""));
        result.Add(CreateTask("17", "0", "Design", new DateTime(year, 3, 18, 13, 0, 0), new DateTime(year, 4, 5, 17, 0, 0), 80, ""));
        result.Add(CreateTask("18", "17", "Review preliminary software specifications", new DateTime(year, 3, 18, 13, 0, 0), new DateTime(year, 3, 20, 12, 0, 0), 100, "3"));
        result.Add(CreateTask("19", "17", "Develop functional specifications", new DateTime(year, 3, 20, 13, 0, 0), new DateTime(year, 3, 27, 12, 0, 0), 100, "3"));
        result.Add(CreateTask("20", "17", "Develop prototype based on functional specifications", new DateTime(year, 3, 27, 13, 0, 0), new DateTime(year, 4, 2, 12, 0, 0), 100, "3"));
        result.Add(CreateTask("21", "17", "Review functional specifications", new DateTime(year, 4, 2, 13, 0, 0), new DateTime(year, 4, 4, 12, 0, 0), 30, "1"));
        result.Add(CreateTask("22", "17", "Incorporate feedback into functional specifications", new DateTime(year, 4, 4, 13, 0, 0), new DateTime(year, 4, 5, 12, 0, 0), 0, "1"));
        result.Add(CreateTask("23", "17", "Obtain approval to proceed", new DateTime(year, 4, 5, 13, 0, 0), new DateTime(year, 4, 5, 17, 0, 0), 0, "1,2"));
        result.Add(CreateTask("24", "17", "Design complete", new DateTime(year, 4, 5, 17, 0, 0), new DateTime(year, 4, 5, 17, 0, 0), 0, ""));
        result.Add(CreateTask("25", "0", "Development", new DateTime(year, 4, 8, 8, 0, 0), new DateTime(year, 5, 7, 15, 0, 0), 42, ""));
        result.Add(CreateTask("26", "25", "Review functional specifications", new DateTime(year, 4, 8, 8, 0, 0), new DateTime(year, 4, 8, 17, 0, 0), 100, "4"));
        result.Add(CreateTask("27", "25", "Identify modular/tiered design parameters", new DateTime(year, 4, 9, 8, 0, 0), new DateTime(year, 4, 9, 17, 0, 0), 100, "4"));
        result.Add(CreateTask("28", "25", "Assign development staff", new DateTime(year, 4, 10, 8, 0, 0), new DateTime(year, 4, 10, 17, 0, 0), 100, "4"));
        result.Add(CreateTask("29", "25", "Develop code", new DateTime(year, 4, 11, 8, 0, 0), new DateTime(year, 5, 1, 17, 0, 0), 49, "4"));
        result.Add(CreateTask("30", "25", "Developer testing (primary debugging)", new DateTime(year, 4, 16, 15, 0, 0), new DateTime(year, 5, 7, 15, 0, 0), 24, "4"));
        result.Add(CreateTask("31", "25", "Development complete", new DateTime(year, 5, 7, 15, 0, 0), new DateTime(year, 5, 7, 15, 0, 0), 0, ""));
        result.Add(CreateTask("32", "0", "Testing", new DateTime(year, 4, 8, 8, 0, 0), new DateTime(year, 6, 13, 15, 0, 0), 23, ""));
        result.Add(CreateTask("33", "32", "Develop unit test plans using product specifications", new DateTime(year, 4, 8, 8, 0, 0), new DateTime(year, 4, 11, 17, 0, 0), 100, "5"));
        result.Add(CreateTask("34", "32", "Develop integration test plans using product specifications", new DateTime(year, 4, 8, 8, 0, 0), new DateTime(year, 4, 11, 17, 0, 0), 100, "5"));
        result.Add(CreateTask("35", "32", "Unit Testing", new DateTime(year, 5, 7, 15, 0, 0), new DateTime(year, 5, 28, 15, 0, 0), 0, ""));
        result.Add(CreateTask("36", "35", "Review modular code", new DateTime(year, 5, 7, 15, 0, 0), new DateTime(year, 5, 14, 15, 0, 0), 0, "5"));
        result.Add(CreateTask("37", "35", "Test component modules to product specifications", new DateTime(year, 5, 14, 15, 0, 0), new DateTime(year, 5, 16, 15, 0, 0), 0, "5"));
        result.Add(CreateTask("38", "35", "Identify anomalies to product specifications", new DateTime(year, 5, 16, 15, 0, 0), new DateTime(year, 5, 21, 15, 0, 0), 0, "5"));
        result.Add(CreateTask("39", "35", "Modify code", new DateTime(year, 5, 21, 15, 0, 0), new DateTime(year, 5, 24, 15, 0, 0), 0, "5"));
        result.Add(CreateTask("40", "35", "Re-test modified code", new DateTime(year, 5, 24, 15, 0, 0), new DateTime(year, 5, 28, 15, 0, 0), 0, "5"));
        result.Add(CreateTask("41", "35", "Unit testing complete", new DateTime(year, 5, 28, 15, 0, 0), new DateTime(year, 5, 28, 15, 0, 0), 0, ""));
        result.Add(CreateTask("42", "32", "Integration Testing", new DateTime(year, 5, 28, 15, 0, 0), new DateTime(year, 6, 13, 15, 0, 0), 0, ""));
        result.Add(CreateTask("43", "42", "Test module integration", new DateTime(year, 5, 28, 15, 0, 0), new DateTime(year, 6, 4, 15, 0, 0), 0, "5"));
        result.Add(CreateTask("44", "42", "Identify anomalies to specifications", new DateTime(year, 6, 4, 15, 0, 0), new DateTime(year, 6, 6, 15, 0, 0), 0, "5"));
        result.Add(CreateTask("45", "42", "Modify code", new DateTime(year, 6, 6, 15, 0, 0), new DateTime(year, 6, 11, 15, 0, 0), 0, "5"));
        result.Add(CreateTask("46", "42", "Re-test modified code", new DateTime(year, 6, 11, 15, 0, 0), new DateTime(year, 6, 13, 15, 0, 0), 0, "5"));
        result.Add(CreateTask("47", "42", "Integration testing complete", new DateTime(year, 6, 13, 15, 0, 0), new DateTime(year, 6, 13, 15, 0, 0), 0, ""));
        result.Add(CreateTask("48", "0", "Training", new DateTime(year, 4, 8, 8, 0, 0), new DateTime(year, 6, 10, 15, 0, 0), 25, ""));
        result.Add(CreateTask("49", "48", "Develop training specifications for end users", new DateTime(year, 4, 8, 8, 0, 0), new DateTime(year, 4, 10, 17, 0, 0), 100, "6"));
        result.Add(CreateTask("50", "48", "Develop training specifications for helpdesk support staff", new DateTime(year, 4, 8, 8, 0, 0), new DateTime(year, 4, 10, 17, 0, 0), 100, "6"));
        result.Add(CreateTask("51", "48", "Identify training delivery methodology (computer based training, classroom, etc.)", new DateTime(year, 4, 8, 8, 0, 0), new DateTime(year, 4, 9, 17, 0, 0), 100, "6"));
        result.Add(CreateTask("52", "48", "Develop training materials", new DateTime(year, 5, 7, 15, 0, 0), new DateTime(year, 5, 28, 15, 0, 0), 0, "6"));
        result.Add(CreateTask("53", "48", "Conduct training usability study", new DateTime(year, 5, 28, 15, 0, 0), new DateTime(year, 6, 3, 15, 0, 0), 0, "6"));
        result.Add(CreateTask("54", "48", "Finalize training materials", new DateTime(year, 6, 3, 15, 0, 0), new DateTime(year, 6, 6, 15, 0, 0), 0, "6"));
        result.Add(CreateTask("55", "48", "Develop training delivery mechanism", new DateTime(year, 6, 6, 15, 0, 0), new DateTime(year, 6, 10, 15, 0, 0), 0, "6"));
        result.Add(CreateTask("56", "48", "Training materials complete", new DateTime(year, 6, 10, 15, 0, 0), new DateTime(year, 6, 10, 15, 0, 0), 0, ""));
        result.Add(CreateTask("57", "0", "Documentation", new DateTime(year, 4, 8, 8, 0, 0), new DateTime(year, 5, 20, 12, 0, 0), 0, ""));
        result.Add(CreateTask("58", "57", "Develop Help specification", new DateTime(year, 4, 8, 8, 0, 0), new DateTime(year, 4, 8, 17, 0, 0), 80, "7"));
        result.Add(CreateTask("59", "57", "Develop Help system", new DateTime(year, 4, 22, 13, 0, 0), new DateTime(year, 5, 13, 12, 0, 0), 0, "7"));
        result.Add(CreateTask("60", "57", "Review Help documentation", new DateTime(year, 5, 13, 13, 0, 0), new DateTime(year, 5, 16, 12, 0, 0), 0, "7"));
        result.Add(CreateTask("61", "57", "Incorporate Help documentation feedback", new DateTime(year, 5, 16, 13, 0, 0), new DateTime(year, 5, 20, 12, 0, 0), 0, "7"));
        result.Add(CreateTask("62", "57", "Develop user manuals specifications", new DateTime(year, 4, 8, 8, 0, 0), new DateTime(year, 4, 9, 17, 0, 0), 65, "7"));
        result.Add(CreateTask("63", "57", "Develop user manuals", new DateTime(year, 4, 22, 13, 0, 0), new DateTime(year, 5, 13, 12, 0, 0), 0, "7"));
        result.Add(CreateTask("64", "57", "Review all user documentation", new DateTime(year, 5, 13, 13, 0, 0), new DateTime(year, 5, 15, 12, 0, 0), 0, "7"));
        result.Add(CreateTask("65", "57", "Incorporate user documentation feedback", new DateTime(year, 5, 15, 13, 0, 0), new DateTime(year, 5, 17, 12, 0, 0), 0, "7"));
        result.Add(CreateTask("66", "57", "Documentation complete", new DateTime(year, 5, 20, 12, 0, 0), new DateTime(year, 5, 20, 12, 0, 0), 0, ""));
        result.Add(CreateTask("67", "0", "Pilot", new DateTime(year, 3, 18, 13, 0, 0), new DateTime(year, 6, 24, 15, 0, 0), 22, ""));
        result.Add(CreateTask("68", "67", "Identify test group", new DateTime(year, 3, 18, 13, 0, 0), new DateTime(year, 3, 19, 12, 0, 0), 100, "2"));
        result.Add(CreateTask("69", "67", "Develop software delivery mechanism", new DateTime(year, 3, 19, 13, 0, 0), new DateTime(year, 3, 20, 12, 0, 0), 100, ""));
        result.Add(CreateTask("70", "67", "Install/deploy software", new DateTime(year, 6, 13, 15, 0, 0), new DateTime(year, 6, 14, 15, 0, 0), 0, "8"));
        result.Add(CreateTask("71", "67", "Obtain user feedback", new DateTime(year, 6, 14, 15, 0, 0), new DateTime(year, 6, 21, 15, 0, 0), 0, "8"));
        result.Add(CreateTask("72", "67", "Evaluate testing information", new DateTime(year, 6, 21, 15, 0, 0), new DateTime(year, 6, 24, 15, 0, 0), 0, "8"));
        result.Add(CreateTask("73", "67", "Pilot complete", new DateTime(year, 6, 24, 15, 0, 0), new DateTime(year, 6, 24, 15, 0, 0), 0, ""));
        result.Add(CreateTask("74", "0", "Deployment", new DateTime(year, 6, 24, 15, 0, 0), new DateTime(year, 7, 1, 15, 0, 0), 0, ""));
        result.Add(CreateTask("75", "74", "Determine final deployment strategy", new DateTime(year, 6, 24, 15, 0, 0), new DateTime(year, 6, 25, 15, 0, 0), 0, "8"));
        result.Add(CreateTask("76", "74", "Develop deployment methodology", new DateTime(year, 6, 25, 15, 0, 0), new DateTime(year, 6, 26, 15, 0, 0), 0, "8"));
        result.Add(CreateTask("77", "74", "Secure deployment resources", new DateTime(year, 6, 26, 15, 0, 0), new DateTime(year, 6, 27, 15, 0, 0), 0, "8"));
        result.Add(CreateTask("78", "74", "Train support staff", new DateTime(year, 6, 27, 15, 0, 0), new DateTime(year, 6, 28, 15, 0, 0), 0, "8"));
        result.Add(CreateTask("79", "74", "Deploy software", new DateTime(year, 6, 28, 15, 0, 0), new DateTime(year, 7, 1, 15, 0, 0), 0, "8"));
        result.Add(CreateTask("80", "74", "Deployment complete", new DateTime(year, 7, 1, 15, 0, 0), new DateTime(year, 7, 1, 15, 0, 0), 0, ""));
        result.Add(CreateTask("81", "0", "Post Implementation Review", new DateTime(year, 7, 1, 15, 0, 0), new DateTime(year, 7, 4, 15, 0, 0), 0, ""));
        result.Add(CreateTask("82", "81", "Document lessons learned", new DateTime(year, 7, 1, 15, 0, 0), new DateTime(year, 7, 2, 15, 0, 0), 0, "2"));
        result.Add(CreateTask("83", "81", "Distribute to team members", new DateTime(year, 7, 2, 15, 0, 0), new DateTime(year, 7, 3, 15, 0, 0), 0, "2"));
        result.Add(CreateTask("84", "81", "Create software maintenance team", new DateTime(year, 7, 3, 15, 0, 0), new DateTime(year, 7, 4, 15, 0, 0), 0, "2"));
        result.Add(CreateTask("85", "81", "Post implementation review complete", new DateTime(year, 7, 4, 15, 0, 0), new DateTime(year, 7, 4, 15, 0, 0), 0, ""));
        result.Add(CreateTask("86", "0", "Software development template complete", new DateTime(year, 7, 4, 15, 0, 0), new DateTime(year, 7, 4, 15, 0, 0), 0, ""));

        return result;
    }
    public static Task CreateTask(string id, string parentid, string subject, DateTime start, DateTime end, int percent, string resources) {
        var task = new Task();
        task.ID = id;
        task.ParentID = parentid;
        task.Subject = subject;
        task.StartDate = start;
        task.EndDate = end;
        task.PercentComplete = percent;
        task.Employees = resources;
        return task;
    }
    static List<Dependency> CreateDependencies() {
        var result = new List<Dependency>();
        for(int i = 0; i < Tasks.Count; i++) {
            Task task = Tasks[i];
            if(!string.IsNullOrEmpty(task.ParentID)) {
                result.Add(new Dependency() { ID = CreateUniqueId(), Type = 0, ParentID = Tasks[i - 1].ID, DependentID = task.ID });
            }
        }
        return result;
    }
    static List<Resource> CreateResources() {
        var result = new List<Resource>();
        result.Add(new Resource() { ID = "1", Name = "Management" });
        result.Add(new Resource() { ID = "2", Name = "Project Manager" });
        result.Add(new Resource() { ID = "3", Name = "Analyst" });
        result.Add(new Resource() { ID = "4", Name = "Developer" });
        result.Add(new Resource() { ID = "5", Name = "Testers" });
        result.Add(new Resource() { ID = "6", Name = "Trainers" });
        result.Add(new Resource() { ID = "7", Name = "Technical Communicators" });
        result.Add(new Resource() { ID = "8", Name = "Deployment Team" });
        return result;
    }
    static List<ResourceAssignment> CreateResourceAssignments() {
        var result = new List<ResourceAssignment>();        
        foreach(Task task in Tasks) {
            if(!string.IsNullOrEmpty(task.Employees)) {
                string[] empIDs = task.Employees.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                for(int i = 0; i < empIDs.Length; i++)
                    result.Add(new ResourceAssignment() { ID = CreateUniqueId(), TaskID = task.ID, ResourceID = empIDs[i] });
            }
        }
        return result;
    }

       public static void UpdateTask(Task task) {
            Task item = Tasks.FirstOrDefault(c => c.ID.Equals(task.ID));
            item.ParentID = task.ParentID;
            item.PercentComplete = task.PercentComplete;
            item.StartDate= task.StartDate;
            item.EndDate= task.EndDate;
            item.Subject = task.Subject;       
        }

        public static string InsertTask(Task task) {
            task.ID = CreateUniqueId();
            Tasks.Add(task);
            return task.ID;            
        }
        public static void DeleteTask(Task task) {
            var taskToDelete = Tasks.FirstOrDefault(t => t.ID.Equals(task.ID));
            if(taskToDelete != null)
                Tasks.Remove(taskToDelete);
        }
        public static void DeleteTaskByKey(string key) {
            var taskToDelete = Tasks.FirstOrDefault(t => t.ID.Equals(key));
            if(taskToDelete != null)
                Tasks.Remove(taskToDelete);
        }

        public static string InsertDependency(Dependency dependency) {
            dependency.ID = CreateUniqueId();
            Dependencies.Add(dependency);
            return dependency.ID;            
        }
        public static void DeleteDependency(Dependency dependency) {
            var dependencyToDelete = Dependencies.FirstOrDefault(t => t.ID.Equals(dependency.ID));
            if(dependencyToDelete != null)
                Dependencies.Remove(dependencyToDelete);
        }
        public static void DeleteDependencyByKey(string key) {
            var dependencyToDelete = Dependencies.FirstOrDefault(t => t.ID.Equals(key));
            if(dependencyToDelete != null)
                Dependencies.Remove(dependencyToDelete);
        }

        public static void UpdateResource(Resource resource) {
            Resource item = Resources.FirstOrDefault(c => c.ID.Equals(resource.ID));
            item.Name = resource.Name;
        }

        public static string InsertResource(Resource resource) {
            resource.ID = CreateUniqueId();
            Resources.Add(resource);
            return resource.ID;            
        }
        public static void DeleteResource(Resource resource) {
            var resourceToDelete = Resources.FirstOrDefault(t => t.ID.Equals(resource.ID));
            if(resourceToDelete != null)
                Resources.Remove(resourceToDelete);
        }

        public static void DeleteResourceByKey(string key) {
            var resourceToDelete = Resources.FirstOrDefault(t => t.ID.Equals(key));
            if(resourceToDelete != null)
                Resources.Remove(resourceToDelete);
        }

        public static string InsertResourceAssignment(ResourceAssignment resourceAssignment) {
            resourceAssignment.ID = CreateUniqueId();
            ResourceAssignments.Add(resourceAssignment);
            return resourceAssignment.ID;            
        }
        public static void DeleteResourceAssignment(ResourceAssignment resourceAssignment) {
            var itemToDelete = ResourceAssignments.FirstOrDefault(t => t.ID.Equals(resourceAssignment.ID));
            if(itemToDelete != null)
                ResourceAssignments.Remove(itemToDelete);
        }

        public static void DeleteResourceAssignmentByKey(string key) {
            var itemToDelete = ResourceAssignments.FirstOrDefault(t => t.ID.Equals(key));
            if(itemToDelete != null)
                ResourceAssignments.Remove(itemToDelete);
        }

        static string CreateUniqueId() { return Guid.NewGuid().ToString(); }
}


public class Task {
    public string ID { get; set; }
    public string ParentID { get; set; }
    public string Subject { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int PercentComplete { get; set; }
    public string Employees { get; set; }
}
public class Dependency {
    public string ID { get; set; }
    public string ParentID { get; set; }
    public string DependentID { get; set; }
    public int Type { get; set; }
}
public class Resource {
    public string ID { get; set; }
    public string Name { get; set; }
}
public class ResourceAssignment {
    public string ID { get; set; }
    public string TaskID { get; set; }
    public string ResourceID { get; set; }

}
