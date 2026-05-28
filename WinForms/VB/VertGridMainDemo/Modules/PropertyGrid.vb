Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraDiagram
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraLayout.Utils
Imports DevExpress.XtraReports.Design
Imports DevExpress.XtraVerticalGrid.Native
Imports DevExpress.XtraVerticalGrid.Rows
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq

Namespace DevExpress.XtraVerticalGrid.Demos

    Public Partial Class PropertyGrid
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "CS\VertGridMainDemo\Modules\PropertyGrid.cs"
        End Sub

        Protected Overrides Sub OnFirstLoad()
            MyBase.OnFirstLoad()
            SetupModernView()
            DiagramControl.SelectItem(diagramShape6)
            DiagramControl.FitToDrawing()
        End Sub

        Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
            MyBase.OnSizeChanged(e)
            If DiagramControl IsNot Nothing Then DiagramControl.FitToDrawing()
        End Sub

        Protected ReadOnly Property Grid As PropertyGridControl
            Get
                Return propertyGridControl1
            End Get
        End Property

        Protected ReadOnly Property DiagramControl As DiagramControl
            Get
                Return diagramControl1
            End Get
        End Property

        Protected Sub OnDiagramControlSelectionChanged(ByVal sender As Object, ByVal e As DiagramSelectionChangedEventArgs)
            Grid.SelectedObjects = DiagramControl.SelectedItems.ToArray()
            Grid.RetrieveFields()
        End Sub

        Protected Overridable Sub SetupModernView()
            Grid.BeginUpdate()
            Grid.ActiveViewType = PropertyGridView.Office
            Grid.OptionsFind.Location = FindPanelLocation.TabPanel
            Grid.OptionsFind.Visibility = FindPanelVisibility.Always
            Grid.RecordWidth = 140
            InitializeOfficeEditors()
            Grid.EndUpdate()
        End Sub

        Protected Overridable Sub SetupClassicView()
            Grid.BeginUpdate()
            Grid.ActiveViewType = PropertyGridView.Classic
            Grid.OptionsFind.Location = FindPanelLocation.Default
            Grid.OptionsFind.Visibility = FindPanelVisibility.Default
            Grid.RecordWidth = 100
            Grid.HideFindPanel()
            InitializeClassicEditors()
            Grid.EndUpdate()
        End Sub

        Protected Sub OnPropertyGridPopupMenuShowing(ByVal sender As Object, ByVal e As Events.PopupMenuShowingEventArgs)
            ChangeViewItem.Caption = If(Grid.IsClassic, "Use Office view", "Use Classic view")
            e.Menu.Items.Add(ChangeViewItem)
        End Sub

        Protected Sub OnPropertyGridCustomRowCreated(ByVal sender As Object, ByVal e As Events.CustomRowCreatedEventArgs)
            If Equals(e.Row.Properties.FieldName, "Angle") Then SetupRowAngle(TryCast(e.Row, PGridNumericEditorRow))
            If Equals(e.Row.Properties.FieldName, "Appearance.BorderSize") Then SetupRowBorderSize(TryCast(e.Row, PGridNumericEditorRow))
            If Equals(e.Row.Properties.FieldName, "Appearance.Font.Size") Then SetupRowFontSize(TryCast(e.Row, PGridNumericEditorRow))
            If Equals(e.Row.Properties.FieldName, "Size.Width") Then SetupRowSize(TryCast(e.Row, PGridNumericEditorRow))
            If Equals(e.Row.Properties.FieldName, "Size.Height") Then SetupRowSize(TryCast(e.Row, PGridNumericEditorRow))
            If Equals(e.Row.Properties.FieldName, "MinSize.Width") Then SetupRowMinSize(TryCast(e.Row, PGridNumericEditorRow))
            If Equals(e.Row.Properties.FieldName, "MinSize.Height") Then SetupRowMinSize(TryCast(e.Row, PGridNumericEditorRow))
        'if(e.Row.Properties.FieldName == "Appearance.TextOptions.VAlignment") {
        '    e.Row = new PGridVertAlignmentEditorRow();
        '    e.Handled = true;
        '}
        End Sub

        Protected Sub SetupRowAngle(ByVal row As PGridNumericEditorRow)
            row.MinValue = -180
            row.MaxValue = 180
            row.ShowTrackBar = True
        End Sub

        Protected Sub SetupRowBorderSize(ByVal row As PGridNumericEditorRow)
            row.MinValue = 0
            row.MaxValue = 30
            row.ShowTrackBar = True
        End Sub

        Protected Sub SetupRowFontSize(ByVal row As PGridNumericEditorRow)
            row.MinValue = 6
            row.MaxValue = 72
            row.ShowTrackBar = True
        End Sub

        Protected Sub SetupRowSize(ByVal row As PGridNumericEditorRow)
            row.MinValue = 20
            row.MaxValue = 500
            row.ShowTrackBar = True
        End Sub

        Protected Sub SetupRowMinSize(ByVal row As PGridNumericEditorRow)
            row.MinValue = 5
            row.MaxValue = 50
            row.ShowTrackBar = True
        End Sub

        Protected Sub InitializeClassicEditors()
            Grid.DefaultEditors.Clear()
            Grid.DefaultEditors.Add(New DefaultEditor(GetType(Color), ClassicColorPickEdit))
            Grid.DefaultEditors.Add(New DefaultEditor(GetType(Boolean), ClassicBooleanEditor))
        End Sub

        Protected Sub InitializeOfficeEditors()
            Grid.DefaultEditors.Clear()
            Grid.DefaultEditors.Add(New DefaultEditor(GetType(Color), OfficeColorPickEdit))
            ' Register custom editor 
            Grid.OfficeRowStore.UserStore(GetType(Font)) = New CreateRowEditor(AddressOf CreateFontEditor)
        'Grid.OfficeRowStore.UserStore[typeof(HorzAlignment)] = new CreateRowEditor(CreateHorzAlignmentRow);
        End Sub

        Protected Overridable Function CreateFontEditor() As PGridCustomEditorRow
            Return New PGridFontEditorRow()
        End Function

        Protected Overridable Function CreateHorzAlignmentRow() As PGridCustomEditorRow
            Return New PGridHorzAlignmentEditorRow()
        End Function

        Private officeColorPickEditCore As PGRepositoryItemColorPickEdit

        Protected ReadOnly Property OfficeColorPickEdit As PGRepositoryItemColorPickEdit
            Get
                Return If(officeColorPickEditCore, Function()
                    officeColorPickEditCore = New PGRepositoryItemColorPickEdit()
                    Return officeColorPickEditCore
                End Function())
            End Get
        End Property

        Private classicColorPickEditCore As RepositoryItemColorPickEdit

        Protected ReadOnly Property ClassicColorPickEdit As RepositoryItemColorPickEdit
            Get
                Return If(classicColorPickEditCore, Function()
                    classicColorPickEditCore = New RepositoryItemColorPickEdit()
                    Return classicColorPickEditCore
                End Function())
            End Get
        End Property

        Private classicBooleanEditorCore As RepositoryItemCheckEdit

        Private ReadOnly Property ClassicBooleanEditor As RepositoryItemCheckEdit
            Get
                Return If(classicBooleanEditorCore, Function()
                    classicBooleanEditorCore = New RepositoryItemCheckEdit()
                    Return classicBooleanEditorCore
                End Function())
            End Get
        End Property

        Private changeViewItemCore As DXMenuItem

        Protected ReadOnly Property ChangeViewItem As DXMenuItem
            Get
                If changeViewItemCore Is Nothing Then changeViewItemCore = CreateChangeViewItem()
                Return changeViewItemCore
            End Get
        End Property

        Protected Overridable Function CreateChangeViewItem() As DXMenuItem
            Dim item As DXMenuItem = New DXMenuItem()
            item.BeginGroup = True
            AddHandler item.Click, Sub()
                If Grid.IsClassic Then
                    SetupModernView()
                Else
                    SetupClassicView()
                End If

                Grid.RetrieveFields()
            End Sub
            Return item
        End Function

        Private Sub OnPropertyGridInvalidValueException(ByVal sender As Object, ByVal e As InvalidValueExceptionEventArgs)
            If e.Exception.GetType() Is GetType(EditorValueException) AndAlso e.ErrorText.Contains("DefaultBoolean") Then
                Grid.HideEditor()
                e.ExceptionMode = ExceptionMode.Ignore
            End If
        End Sub
    End Class

    Friend Class PGridVertAlignmentEditorRow
        Inherits PGridContainerEditorRow

        Protected Overrides Function CreateViewInfoCore() As PGridCustomEditorRowViewInfo
            Return New PGridVertAlignmentEditorRowViewInfo(Me)
        End Function

        Public Overrides Function GetEditValue(ByVal element As RepositoryItemStoreElement) As Object
            Dim value As Object = Grid.GetCellValue(Me, 0)
            If value Is Nothing Then Return Nothing
            Dim alignment As VertAlignment = CType(value, VertAlignment)
            If alignment = VertAlignment.Default Then alignment = VertAlignment.Center
            Return alignment
        End Function
    End Class

    Friend Class PGridHorzAlignmentEditorRow
        Inherits PGridContainerEditorRow

        Protected Overrides Function CreateViewInfoCore() As PGridCustomEditorRowViewInfo
            Return New PGridHorzAlignmentEditorRowViewInfo(Me)
        End Function

        Public Overrides Function GetEditValue(ByVal element As RepositoryItemStoreElement) As Object
            Dim value As Object = Grid.GetCellValue(Me, 0)
            If value Is Nothing Then Return Nothing
            Dim alignment As HorzAlignment = CType(value, HorzAlignment)
            If alignment = HorzAlignment.Default Then alignment = HorzAlignment.Center
            Return alignment
        End Function
    End Class

    Friend Class PGridAlignmentEditorRowViewInfoCore
        Inherits PGridContainerEditorRowViewInfo

        Public Sub New(ByVal row As BaseRow)
            MyBase.New(row)
        End Sub

        Protected Overrides ReadOnly Property Indent As Integer
            Get
                Return ScaleUtils.ScaleValue(1)
            End Get
        End Property

        Private checkButtonSizeCore As Integer = -1

        Protected Overridable ReadOnly Property CheckButtonSize As Integer
            Get
                If checkButtonSizeCore < 0 Then checkButtonSizeCore = Row.Grid.ViewInfo.GetTextMinHeight()
                Return checkButtonSizeCore
            End Get
        End Property

        Protected Overridable Function GetCheckButton(ByVal name As String, ByVal group As Integer) As RepositoryItemCheckButton
            Dim button As RepositoryItemCheckButton = New RepositoryItemCheckButton()
            button.BorderStyle = BorderStyles.NoBorder
            button.CheckBoxOptions.Style = CheckBoxStyle.Custom
            button.ImageOptions.SvgImageSize = New Size(16, 16)
            button.ImageOptions.SvgImageContent = ResourceImageHelperCore.CreateSvgImageFromResources("Images.OfficeView.TextAlignmentRow." & name & ".svg", GetType(PGridVertAlignmentEditorRowViewInfo))
            button.RadioGroupIndex = group
            button.Tag = name
            Return button
        End Function

        Protected Overrides Function CalcRepositoryItemBounds(ByVal element As RepositoryItemStoreElement, ByVal content As Rectangle) As Rectangle
            Dim x As Integer = content.Right - (Indent + CheckButtonSize) * element.Bounds.X
            Dim y As Integer = content.Y + element.Bounds.Y * (CheckButtonSize + Indent)
            Dim width As Integer = If(element.Bounds.Width < 0, content.Width, element.Bounds.Width)
            Dim height As Integer = If(element.Bounds.Height < 0, CalcEditorHeight(element.Item), element.Bounds.Height)
            Return New Rectangle(x, y, width, height)
        End Function
    End Class

    Friend Class PGridVertAlignmentEditorRowViewInfo
        Inherits PGridAlignmentEditorRowViewInfoCore

        Public Sub New()
            Me.New(Nothing)
        End Sub

        Public Sub New(ByVal row As BaseRow)
            MyBase.New(row)
        End Sub

        Protected Overrides Function CreateContainer() As RepositoryItemContainer
            Return New TextVertAlignmentRepositoryItemContainer()
        End Function

        Protected Overrides Sub PopulateContainer(ByVal container As RepositoryItemContainer)
            container.Store.CreateElement(GetCheckButton("VertAlignTop", 1), New Rectangle(1, 0, CheckButtonSize, CheckButtonSize), Row.Properties.FieldName, "Top")
            container.Store.CreateElement(GetCheckButton("VertAlignMiddle", 1), New Rectangle(2, 0, CheckButtonSize, CheckButtonSize), Row.Properties.FieldName, "Center")
            container.Store.CreateElement(GetCheckButton("VertAlignBottom", 1), New Rectangle(3, 0, CheckButtonSize, CheckButtonSize), Row.Properties.FieldName, "Bottom")
        End Sub
    End Class

    Friend Class PGridHorzAlignmentEditorRowViewInfo
        Inherits PGridAlignmentEditorRowViewInfoCore

        Public Sub New()
            Me.New(Nothing)
        End Sub

        Public Sub New(ByVal row As BaseRow)
            MyBase.New(row)
        End Sub

        Protected Overrides Function CreateContainer() As RepositoryItemContainer
            Return New TextHorzAlignmentRepositoryItemContainer()
        End Function

        Protected Overrides Sub PopulateContainer(ByVal container As RepositoryItemContainer)
            container.Store.CreateElement(GetCheckButton("JustifyLeft", 2), New Rectangle(1, 0, CheckButtonSize, CheckButtonSize), Row.Properties.FieldName, "Left")
            container.Store.CreateElement(GetCheckButton("JustifyCenter", 2), New Rectangle(2, 0, CheckButtonSize, CheckButtonSize), Row.Properties.FieldName, "Center")
            container.Store.CreateElement(GetCheckButton("JustifyRight", 2), New Rectangle(3, 0, CheckButtonSize, CheckButtonSize), Row.Properties.FieldName, "Right")
        End Sub
    End Class

    Friend Class TextVertAlignmentRepositoryItemContainer
        Inherits RepositoryItemContainer

        Protected Overrides Function GetEditValue() As Object
            Dim rvi As PGridVertAlignmentEditorRowViewInfo = CType(Tag, PGridVertAlignmentEditorRowViewInfo)
            Dim value As Object = rvi.Row.Grid.GetCellValue(rvi.Row, rvi.Row.Grid.FocusedRecord)
            If CType(value, VertAlignment) = VertAlignment.Default Then value = VertAlignment.Center
            Return value
        End Function
    End Class

    Friend Class TextHorzAlignmentRepositoryItemContainer
        Inherits RepositoryItemContainer

        Protected Overrides Function GetEditValue() As Object
            Dim rvi As PGridHorzAlignmentEditorRowViewInfo = CType(Tag, PGridHorzAlignmentEditorRowViewInfo)
            Dim value As Object = rvi.Row.Grid.GetCellValue(rvi.Row, rvi.Row.Grid.FocusedRecord)
            If CType(value, HorzAlignment) = HorzAlignment.Default Then value = HorzAlignment.Center
            Return value
        End Function
    End Class
End Namespace
