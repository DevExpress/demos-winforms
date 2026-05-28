Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports System.Linq
Imports System.Collections.Generic

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class Groups
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            CreateWaitDialog()
            InitializeComponent()
        End Sub

        Public Overrides ReadOnly Property ViewOptionsControl As PivotGridControl
            Get
                Return pivotGridControl1
            End Get
        End Property

        Public Overrides ReadOnly Property ExportControl As PivotGridControl
            Get
                Return pivotGridControl1
            End Get
        End Property

        Private groupColors As Color()

        '<pivotGridControl1>
        Private Sub Groups_Load(ByVal sender As Object, ByVal e As EventArgs)
            UpdateGroupColors()
            pivotGridControl1.DataSource = GetNWindData("SalesPerson")
            pivotGridControl1.HeaderImages = HeadersImageList
            pivotGridControl1.ValueImages = CategoryImageList
            fieldExtendedPrice.ImageIndex = 3
        End Sub

        Private Sub UpdateGroupColors()
            groupColors = New Color() {Green, Blue, Red}
        End Sub

        Private Sub pivotGridControl1_FieldValueImageIndex(ByVal sender As Object, ByVal e As PivotFieldImageIndexEventArgs)
            If e.Field Is fieldCategoryName AndAlso Equals(e.ValueType, PivotGridValueType.Value) Then e.ImageIndex = GetCategoryIndexByName(e.Value)
        End Sub

        '</pivotGridControl1>
        Private Sub pivotGridControl1_CustomDrawFieldHeader(ByVal sender As Object, ByVal e As PivotCustomDrawFieldHeaderEventArgs)
            e.Appearance.ForeColor = groupColors(e.Field.Group.Index)
        End Sub

        Protected Overrides Sub OnStyleChanged()
            MyBase.OnStyleChanged()
            UpdateGroupColors()
        End Sub

        Private syncLocked As Boolean = False

        '<ceColumns>
        Private Sub ceColumns_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            GroupsExpandCollapse(PivotArea.ColumnArea, Not TryCast(sender, CheckEdit).Checked)
        End Sub

        '</ceColumns>
        '<ceRows>
        Private Sub ceRows_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            GroupsExpandCollapse(PivotArea.RowArea, Not TryCast(sender, CheckEdit).Checked)
        End Sub

        '</ceRows>
        '<ceData>
        Private Sub ceData_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            GroupsExpandCollapse(PivotArea.DataArea, Not TryCast(sender, CheckEdit).Checked)
        End Sub

        '</ceData>
        Private Sub SyncCheckBoxes()
            If syncLocked Then Return
            syncLocked = True
            Dim groupsByArea = pivotGridControl1.Groups.Cast(Of PivotGridGroup)().Where(Function(g) g.Area <> PivotArea.FilterArea).ToLookup(Function(g) g.Area)
            Dim colGroups = groupsByArea(PivotArea.ColumnArea)
            SetCheckBoxState(ceColumns, groupsByArea(PivotArea.ColumnArea))
            SetCheckBoxState(ceRows, groupsByArea(PivotArea.RowArea))
            SetCheckBoxState(ceData, groupsByArea(PivotArea.DataArea))
            syncLocked = False
            BestFit()
        End Sub

        Private Sub BestFit()
            pivotGridControl1.BestFitRowArea()
            pivotGridControl1.BestFitDataHeaders(True)
        End Sub

        '<ceColumns>
        '<ceRows>
        '<ceData>
        Private Sub GroupsExpandCollapse(ByVal area As PivotArea, ByVal expand As Boolean)
            If syncLocked Then Return
            syncLocked = True
            pivotGridControl1.BeginUpdate()
            Try
                For Each group As PivotGridGroup In pivotGridControl1.Groups
                    If group.Area = area Then
                        For Each field As PivotGridField In group
                            field.ExpandedInFieldsGroup = expand
                        Next
                    End If
                Next
            Finally
                pivotGridControl1.EndUpdate()
                BestFit()
                syncLocked = False
            End Try
        End Sub

        '</ceData>
        '</ceRows>
        '</ceColumns>
        Private Sub SetCheckBoxState(ByVal ce As CheckEdit, ByVal groups As IEnumerable(Of PivotGridGroup))
            ce.Enabled = groups.Any()
            If Not ce.Enabled Then Return
            Dim collapsedCount As Integer = groups.Count(Function(g) g.VisibleCount = 1)
            Dim count As Integer = groups.Count()
            Dim allGroupsCollapsed As Boolean = collapsedCount = count
            If allGroupsCollapsed Then
                ce.CheckState = CheckState.Checked
            Else
                Dim expandedCount As Integer = groups.Count(Function(g) g.VisibleCount = g.Count)
                Dim allGroupsExpanded As Boolean = expandedCount = count
                If allGroupsExpanded Then
                    ce.CheckState = CheckState.Unchecked
                Else
                    ce.CheckState = CheckState.Indeterminate
                End If
            End If
        End Sub

        Private Sub pivotGridControl1_FieldExpandedInFieldGroupChanged(ByVal sender As Object, ByVal e As PivotFieldEventArgs)
            SyncCheckBoxes()
        End Sub

        Private Sub pivotGridControl1_FieldAreaChanged(ByVal sender As Object, ByVal e As PivotFieldEventArgs)
            SyncCheckBoxes()
        End Sub

        Private Sub CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim ce = TryCast(sender, CheckEdit)
            If ce.CheckState = CheckState.Indeterminate AndAlso Not syncLocked Then ce.CheckState = CheckState.Unchecked
        End Sub
    End Class
End Namespace
