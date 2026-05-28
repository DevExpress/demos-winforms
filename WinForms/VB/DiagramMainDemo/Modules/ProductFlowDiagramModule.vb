Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports DevExpress.Diagram.Core
Imports DevExpress.Diagram.Demos
Imports DevExpress.Utils
Imports DevExpress.Data.Filtering

Namespace DevExpress.XtraDiagram.Demos

    Public Partial Class ProductFlowDiagramModule
        Inherits DiagramTutorialControl

        Private ReadOnly styles As DiagramItemStyleId() = DiagramShapeStyleId.Styles.ToArray()

        Private ReadOnly info As ProductFlowInfo

        Public Sub New()
            MyBase.New(False, False)
            InitializeComponent()
            PlaceOptionsPanelControlsWithoutTabPane()
            diagramControl.Commands.RegisterHotKeys(New Action(Of IHotKeysRegistrator)(AddressOf ClearHotKeys))
            info = GenerateProductFlowInfo()
            diagramDataBindingController1.BeginInit()
            diagramDataBindingController1.DataSource = info.Items
            diagramDataBindingController1.ConnectorsSource = info.ProductFlows
            diagramDataBindingController1.EndInit()
            gridControl.DataSource = info.Orders
            AddHandler Diagram.SelectionChanged, AddressOf OnDiagramSelectionChanged
            Diagram.SelectItem(Diagram.Items.First())
            Diagram.OptionsProtection.IsReadOnly = True
        End Sub

        Private Sub ClearHotKeys(ByVal registrator As IHotKeysRegistrator)
            registrator.ClearHotKeys(DiagramCommandsBase.SaveFileAsCommand)
            registrator.ClearHotKeys(DiagramCommandsBase.SaveFileCommand)
        End Sub

        Private Sub OnDiagramSelectionChanged(ByVal sender As Object, ByVal e As DiagramSelectionChangedEventArgs)
            Dim selectedDiagramItem = Diagram.PrimarySelection
            gridView.ClearGrouping()
            gridView.ActiveFilterCriteria = Nothing
            If selectedDiagramItem Is Nothing Then Return
            Dim customers = GetDataItems(Of CustomerData)()
            Dim categories = GetDataItems(Of CategoryData)()
            Dim connectors = GetDataItems(Of ProductFlowData)()
            If connectors.Any() Then
                Dim connectorsCriteria = connectors.[Select](Function(c) New GroupOperator(GroupOperatorType.And, GetCategoryOperator(c.Category.Name), GetCustomerOperator(c.Customer.Name)))
                gridView.ActiveFilterCriteria = New GroupOperator(GroupOperatorType.Or, connectorsCriteria)
                GroupGridControl("Category.Name")
                Return
            End If

            If customers.Any() AndAlso Not categories.Any() Then
                Dim customersCriteria = customers.[Select](Function(c) GetCustomerOperator(c.Name))
                gridView.ActiveFilterCriteria = New GroupOperator(GroupOperatorType.Or, customersCriteria)
                GroupGridControl("Category.Name")
            End If

            If categories.Any() Then
                Dim productCriteria = New GroupOperator(GroupOperatorType.Or, categories.[Select](Function(c) GetCategoryOperator(c.Name)))
                Dim customersCriteria As GroupOperator = Nothing
                If customers.Any() Then customersCriteria = New GroupOperator(GroupOperatorType.Or, customers.[Select](Function(c) GetCustomerOperator(c.Name)))
                gridView.ActiveFilterCriteria = If(customers.Any(), New GroupOperator(GroupOperatorType.And, customersCriteria, productCriteria), productCriteria)
                GroupGridControl("Customer.Name")
            End If
        End Sub

        Private Sub GroupGridControl(ByVal columnName As String)
            gridView.Columns(columnName).Group()
            gridView.ExpandAllGroups()
        End Sub

        Private Sub diagramDataBindingController1_GenerateItem(ByVal sender As Object, ByVal e As DiagramGenerateItemEventArgs)
            Dim templateName = If((TypeOf e.DataObject Is CustomerData), "CustomerTemplate", "CategoryTemplate")
            e.Item = e.CreateItemFromTemplate(templateName)
        End Sub

        Private Sub diagramDataBindingController1_CustomLayoutItems(ByVal sender As Object, ByVal e As DiagramCustomLayoutItemsEventArgs)
            Call ArrangeItemsInLine(Of CategoryData)(e.Items, New PointFloat(600, 50), New Size(150, 105), 20)
            Call ArrangeItemsInLine(Of CustomerData)(e.Items, New PointFloat(50, 100), New Size(150, 105), 20)
            For Each item In e.Items
                Dim customer = TryCast(item.DataContext, CustomerData)
                If customer IsNot Nothing Then
                    item.ThemeStyleId = styles(Array.IndexOf(info.Customers, customer))
                End If
            Next

            For Each connector In e.DiagramConnectors
                Dim connectorData = CType(connector.DataContext, ProductFlowData)
                connector.ThemeStyleId = styles(Array.IndexOf(info.Customers, connectorData.Customer))
            Next

            e.Handled = True
        End Sub

        Private Sub ArrangeItemsInLine(Of TDataContext)(ByVal items As IEnumerable(Of DiagramItem), ByVal startPosition As PointFloat, ByVal itemSize As Size, ByVal margin As Integer)
            Dim position As PointFloat = startPosition
            For Each diagramItem In items.Where(Function(x) TypeOf x.DataContext Is TDataContext)
                diagramItem.Position = position
                position.Offset(0, itemSize.Height + margin)
            Next
        End Sub

        Private Sub diagramDataBindingController1_UpdateConnector(ByVal sender As Object, ByVal e As DiagramUpdateConnectorEventArgs)
            Dim connectorData = CType(e.DataObject, ProductFlowData)
            e.Connector.Appearance.BorderSize = CInt(connectorData.Weight)
        End Sub

        Private Function GetDataItems(Of T)() As IEnumerable(Of T)
            Return diagramControl.SelectedItems.[Select](Function(x) x.DataContext).Where(Function(x) TypeOf x Is T).Cast(Of T)()
        End Function

        Private Function GetCategoryOperator(ByVal value As String) As BinaryOperator
            Return GetEqualOperator("Category.Name", value)
        End Function

        Private Function GetCustomerOperator(ByVal value As String) As BinaryOperator
            Return GetEqualOperator("Customer.Name", value)
        End Function

        Private Function GetEqualOperator(ByVal propertyName As String, ByVal value As String) As BinaryOperator
            Return New BinaryOperator(propertyName, value, BinaryOperatorType.Equal)
        End Function
    End Class
End Namespace
