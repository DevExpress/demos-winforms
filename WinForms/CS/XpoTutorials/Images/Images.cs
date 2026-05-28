using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Xpo.DB;
using System.IO;
using DevExpress.Internal;

namespace DevExpress.Xpo.Demos {
    public partial class Images : TutorialControl {
        string originDBFileName;
        string xpoDBFileName;
        InMemoryDataStore inMemory;
        public Images() {
            inMemory = new InMemoryDataStore(AutoCreateOption.DatabaseAndSchema);
            IDataLayer dl = new SimpleDataLayer(inMemory);
            XpoDefault.DataLayer = dl;
            originDBFileName = DataDirectoryHelper.GetDataFile("Vehicles.xml");
            if(!string.IsNullOrEmpty(originDBFileName)) {
                xpoDBFileName = Path.Combine(Path.GetDirectoryName(originDBFileName), Path.GetFileNameWithoutExtension(originDBFileName) + "Xpo.xml");
                if(File.Exists(xpoDBFileName)) {
                    inMemory.ReadXml(xpoDBFileName);
                } else {
                    inMemory.ReadXml(originDBFileName);
                }
            }
            InitializeComponent();
            unitOfWork1.Connect(dl);
        }
        public override bool SetNewWhatsThisPadding { get { return true; } }
        private void Images_Load(object sender, System.EventArgs e) {
            xpCars.LoadingEnabled = true;
            xpCars.Reload();
        }

        private void bSave_Click(object sender, System.EventArgs e) {
            SaveChanges(unitOfWork1);
            if(!string.IsNullOrEmpty(xpoDBFileName)){
                inMemory.WriteXml(xpoDBFileName);
            }
        }

        public override void ReloadData() {
            xpCars.Reload();
        }
    }
}
