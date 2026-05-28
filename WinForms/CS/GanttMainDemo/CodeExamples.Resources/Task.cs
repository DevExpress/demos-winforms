// Assembly {TutorialsAssembly}
namespace DevExpress.DXperience.Demos.CodeDemo.Data {
    using System;
    using System.Collections.Generic;

    public class Task {
        public int Id { get; set; }
        public int ParentId { get; set; }
        //
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Duration { get; set; }
        public double Progress { get; set; }
        //
        public IReadOnlyList<int> PredecessorIDs {
            get; private set;
        }
    }
}
