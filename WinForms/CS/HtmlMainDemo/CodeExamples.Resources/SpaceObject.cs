// Assembly {TutorialsAssembly}
namespace DevExpress.DXperience.Demos.CodeDemo.Data {
    using System;

    public class SpaceObject {
        public int ID { get; set; }
        public int ParentID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public int MeanRadiusInKM { get; set; }
        public double MeanRadiusByEarth { get; set; }
        public string TypeOfObject { get; set; }
        public bool Mark { get; set; }
        public DateTime RecordDate { get; set; }
    }
}
