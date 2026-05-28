using System;
using DevExpress.Xpo;

namespace DevExpress.Xpo.Demos {

    /* 
     * If the XPBaseObject is used as the base class for persistent objects,
     * immediate object deletion is enabled (deferred object deletion is disabled).
     * In this instance, the record in the underlying data store is immediately deleted
     * after the object has been deleted.
     */

    public class ImmediateDeletionProject : XPBaseObject {
        public ImmediateDeletionProject() {}
        public ImmediateDeletionProject(Session session) : base(session) {}
        public ImmediateDeletionProject(Session session, string projectName, string owner, DateTime createdDate) : base(session) {
            this.fProjectName = projectName;
            this.fOwner = owner;
            this.fCreatedDate = createdDate;
        }

        private int fId;
        private string fProjectName;
        private string fOwner;
        private DateTime fCreatedDate;

        [Key(true)]
        public int ID {
            get { return fId; }
            set {
                if(value == ID) return;
                fId = value;
            }
        }

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
    }
}
