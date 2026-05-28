Imports System
Imports System.Data
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.FilterEditor
Imports DevExpress.XtraLayout.Utils

Namespace DevExpress.XtraGrid.Demos

    ''' <summary>
    ''' Summary description for FilterControl.
    ''' </summary>
    Public Partial Class FilterControl
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            InitializeComponent()
            ' TODO: Add any initialization after the InitForm call
            filterControl1.FilterControl.UseLeftIndent = False
            filterControl2.UseLeftIndent = False
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"FilterControl"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "FilterControl"
            End Get
        End Property

        Private initProperties As Boolean = False

        Private Sub FilterControl_Load(ByVal sender As Object, ByVal e As EventArgs)
            filterControl1.MenuManager = gridControl1.MenuManager
            InitNWindData()
            gridColumnProduct.FilterInfo = New ColumnFilterInfo("[ProductID] between ('Alice Munton', 'Iqura')")
            gridColumnDiscount.FilterInfo = New ColumnFilterInfo("IsBlackFridayDiscount([Discount])")
            InitOptions()
            InitCustomFilterControl()
            gridColumnImplemented.FilterInfo = New ColumnFilterInfo("[Implemented] >= 50")
            gridColumnSuspended.FilterInfo = New ColumnFilterInfo("[Suspended] = False")
            ResetCustomFilter()
            '<filterControl1>
            ' 
            ' ~Note: the following code is set at design-time and is listed here for educational purposes only.
            ' filterControl1.SourceControl = gridControl1;
            ' 
            '</filterControl1>
            AddHandler filterControl1.FilterControl.QueryCustomFunctions, AddressOf OnQueryCustomFunctions
            AddHandler gridView1.QueryCustomFunctions, AddressOf OnQueryCustomFunctions
        End Sub

        Private Sub InitOptions()
            initProperties = True
            ceEmptyValue.Color = filterControl1.AppearanceEmptyValueColor
            ceFieldName.Color = filterControl1.AppearanceFieldNameColor
            ceGroupOperator.Color = filterControl1.AppearanceGroupOperatorColor
            ceOperator.Color = filterControl1.AppearanceOperatorColor
            ceValue.Color = filterControl1.AppearanceValueColor
            seLevelIndent.Value = filterControl1.LevelIndent
            seSeparatorHeight.Value = filterControl1.NodeSeparatorHeight
            ceGroupCommandsIcon.Checked = filterControl1.ShowGroupCommandsIcon
            ceOperandTypeIcon.Checked = filterControl1.ShowOperandTypeIcon
            ceToolTips.Checked = filterControl1.ShowToolTips
            For Each mode As FilterEditorViewMode In [Enum].GetValues(GetType(FilterEditorViewMode))
                icbViewMode.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of FilterEditorViewMode).GetTitle(mode), mode, -1))
            Next

            icbViewMode.EditValue = filterControl1.ViewMode
            icbDisplayStyle.Properties.AddEnum(Of FilterCriteriaDisplayStyle)()
            icbDisplayStyle.EditValue = FilterCriteriaDisplayStyle.Visual
            gridView1.OptionsFilter.DefaultFilterEditorView = filterControl1.ViewMode
            initProperties = False
        End Sub

        Private tblGrid As String = "Order Details"

        Private tblLookUp As String = "Products"

        Protected Overrides Function InitNWindXMLData(ByVal dataFileName As String) As DataSet
            Dim ds As DataSet = New DataSet()
            ds.ReadXml(dataFileName)
            gridControl1.DataSource = ds.Tables(tblGrid)
            repositoryItemLookUpEdit1.DataSource = ds.Tables(tblLookUp)
            Return ds
        End Function

        Protected Overrides Sub InitNWindData()
            MyBase.InitNWindData()
            gridControl2.DataSource = OutlookData.CreateIssueList()
        End Sub

        '<sbApply>
        Private Sub sbApply_Click(ByVal sender As Object, ByVal e As EventArgs)
            filterControl1.ApplyFilter()
        End Sub

        '</sbApply>
        '<ceEmptyValue>
        Private Sub ceEmptyValue_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If initProperties Then Return
            filterControl1.AppearanceEmptyValueColor = ceEmptyValue.Color
        End Sub

        '</ceEmptyValue>
        '<ceFieldName>
        Private Sub ceFieldName_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If initProperties Then Return
            filterControl1.AppearanceFieldNameColor = ceFieldName.Color
        End Sub

        '</ceFieldName>
        '<ceGroupOperator>
        Private Sub ceGroupOperator_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If initProperties Then Return
            filterControl1.AppearanceGroupOperatorColor = ceGroupOperator.Color
        End Sub

        '</ceGroupOperator>
        '<ceOperator>
        Private Sub ceOperator_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If initProperties Then Return
            filterControl1.AppearanceOperatorColor = ceOperator.Color
        End Sub

        '</ceOperator>
        '<ceValue>
        Private Sub ceValue_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If initProperties Then Return
            filterControl1.AppearanceValueColor = ceValue.Color
        End Sub

        '</ceValue>
        '<seLevelIndent>
        Private Sub seLevelIndent_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If initProperties Then Return
            filterControl1.LevelIndent = Convert.ToInt32(seLevelIndent.Value)
        End Sub

        '</seLevelIndent>
        '<seSeparatorHeight>
        Private Sub seSeparatorHeight_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If initProperties Then Return
            filterControl1.NodeSeparatorHeight = Convert.ToInt32(seSeparatorHeight.Value)
        End Sub

        '</seSeparatorHeight>
        '<ceGroupCommandsIcon>
        Private Sub ceGroupCommandsIcon_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If initProperties Then Return
            filterControl1.ShowGroupCommandsIcon = ceGroupCommandsIcon.Checked
        End Sub

        '</ceGroupCommandsIcon>
        '<ceOperandTypeIcon>
        Private Sub ceOperandTypeIcon_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If initProperties Then Return
            filterControl1.ShowOperandTypeIcon = ceOperandTypeIcon.Checked
        End Sub

        '</ceOperandTypeIcon>
        '<ceToolTips>
        Private Sub ceToolTips_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If initProperties Then Return
            filterControl1.ShowToolTips = ceToolTips.Checked
        End Sub

        '</ceToolTips>
        Private Sub InitCustomFilterControl()
            Dim columnCollection As ViewFilterColumnCollection = New ViewFilterColumnCollection(gridView2)
            CustomizationFilterColumnCollection(columnCollection)
            filterControl2.SetFilterColumnsCollection(columnCollection, gridControl2.MenuManager)
            filterControl2.SetDefaultColumn(GridCriteriaHelper.GetFilterColumnByGridColumn(filterControl2.FilterColumns, gridColumnImplemented))
            filterControl2.FilterString = gridView2.ActiveFilterString
        End Sub

        '<sbApplyFilter2>
        Private Sub sbApplyFilter2_Click(ByVal sender As Object, ByVal e As EventArgs)
            gridView2.ActiveFilterString = filterControl2.FilterString
        End Sub

        '</sbApplyFilter2>
        '<sbReset>
        Private Sub sbReset_Click(ByVal sender As Object, ByVal e As EventArgs)
            ResetCustomFilter()
        End Sub

        Private Sub ResetCustomFilter()
            filterControl2.FilterString = gridView2.ActiveFilterString
        End Sub

        '</sbReset>
        Private Sub CustomizationFilterColumnCollection(ByVal columnCollection As ViewFilterColumnCollection)
            columnCollection.RemoveAt(0)
            Dim col As GridFilterColumn = TryCast(columnCollection("Implemented"), GridFilterColumn)
            Dim tbItem As RepositoryItemTrackBar = New RepositoryItemTrackBar()
            tbItem.Maximum = 100
            tbItem.TickFrequency = 10
            col.SetRepositoryItem(tbItem)
            col = TryCast(columnCollection("Suspended"), GridFilterColumn)
            Dim icbItem As RepositoryItemImageComboBox = New RepositoryItemImageComboBox()
            icbItem.SmallImages = imageCollection1
            icbItem.Items.Add(New ImageComboBoxItem("Checked", True, 0))
            icbItem.Items.Add(New ImageComboBoxItem("Unchecked", False, 1))
            col.SetRepositoryItem(icbItem)
        End Sub

        '<icbViewMode>
        Private Sub icbViewMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If initProperties Then Return
            filterControl1.ViewMode = CType(icbViewMode.EditValue, FilterEditorViewMode)
            gridView1.OptionsFilter.DefaultFilterEditorView = filterControl1.ViewMode
        End Sub

        '</icbViewMode>
        Private Sub tabPane1_SelectedPageChanged(ByVal sender As Object, ByVal e As XtraBars.Navigation.SelectedPageChangedEventArgs)
            sidePanel1.Visible = e.Page Is tabPage1
        End Sub

        Private Sub OnQueryCustomFunctions(ByVal sender As Object, ByVal e As Data.Filtering.CustomFunctionEventArgs)
            If e.PropertyType Is GetType(Date) OrElse e.PropertyType Is GetType(Date?) Then
                e.Add(IsWeekendFunction.FunctionName)
                e.Add(DaysBeforeOrAfterTodayFunction.FunctionName)
            End If

            If Equals(e.PropertyName, "Discount") Then e.Add(IsBlackFridayDiscountFunction.FunctionName)
        End Sub

        '<icbDisplayStyle>
        Private Sub icbDisplayStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim style As FilterCriteriaDisplayStyle = CType(icbDisplayStyle.EditValue, FilterCriteriaDisplayStyle)
            gridView1.OptionsView.FilterCriteriaDisplayStyle = style
            filterControl1.LayoutChanged()
            lgColors.Visibility = If(style = FilterCriteriaDisplayStyle.Visual, LayoutVisibility.Never, LayoutVisibility.Always)
        End Sub
    '</icbDisplayStyle>
    End Class
End Namespace
