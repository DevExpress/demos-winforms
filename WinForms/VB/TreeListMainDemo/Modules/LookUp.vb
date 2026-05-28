Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.DXperience.Demos
Imports DevExpress.Internal
Imports DevExpress.XtraTreeList.ViewInfo

Namespace DevExpress.XtraTreeList.Demos

    Public Partial Class LookUp
        Inherits TutorialControl

        Private lookUpProperties As RepositoryItemTreeListLookUpEdit

        Private _treeList As TreeList

        Public Sub New()
            InitializeComponent()
            InitProjectsData()
            InitSpaceObjectsData()
            InitProperties()
            CreateTimer()
        '<treeList1>
        ' 
        ' ~Note: the following properties are set at design time and listed here only for demonstration purposes.
        ' ~Assign a TreeListLookUpEdit control as an in-place editor to the Owner column:
        ' colOwner.ColumnEdit = repositoryItemTreeListLookUpEdit1;
        ' ~Set key fields to create a data hierarchy:
        ' repositoryItemTreeListLookUpEdit1.TreeList.KeyFieldName = "ID";
        ' repositoryItemTreeListLookUpEdit1.TreeList.ParentFieldName = "ParentID";
        ' 
        '</treeList1>
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"TreeListMainDemo\Modules\LookUp"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "LookUp"
            End Get
        End Property

        Protected Overrides Sub OnUseEmptyRootPadding()
        End Sub

        Protected Overrides Sub OnTick()
            If ModulesInfo.CurrentModule Is Me Then
                treeListLookUpEdit1.MenuManager = RibbonMenuManager.Manager
                treeListLookUpEdit1.ShowPopup()
            End If

            MyBase.OnTick()
        End Sub

        Protected Overrides Sub DoHide()
            MyBase.DoHide()
            treeListLookUpEdit1?.ClosePopup()
        End Sub

        Public Overrides ReadOnly Property MainControl As TreeList
            Get
                Return treeList1
            End Get
        End Property

        Private updateValues As Boolean = False

        Private Sub InitProperties()
            lookUpProperties = treeListLookUpEdit1.Properties
            _treeList = treeListLookUpEdit1TreeList
            updateValues = True
            lbDisplay.Text = lookUpProperties.DisplayMember
            lbValue.Text = lookUpProperties.ValueMember
            icbTextEditStyle.EditValue = lookUpProperties.TextEditStyle
            For Each style As TextEditStyles In [Enum].GetValues(GetType(TextEditStyles))
                icbTextEditStyle.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of TextEditStyles).GetTitle(style), style, -1))
            Next

            ceAutoComplete.Checked = lookUpProperties.AutoComplete
            ceImmediatePopup.Checked = lookUpProperties.ImmediatePopup
            cePopupSizeable.Checked = lookUpProperties.PopupSizeable
            ceShowPopupFooter.Checked = lookUpProperties.ShowFooter
            ceShowAutoFilterRow.Checked = _treeList.OptionsView.ShowAutoFilterRow
            ceShowColumnHeaders.Checked = _treeList.OptionsView.ShowColumns
            ceShowIndicator.Checked = _treeList.OptionsView.ShowIndicator
            ceEnableAppearanceEvenRow.Checked = _treeList.OptionsView.EnableAppearanceEvenRow
            ceEnableAppearanceOddRow.Checked = _treeList.OptionsView.EnableAppearanceOddRow
            cePopupSizeable.Enabled = lookUpProperties.ShowFooter
            updateValues = False
        End Sub

        '<treeList1>
        Private Sub InitProjectsData()
            Dim DBFileName As String = DataDirectoryHelper.GetDataFile("EmployeesGroups.xml")
            If Not Equals(DBFileName, "") Then
                Dim dataSet As DataSet = New DataSet()
                dataSet.ReadXml(DBFileName)
                dataSet.Tables(0).Columns.Add("FullName", GetType(String), "FirstName + ' ' + LastName")
                repositoryItemTreeListLookUpEdit1.DataSource = dataSet.Tables(0).DefaultView
                repositoryItemTreeListLookUpEdit1.DisplayMember = "FullName"
                repositoryItemTreeListLookUpEdit1.ValueMember = "Id"
                treeList1.ExpandAll()
            End If
        End Sub

        '</treeList1>
        '<treeListLookUpEdit1>
        Private spaceObjectsTable As DataTable

        Private Sub InitSpaceObjectsData()
            Dim DBFileName As String = DataDirectoryHelper.GetDataFile("EmployeesGroups.xml")
            If Not Equals(DBFileName, "") Then
                Dim dataSet As DataSet = New DataSet()
                dataSet.ReadXml(DBFileName)
                spaceObjectsTable = dataSet.Tables(0)
                dataSet.Tables(0).Columns.Add("FullName", GetType(String), "FirstName + ' ' + LastName")
                spaceObjectsTable.PrimaryKey = New DataColumn() {spaceObjectsTable.Columns("ID")}
                treeListLookUpEdit1.Properties.DataSource = spaceObjectsTable
                treeListLookUpEdit1.Properties.DisplayMember = "FullName"
                treeListLookUpEdit1.Properties.ValueMember = "Id"
                dataNavigator1.DataSource = spaceObjectsTable
                treeListLookUpEdit1.DataBindings.Add(New Binding("EditValue", spaceObjectsTable, "ID", False, DataSourceUpdateMode.Never))
            End If
        End Sub

        Private Sub treeListLookUpEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim editvalue As Object = treeListLookUpEdit1.EditValue
            If editvalue Is Nothing OrElse editvalue.GetType() IsNot GetType(Integer) Then Return
            Dim position As Integer = spaceObjectsTable.Rows.IndexOf(spaceObjectsTable.Rows.Find(CInt(editvalue)))
            If position > -1 Then dataNavigator1.Position = position
        End Sub

        '</treeListLookUpEdit1>
        Private currentGroupName As String

        Private Sub treeList1_GetStateImage(ByVal sender As Object, ByVal e As GetStateImageEventArgs)
            Dim groupNames As String() = New String() {"Administration", "Inventory", "Manufacturing", "Quality", "Research", "Sales"}
            currentGroupName = CStr(e.Node.GetValue("GroupName"))
            e.NodeImageIndex = Array.FindIndex(groupNames, New Predicate(Of String)(AddressOf IsCurrentGroupName))
        End Sub

        Private Function IsCurrentGroupName(ByVal groupName As String) As Boolean
            Return currentGroupName.Contains(groupName)
        End Function

        '<icbTextEditStyle>
        Private Sub icbTextEditStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            lookUpProperties.TextEditStyle = CType(icbTextEditStyle.EditValue, TextEditStyles)
        End Sub

        '</icbTextEditStyle>
        '<ceAutoComplete>
        Private Sub ceAutoComplete_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            lookUpProperties.AutoComplete = ceAutoComplete.Checked
        End Sub

        '</ceAutoComplete>
        '<ceImmediatePopup>
        Private Sub ceImmediatePopup_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            lookUpProperties.ImmediatePopup = ceImmediatePopup.Checked
        End Sub

        '</ceImmediatePopup>
        '<cePopupSizeable>
        Private Sub cePopupSizeable_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            lookUpProperties.PopupSizeable = cePopupSizeable.Checked
        End Sub

        '</cePopupSizeable>
        '<ceShowPopupFooter>
        Private Sub ceShowPopupFooter_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            lookUpProperties.ShowFooter = ceShowPopupFooter.Checked
            cePopupSizeable.Enabled = lookUpProperties.ShowFooter
        End Sub

        '</ceShowPopupFooter>
        '<ceShowAutoFilterRow>
        Private Sub ceShowAutoFilterRow_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            _treeList.OptionsView.ShowAutoFilterRow = ceShowAutoFilterRow.Checked
        End Sub

        '</ceShowAutoFilterRow>
        '<ceShowColumnHeaders>
        Private Sub ceShowColumnHeaders_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            _treeList.OptionsView.ShowColumns = ceShowColumnHeaders.Checked
        End Sub

        '</ceShowColumnHeaders>
        '<ceShowIndicator>
        Private Sub ceShowIndicator_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            _treeList.OptionsView.ShowIndicator = ceShowIndicator.Checked
        End Sub

        '</ceShowIndicator>
        '<ceEnableAppearanceEvenRow>
        Private Sub ceEnableAppearanceEvenRow_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            _treeList.OptionsView.EnableAppearanceEvenRow = ceEnableAppearanceEvenRow.Checked
        End Sub

        '</ceEnableAppearanceEvenRow>
        '<ceEnableAppearanceOddRow>
        Private Sub ceEnableAppearanceOddRow_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            _treeList.OptionsView.EnableAppearanceOddRow = ceEnableAppearanceOddRow.Checked
        End Sub

        '</ceEnableAppearanceOddRow>
        Private Sub toolTipController1_GetActiveObjectInfo(ByVal sender As Object, ByVal e As Utils.ToolTipControllerGetActiveObjectInfoEventArgs)
            If TypeOf e.SelectedControl Is TreeList Then
                Dim tree As TreeList = CType(e.SelectedControl, TreeList)
                Dim hit As TreeListHitInfo = tree.CalcHitInfo(e.ControlMousePosition)
                If hit.HitInfoType = HitInfoType.Cell Then
                    Dim tooltip As String
                    If hit.Column Is tree.Columns("Name") OrElse hit.Column Is tree.Columns("TypeOfObject") Then
                        tooltip = String.Format("{0}", hit.Column.Caption)
                    ElseIf hit.Column Is tree.Columns("ImageData") Then
                        tooltip = "Image: Courtesy NASA/JPL-Caltec"
                    Else
                        tooltip = String.Format("{0} by Earth", hit.Column.Caption)
                    End If

                    e.Info = New Utils.ToolTipControlInfo(New TreeListCellToolTipInfo(hit.Node, hit.Column, Nothing), tooltip)
                End If
            End If
        End Sub
    End Class
End Namespace
