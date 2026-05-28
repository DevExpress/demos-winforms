Imports System
Imports System.Data
Imports System.Linq
Imports DevExpress.XtraLayout.Utils
Imports DevExpress.Diagram.Demos

Namespace DevExpress.XtraDiagram.Demos

    Public Partial Class RelationshipDiagramModule
        Inherits DiagramTutorialControl

        Const DefaultStrokeThickness As Integer = 2

        Const SelectedStrokeThickness As Integer = 4

        Private relationships As RelationshipInfo()

        Public Sub New()
            MyBase.New(False, False)
            InitializeComponent()
            PlaceOptionsPanelControlsWithoutTabPane()
            Dim employees = GetEmployees()
            relationships = GetRelationships(employees).ToArray()
            AddHandler Diagram.ItemsChanged, AddressOf Diagram_ItemsChanged
            AddHandler Diagram.SelectionChanged, AddressOf diagramControl_SelectionChanged
            diagramDataBindingController1.BeginInit()
            employeeBindingSource.DataSource = employees
            relationshipInfoBindingSource.DataSource = relationships
            diagramDataBindingController1.EndInit()
            Diagram.OptionsProtection.IsReadOnly = True
        End Sub

        Private Sub diagramDataBindingController1_GenerateConnector(ByVal sender As Object, ByVal e As DiagramGenerateConnectorEventArgs)
            Dim relationshipInfo = CType(e.DataObject, RelationshipInfo)
            e.Connector = e.CreateConnectorFromTemplate(relationshipInfo.Relationship.ToString())
        End Sub

        Private Sub Diagram_ItemsChanged(ByVal sender As Object, ByVal e As DiagramItemsChangedEventArgs)
            If TypeOf e.Item Is DiagramContainer Then
                RemoveHandler Diagram.ItemsChanged, AddressOf Diagram_ItemsChanged
                Diagram.SelectItem(CType(e.Item, DiagramContainer))
            End If
        End Sub

        Private Sub diagramControl_SelectionChanged(ByVal sender As Object, ByVal e As DiagramSelectionChangedEventArgs)
            For Each diagramConnector In diagramControl.Items.OfType(Of DiagramConnector)()
                Dim isSelectionRelatedConnector As Boolean = diagramControl.SelectedItems.Contains(CType(diagramConnector.BeginItem, DiagramItem)) OrElse diagramControl.SelectedItems.Contains(CType(diagramConnector.EndItem, DiagramItem))
                diagramConnector.Appearance.BorderSize = If(isSelectionRelatedConnector, SelectedStrokeThickness, DefaultStrokeThickness)
            Next

            If diagramControl.PrimarySelection Is Nothing OrElse TypeOf diagramControl.PrimarySelection Is DiagramConnector Then
                selectPersonLabel.Visibility = LayoutVisibility.Always
                personInfoGroup.Visibility = LayoutVisibility.Never
            Else
                selectPersonLabel.Visibility = LayoutVisibility.Never
                personInfoGroup.Visibility = LayoutVisibility.Always
                Dim container = TryCast(diagramControl.PrimarySelection, DiagramContainer)
                Dim employee = TryCast(diagramControl.PrimarySelection.DataContext, Employee)
                If container IsNot Nothing AndAlso employee IsNot Nothing Then
                    pictureEdit.EditValue = employee.ImageData
                    labelName.Text = employee.FullName
                    labelPhoneNumber.Text = employee.Phone
                    labelBirthDate.Text = employee.BirthDate.ToString("MMMM dd, yyyy")
                    labelAddressLine.Text = employee.AddressLine1
                    labelFriends.Text = GetRelationsText(employee, EmployeeRelationship.Friends)
                    labelKnowEachOther.Text = GetRelationsText(employee, EmployeeRelationship.KnowEachOther)
                End If
            End If
        End Sub

        Private Function GetRelationsText(ByVal employee As Employee, ByVal relationshipKind As EmployeeRelationship) As String
            Dim relations = GetEmployeeRelationships(employee, relationships, relationshipKind).Select(Function(x) x.FullName & Environment.NewLine)
            Return String.Concat(relations)
        End Function
    End Class
End Namespace
