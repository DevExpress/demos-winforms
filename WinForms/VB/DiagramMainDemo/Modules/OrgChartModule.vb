Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports DevExpress.Diagram.Demos
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraLayout.Utils
Imports DevExpress.XtraTreeList

Namespace DevExpress.XtraDiagram.Demos

    Public Partial Class OrgChartModule
        Inherits DiagramTutorialControlBase

        Private _Templates As DevExpress.XtraDiagram.Demos.OrgChartTemplateInfo()

        Private selectedTemplateField As OrgChartTemplateInfo

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property SelectedTemplate As OrgChartTemplateInfo
            Get
                Return selectedTemplateField
            End Get

            Set(ByVal value As OrgChartTemplateInfo)
                If value IsNot selectedTemplateField Then
                    selectedTemplateField = value
                    diagramOrgChartController1.Refresh()
                End If
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property Templates As OrgChartTemplateInfo()
            Get
                Return _Templates
            End Get

            Private Set(ByVal value As OrgChartTemplateInfo())
                _Templates = value
            End Set
        End Property

        Protected Overrides ReadOnly Property Ribbon As RibbonControl
            Get
                Return ribbonControl1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            PlaceOptionsPanelControlsWithoutTabPane()
            KeepProportionsOfPanels()
            AddHandler Diagram.SelectionChanged, AddressOf DiagramControlSelectionChanged
            Templates = GetOrgChartTemplates()
            SelectedTemplate = Templates.FirstOrDefault()
            InitTemplatesGallery()
            AddHandler diagramOrgChartController1.ItemsGenerated, Sub(_o, _e) FitToItems()
            AddHandler Load, Sub(_d, _e) FitToItems()
            employeeBindingSource.DataSource = FilteredEmployees
            treeListControl1.ExpandAll()
        End Sub

        Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
            MyBase.OnSizeChanged(e)
            KeepProportionsOfPanels()
        End Sub

        Private Sub KeepProportionsOfPanels()
            If OptionsSidePanel IsNot Nothing Then OptionsSidePanel.Size = New Size(Width \ 3, OptionsSidePanel.Height)
        End Sub

        Private Sub FitToItems()
            Dim items = diagramControl.Items.OfType(Of DiagramContainer)().GroupBy(Function(x) x.Y).OrderBy(Function(x) x.Key).Take(3).SelectMany(Function(x) x).ToArray()
            diagramControl.FitToItems(items)
        End Sub

        Private Sub GenerateOrgChartItem(ByVal sender As Object, ByVal e As DiagramGenerateItemEventArgs)
            If SelectedTemplate IsNot Nothing Then e.Item = e.CreateItemFromTemplate(SelectedTemplate.Name)
        End Sub

#Region "Galleries"
        Private Sub InitTemplatesGallery()
            Dim group = New GalleryItemGroup()
            For Each template In Templates
                Dim item = New GalleryItem()
                item.Caption = template.Name
                item.Value = template
                item.Image = template.Image
                group.Items.Add(item)
            Next

            ribbonGalleryBarItem1.Gallery.Groups.Add(group)
        End Sub

        Private Function GetOrgChartTemplates() As OrgChartTemplateInfo()
            Dim templateNames = diagramOrgChartController1.TemplateDiagram.Items.OfType(Of DiagramContainer)().[Select](Function(x) x.TemplateName).ToArray()
            Dim templateImages = templateNames.[Select](Function(x) String.Format("images/orgchart/{0}.png", x.Replace(" ", String.Empty).ToLower())).[Select](Function(x) GetImageResource(x))
            Return templateNames.Zip(templateImages, Function(name, image) New OrgChartTemplateInfo(name, image)).ToArray()
        End Function

        Private Sub TemplatesGalleryItemClick(ByVal sender As Object, ByVal e As GalleryItemClickEventArgs)
            SelectedTemplate = CType(e.Item.Value, OrgChartTemplateInfo)
        End Sub

        Private Sub TemplatesGalleryInitDropDownGallery(ByVal sender As Object, ByVal e As InplaceGalleryEventArgs)
            e.PopupGallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside
        End Sub

#End Region
#Region "Selection"
        Private isSelectionLocked As Boolean = False

        Private Sub TreeListControlFocusedNodeChanged(ByVal sender As Object, ByVal e As FocusedNodeChangedEventArgs)
            DoLockedSelectionAction(Sub()
                Dim selectedEmployee As Employee = TryCast(treeListControl1.GetDataRecordByNode(e.Node), Employee)
                Dim diagramItem As DiagramItem = Nothing
                If selectedEmployee IsNot Nothing Then diagramItem = diagramControl.Items.FirstOrDefault(Function(x) x.DataContext Is selectedEmployee)
                If diagramItem IsNot Nothing Then
                    diagramControl.SelectItem(diagramItem)
                    diagramControl.BringItemsIntoView({diagramItem})
                Else
                    diagramControl.ClearSelection()
                End If
            End Sub)
        End Sub

        Private Sub DiagramControlSelectionChanged(ByVal sender As Object, ByVal e As DiagramSelectionChangedEventArgs)
            DoLockedSelectionAction(Sub()
                Dim selectedEmployee As Employee = Nothing
                If diagramControl.PrimarySelection IsNot Nothing AndAlso TypeOf diagramControl.PrimarySelection.DataContext Is Employee Then selectedEmployee = CType(diagramControl.PrimarySelection.DataContext, Employee)
                If selectedEmployee IsNot Nothing Then
                    treeListControl1.FocusedNode = treeListControl1.FindNodeByKeyID(selectedEmployee.Id)
                Else
                    treeListControl1.FocusedNode = Nothing
                End If
            End Sub)
        End Sub

        Private Sub DoLockedSelectionAction(ByVal action As Action)
            If isSelectionLocked Then Return
            isSelectionLocked = True
            action()
            isSelectionLocked = False
        End Sub
#End Region
    End Class

    Public Class OrgChartTemplateInfo

        Private _Name As String, _Image As Image

        Public Property Name As String
            Get
                Return _Name
            End Get

            Private Set(ByVal value As String)
                _Name = value
            End Set
        End Property

        Public Property Image As Image
            Get
                Return _Image
            End Get

            Private Set(ByVal value As Image)
                _Image = value
            End Set
        End Property

        Public Sub New(ByVal name As String, ByVal image As Image)
            Me.Name = name
            Me.Image = image
        End Sub
    End Class
End Namespace
