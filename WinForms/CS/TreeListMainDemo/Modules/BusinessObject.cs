using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections;

namespace DevExpress.XtraTreeList.Demos {
    public enum Priority { Normal = 0, Low = 1, High = 2 }
    public class Project {
        string nameCore;
        string descriptionCore;
        DateTime startDateCore;
        DateTime endDateCore;
        Priority priorityCore;
        Projects ownerCore;
        Projects projectsCore;
        bool isTaskCore;
        public Project() {
            this.ownerCore = null;
            this.nameCore = "";
            this.descriptionCore = "";
            this.isTaskCore = false;
            this.startDateCore = this.endDateCore = DateTime.Today;
            this.priorityCore = Priority.Normal;
            this.projectsCore = new Projects();
        }
        public Project(string name, string description, DateTime startDate, DateTime endDate, Priority priority, bool isTask) {
            this.nameCore = name;
            this.descriptionCore = description;
            this.isTaskCore = isTask;
            this.startDateCore = startDate;
            this.endDateCore = endDate;
            this.priorityCore = priority;
            this.projectsCore = new Projects();
        }
        public Project(Projects projects, string name, string description, DateTime startDate, DateTime endDate, Priority priority, bool isTask)
            : this(name, description, startDate, endDate, priority, isTask) {
            this.projectsCore = projects;
        }
        [Browsable(false)]
        public Projects Owner {
            get { return ownerCore; }
            set { ownerCore = value; }
        }
        public bool IsTask { 
            get { return isTaskCore; }
            set {
                if(isTaskCore == value) return;
                isTaskCore = value;
                OnChanged();
            }
        }
        public string Name { 
            get { return nameCore; } 
            set {
                if(Name == value) return;
                nameCore = value;
                OnChanged();
            } 
        }
        [Browsable(false)]
        public string Description {
            get { return descriptionCore; }
            set {
                if(Description == value) return;
                descriptionCore = value;
                OnChanged();
            }
        }
        public DateTime StartDate {
            get { return startDateCore; }
            set {
                if(StartDate == value) return;
                startDateCore = value;
                OnChanged();
            }
        }
        public DateTime EndDate {
            get { return endDateCore; }
            set {
                if(StartDate == value) return;
                endDateCore = value;
                OnChanged();
            }
        }
        public Priority Priority {
            get { return priorityCore; }
            set {
                if(Priority == value) return;
                priorityCore = value;
                OnChanged();
            }
        }
        [Browsable(false)]
        public Projects Projects { get { return projectsCore; } }
        void OnChanged() {
            if(ownerCore == null) return;
            int index = ownerCore.IndexOf(this);
            ownerCore.ResetItem(index);
        }
    }
    //<treeList1>
    public class Projects : BindingList<Project>, TreeList.IVirtualTreeListData {
        void TreeList.IVirtualTreeListData.VirtualTreeGetChildNodes(VirtualTreeGetChildNodesInfo info) {
            Project obj = info.Node as Project;
            info.Children = obj.Projects;
        }
        protected override void InsertItem(int index, Project _item) {
            _item.Owner = this;
            base.InsertItem(index, _item);
        }
        void TreeList.IVirtualTreeListData.VirtualTreeGetCellValue(VirtualTreeGetCellValueInfo info) {
            Project obj = info.Node as Project;
            switch(info.Column.Caption) { 
                case "Name":
                    info.CellData = obj.Name;
                    break;
                case "Description":
                    info.CellData = obj.Description;
                    break;
                case "StartDate":
                    info.CellData = obj.StartDate;
                    break;
                case "EndDate":
                    info.CellData = obj.EndDate;
                    break;
                case "Priority":
                    info.CellData = obj.Priority;
                    break;
            }
        }
        void TreeList.IVirtualTreeListData.VirtualTreeSetCellValue(VirtualTreeSetCellValueInfo info) {
            Project obj = info.Node as Project;
            switch(info.Column.Caption) {
                case "Name":
                    obj.Name = (string)info.NewCellData;
                    break;
                case "Description":
                    obj.Description = (string)info.NewCellData;
                    break;
                case "StartDate":
                    obj.StartDate = (DateTime)info.NewCellData;
                    break;
                case "EndDate":
                    obj.EndDate = (DateTime)info.NewCellData;
                    break;
                case "Priority":
                    obj.Priority = (Priority)info.NewCellData;
                    break;
            }
        } 
    }
    //</treeList1>
}
