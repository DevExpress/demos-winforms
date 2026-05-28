using System;
using System.Data;
using System.Linq;
using DevExpress.XtraLayout.Utils;
using DevExpress.Diagram.Demos;

namespace DevExpress.XtraDiagram.Demos {
    public partial class RelationshipDiagramModule : DiagramTutorialControl {
        const int DefaultStrokeThickness = 2;
        const int SelectedStrokeThickness = 4;

        RelationshipInfo[] relationships;
        public RelationshipDiagramModule() : base(false, false) {
            InitializeComponent();
            PlaceOptionsPanelControlsWithoutTabPane();
            var employees = RelationshipsData.GetEmployees();
            relationships = RelationshipsData.GetRelationships(employees).ToArray();

            Diagram.ItemsChanged += Diagram_ItemsChanged;
            Diagram.SelectionChanged += diagramControl_SelectionChanged;

            diagramDataBindingController1.BeginInit();
            employeeBindingSource.DataSource = employees;
            relationshipInfoBindingSource.DataSource = relationships;
            diagramDataBindingController1.EndInit();
            Diagram.OptionsProtection.IsReadOnly = true;
        }

        private void diagramDataBindingController1_GenerateConnector(object sender, DiagramGenerateConnectorEventArgs e) {
            var relationshipInfo = (RelationshipInfo)e.DataObject;
            e.Connector = e.CreateConnectorFromTemplate(relationshipInfo.Relationship.ToString());
        }
        void Diagram_ItemsChanged(object sender, DiagramItemsChangedEventArgs e) {
            if(e.Item is DiagramContainer) {
                Diagram.ItemsChanged -= Diagram_ItemsChanged;
                Diagram.SelectItem((DiagramContainer)e.Item);
            }
        }
        void diagramControl_SelectionChanged(object sender, DiagramSelectionChangedEventArgs e) {
            foreach(var diagramConnector in diagramControl.Items.OfType<DiagramConnector>()) {
                bool isSelectionRelatedConnector = diagramControl.SelectedItems.Contains((DiagramItem)diagramConnector.BeginItem) || diagramControl.SelectedItems.Contains((DiagramItem)diagramConnector.EndItem);
                diagramConnector.Appearance.BorderSize = isSelectionRelatedConnector ? SelectedStrokeThickness : DefaultStrokeThickness;
            }
            if(diagramControl.PrimarySelection == null || diagramControl.PrimarySelection is DiagramConnector) {
                selectPersonLabel.Visibility = LayoutVisibility.Always;
                personInfoGroup.Visibility = LayoutVisibility.Never;
            } else {
                selectPersonLabel.Visibility = LayoutVisibility.Never;
                personInfoGroup.Visibility = LayoutVisibility.Always;

                var container = diagramControl.PrimarySelection as DiagramContainer;
                var employee = diagramControl.PrimarySelection.DataContext as Employee;
                if(container != null && employee != null) {
                    pictureEdit.EditValue = employee.ImageData;
                    labelName.Text = employee.FullName;
                    labelPhoneNumber.Text = employee.Phone;
                    labelBirthDate.Text = employee.BirthDate.ToString("MMMM dd, yyyy");
                    labelAddressLine.Text = employee.AddressLine1;
                    labelFriends.Text = GetRelationsText(employee, EmployeeRelationship.Friends);
                    labelKnowEachOther.Text = GetRelationsText(employee, EmployeeRelationship.KnowEachOther);
                }
            }
        }
        string GetRelationsText(Employee employee, EmployeeRelationship relationshipKind) {
            var relations = RelationshipsData.GetEmployeeRelationships(employee, relationships, relationshipKind).Select(x => x.FullName + Environment.NewLine);
            return string.Concat(relations);
        }
    }
}
