using System;
using DevExpress.Xpo;

namespace DevExpress.Xpo.Demos {
    public enum ProjectStatus {Fixed, New, Postponed, Rejected};
    public enum ProjectType {Bug, Request};

    public class Project : XPObject {
        public Project() {}
        public Project(Session session) : base(session) {}
        public Project(Session session, string projectName, string name, string owner, DateTime createdDate, ProjectStatus status, ProjectType projectType) : base(session) {
            this.fProjectName = projectName;
            this.fName = name;
            this.fOwner = owner;
            this.fCreatedDate = createdDate;
            this.fStatus = status;
            this.fProjectType = projectType;
        }

        private string fProjectName;
        private string fName;
        private string fOwner;
        private DateTime fCreatedDate;
        private ProjectStatus fStatus;
        private ProjectType fProjectType;

        public string ProjectName {
            get { return fProjectName; }
            set {
                // The old value of the ProjectName property.
                string oldValue = ProjectName;
                if(oldValue == value)
                    return;
                fProjectName = value;
                // Keep track of every change made to the ProjectName property.
                OnChanged(nameof(ProjectName), oldValue, value);
            }
        }

        public string Name {
            get { return fName; }
            set {
                string oldValue = Name;
                if(oldValue == value)
                    return;
                fName = value;
                OnChanged(nameof(Name), oldValue, value);
            }
        }

        public string Owner {
            get { return fOwner; }
            set {
                string oldValue = Owner;
                if(oldValue == value)
                    return;
                fOwner = value;
                OnChanged(nameof(Owner), oldValue, value);
            }
        }

        public DateTime CreatedDate {
            get { return fCreatedDate; }
            set {
                DateTime oldValue = CreatedDate;
                if(oldValue == value)
                    return;
                fCreatedDate = value;
                OnChanged(nameof(CreatedDate), oldValue, value);
            }
        }

        public ProjectStatus Status {
            get { return fStatus; }
            set {
                ProjectStatus oldValue = Status;
                if(oldValue == value)
                    return;
                fStatus = value;
                OnChanged(nameof(Status), oldValue, value);
            }
        }

        public ProjectType ProjectType {
            get { return fProjectType; }
            set {
                ProjectType oldValue = ProjectType;
                if(oldValue == value)
                    return;
                fProjectType = value;
                OnChanged(nameof(ProjectType), oldValue, value);
            }
        }
    }
}
