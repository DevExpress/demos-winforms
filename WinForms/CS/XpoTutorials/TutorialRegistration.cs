using System;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;
using DevExpress.Utils.Frames;
using System.Collections.Generic;
using DevExpress.Tutorials;

namespace DevExpress.Xpo.Demos {
    class TutorialRegistration {
        const string languageDir = @"CS\";
        public TutorialRegistration(string xmlFile, string codeFile) {
            this.xmlFile = xmlFile;
            this.codeFile = codeFile;
        }
        string xmlFile;
        string codeFile;
        public string XmlInfoFile { get { return xmlFile; } }
        public string CodeInfoFile { get { return languageDir + codeFile; } }

        static Dictionary<string, TutorialRegistration> modulesInfo = new Dictionary<string, TutorialRegistration>();
        public static void AddInfo(string moduleName, string codeFile, string xmlFile) {
            if(modulesInfo.ContainsKey(moduleName))
                modulesInfo[moduleName] = new TutorialRegistration(xmlFile, codeFile);
            else
                modulesInfo.Add(moduleName, new TutorialRegistration(xmlFile, codeFile));
        }
        public static TutorialRegistration GetInfo(string moduleName) {
            if(modulesInfo.ContainsKey(moduleName))
                return modulesInfo[moduleName];
            else
                return null;
        }

        public static void Register() {
            AddInfo("DeletingPersistentObjects", "XpoTutorials\\DeletingPersistentObjects\\DeletingPersistentObjects.cs",
                "Data\\Tutorials\\XPO\\DeletingPersistentObjects.xml");
            AddInfo("Images", "XpoTutorials\\Images\\Cars.cs", "Data\\Tutorials\\XPO\\Images.xml");
            AddInfo("NestedUnitsOfWork", "XpoTutorials\\NestedUnitsOfWork\\NestedUnitsOfWork.cs", "Data\\Tutorials\\XPO\\NestedUnitsOfWork.xml");
            AddInfo("Pagination", "XpoTutorials\\Pagination\\Pagination.cs", "Data\\Tutorials\\XPO\\Pagination.xml");
            AddInfo("QueryingData", "XpoTutorials\\QueryingData\\QueryingData.cs", "Data\\Tutorials\\XPO\\QueryingData.xml");
            AddInfo("OneToManyRelations", "XpoTutorials\\Customers.cs", "Data\\Tutorials\\XPO\\OneToManyRelations.xml");
            AddInfo("SimpleDataAwareApplication", "XpoTutorials\\Customers.cs", "Data\\Tutorials\\XPO\\SimpleDataAwareApplication.xml");
            AddInfo("UnitsOfWork", "XpoTutorials\\UnitsOfWork\\UnitsOfWork.cs", "Data\\Tutorials\\XPO\\UnitsOfWork.xml");
            AddInfo("MSSQLServer", "XpoTutorials\\MSSQLServer\\MSSQLServer.cs", "Data\\Tutorials\\XPO\\MSSQLServer.xml");
            AddInfo("Validation", "XpoTutorials\\Validation\\Validation.cs;XpoTutorials\\Validation\\Contacts.cs;XpoTutorials\\Validation\\NewContactForm.cs",
                "Data\\Tutorials\\XPO\\Validation.xml");
            AddInfo("XPViewDemo", "XpoTutorials\\XPViewDemo\\XPViewDemo.cs", "Data\\Tutorials\\XPO\\XPViewDemo.xml");
            AddInfo("XPBindingSourceDemo", "XpoTutorials\\XPBindingSourceDemo\\XPBindingSourceDemo.cs", "Data\\Tutorials\\XPO\\XPBindingSourceDemo.xml");
            AddInfo("Generating Persistent Classes for an Existing Database", "XpoTutorials\\GeneratingPersistentClasses\\GeneratingPersistentClasses.cs",
                "Data\\Tutorials\\XPO\\GeneratingPersistentClasses.xml");
            AddInfo("Functions", "XpoTutorials\\Functions\\Functions.cs", "Data\\Tutorials\\XPO\\Functions.xml");
            AddInfo("AsyncLoading", "XpoTutorials\\AsyncLoading\\AsyncLoading.cs", "Data\\Tutorials\\XPO\\AsyncLoading.xml");
            AddInfo("AsyncLoadingTaskBased", "XpoTutorials\\AsyncLoadingTaskBased\\AsyncLoadingTaskBased.cs", "Data\\Tutorials\\XPO\\AsyncLoadingTaskBased.xml");
            AddInfo("FreeJoin", "XpoTutorials\\FreeJoin\\FreeJoin.cs", "Data\\Tutorials\\XPO\\FreeJoin.xml");
            AddInfo("StoredProcedures", "XpoTutorials\\StoredProcedures\\StoredProcedures.cs", "Data\\Tutorials\\XPO\\StoredProcedures.xml");
            AddInfo("DataCaching", "XpoTutorials\\DataCaching\\DataCaching.cs", "Data\\Tutorials\\XPO\\DataCaching.xml");
            AddInfo("DataServices", "XpoTutorials\\DataStoreService\\DataService.cs", "Data\\Tutorials\\XPO\\DataServices.xml");
            AddInfo("ObjectLayerServices", "XpoTutorials\\ObjectLayerService\\ObjectLayerService.cs", "Data\\Tutorials\\XPO\\ObjectLayerServices.xml");
            AddInfo("InTransactionMode", "XpoTutorials\\InTransactionMode\\InTransaction.cs", "Data\\Tutorials\\XPO\\InTransactionMode.xml");
            AddInfo("SpecifiedTypeObject", "XpoTutorials\\SpecifiedTypeObject\\SpecifiedTypeObject.cs", "Data\\Tutorials\\XPO\\SpecifiedTypeObject.xml");
            AddInfo("GridServerMode", "XpoTutorials\\InstantFeedback\\GridServerMode.cs", "Data\\Tutorials\\XPO\\GridServerMode.xml");
            AddInfo("Single", "XpoTutorials\\Single\\Single.cs", "Data\\Tutorials\\XPO\\Single.xml");
            AddInfo("ObjectsInAlias", "XpoTutorials\\ObjectsInAlias\\ObjectsInAlias.cs", "Data\\Tutorials\\XPO\\ObjectsInAlias.xml");
            AddInfo("ModifiedProperties", "XpoTutorials\\ModifiedProperties\\ModifiedProperties.cs", "Data\\Tutorials\\XPO\\ModifiedProperties.xml");
        }
    }
}
