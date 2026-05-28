Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors.Repository
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class InplaceEditors
        Inherits TutorialControl

        <FlagsAttribute>
        Friend Enum Colors
            None = 0
            Red = 1
            Green = 2
            Blue = 4
            Yellow = 8
            Black = 16
        End Enum

        '<gridControl1>
        Private gridEditors As GridEditorCollection

        '</gridControl1>
        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            gridView1.OptionsMenu.ShowAutoFilterRowItem = False
            'TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\InplaceEditors.cs";
            'TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraEditors.Demos.CodeInfo.InplaceEditors.xml";
            InitLookUpDataTable()
            repositoryItemCheckedComboBoxEdit1.SetFlags(GetType(Colors))
            '<gridControl1>
            gridEditors = New GridEditorCollection()
            InitInplaceEditors()
            gridControl1.DataSource = gridEditors
            '</gridControl1>
            gridPopup.ForceInitialize()
        End Sub

        Private Sub AddRecordToLookUpDataTable(ByVal fName As String, ByVal department As String)
            Dim row As DataRow = dataTableLookUp.NewRow()
            row("clnId") = dataTableLookUp.Rows.Count + 1
            row("clnName") = fName
            row("clnDepartment") = department
            dataTableLookUp.Rows.Add(row)
        End Sub

        Private Sub InitLookUpDataTable()
            AddRecordToLookUpDataTable("Paul Bailey", Properties.Resources.Management)
            AddRecordToLookUpDataTable("Brad Barnes", Properties.Resources.QA)
            AddRecordToLookUpDataTable("Jerry Campbell", Properties.Resources.RD)
            AddRecordToLookUpDataTable("Carl Lucas", Properties.Resources.Documentation)
            AddRecordToLookUpDataTable("Peter Dolan", Properties.Resources.Marketing)
            AddRecordToLookUpDataTable("Ryan Fischer", Properties.Resources.RD)
            AddRecordToLookUpDataTable("Ricard Fischer", Properties.Resources.Marketing)
            AddRecordToLookUpDataTable("Tom Hamlett", Properties.Resources.RD)
            AddRecordToLookUpDataTable("Mark Hamilton", Properties.Resources.QA)
            AddRecordToLookUpDataTable("Steve Lee", Properties.Resources.RD)
            AddRecordToLookUpDataTable("Jimmy Lewis", Properties.Resources.Support)
            AddRecordToLookUpDataTable("Jeffrey McClain", Properties.Resources.RD)
            AddRecordToLookUpDataTable("Andrew Miller", Properties.Resources.Documentation)
            AddRecordToLookUpDataTable("Dave Murrel", Properties.Resources.QA)
            AddRecordToLookUpDataTable("Bert Parkins", Properties.Resources.RD)
            AddRecordToLookUpDataTable("Mike Roller", Properties.Resources.RD)
            AddRecordToLookUpDataTable("Ray Shipman", Properties.Resources.Support)
        End Sub

        '<gridControl1>
        Private Sub InitInplaceEditors()
            gridEditors.Add(repositoryItemTextEdit, Properties.Resources.TextEdit, Properties.Resources.TextEditText)
            gridEditors.Add(repositoryItemButtonEdit, Properties.Resources.ButtonEdit, Properties.Resources.ClickMe)
            gridEditors.Add(repositoryItemCheckEdit, Properties.Resources.CheckEdit, False)
            gridEditors.Add(repositoryItemSpinEdit, Properties.Resources.SpinEdit, 20)
            gridEditors.Add(repositoryItemDateEdit, Properties.Resources.DateEdit, TutorialConstants.Now)
            gridEditors.Add(repositoryItemTimeEdit, Properties.Resources.TimeEdit, TutorialConstants.Now)
            gridEditors.Add(repositoryItemLookUpEdit, Properties.Resources.LookUpEdit, 3)
            gridEditors.Add(repositoryItemPopupContainerEdit, Properties.Resources.PopupContainer, 3)
            gridEditors.Add(repositoryItemProgressBar, Properties.Resources.ProgressBar, 30)
            gridEditors.Add(repositoryItemComboBox, Properties.Resources.ComboBox, "United States")
            gridEditors.Add(repositoryItemImageComboBox, Properties.Resources.ImageComboBox, 2)
            gridEditors.Add(repositoryItemMRUEdit, Properties.Resources.MRUEdit, Properties.Resources.MRUQuestion)
            gridEditors.Add(repositoryItemPictureEdit, Properties.Resources.Picture, pictureBox1.Image)
            gridEditors.Add(repositoryItemMemoEdit, Properties.Resources.MemoEdit, Properties.Resources.MemoText)
            gridEditors.Add(repositoryItemImageEdit, Properties.Resources.ImageEdit, pictureBox1.Image)
            gridEditors.Add(repositoryItemMemoExEdit, Properties.Resources.MemoExEdit, Properties.Resources.MemoText)
            gridEditors.Add(repositoryItemRadioGroup, Properties.Resources.RadioGroup, 1)
            gridEditors.Add(repositoryItemHyperLinkEdit, Properties.Resources.Hyperlink, "http://www.devexpress.com")
            gridEditors.Add(repositoryItemCalcEdit, Properties.Resources.Calculator, 100.25)
            gridEditors.Add(repositoryItemColorEdit, Properties.Resources.ColorEdit, System.Drawing.Color.Blue)
            gridEditors.Add(repositoryItemTrackBar1, Properties.Resources.TrackBar, 4)
            gridEditors.Add(repositoryItemFontEdit1, Properties.Resources.FontEdit, Font.FontFamily.GetName(0))
            gridEditors.Add(repositoryItemCheckedComboBoxEdit1, Properties.Resources.CheckedComboBox, Colors.Red Or Colors.Blue Or Colors.Yellow)
        End Sub

        '</gridControl1>
        '<gridControl1>
        Private Sub gridView1_CustomRowCellEdit(ByVal sender As Object, ByVal e As XtraGrid.Views.Grid.CustomRowCellEditEventArgs)
            If e.Column Is gridEditorValue Then
                Dim item As GridEditorItem = TryCast(gridView1.GetRow(e.RowHandle), GridEditorItem)
                If item IsNot Nothing Then e.RepositoryItem = item.RepositoryItem
            End If
        End Sub

        '</gridControl1>
        Private Sub repositoryItemButtonEdit_ButtonClick(ByVal sender As Object, ByVal e As XtraEditors.Controls.ButtonPressedEventArgs)
            XtraMessageBox.Show(Properties.Resources.ButtonMessage, Application.ProductName)
        End Sub

        Private Function PopupContainerUserByID(ByVal id As Object) As String
            For Each row As DataRow In dataTableLookUp.Rows
                If row("clnId").Equals(id) Then Return row("clnName").ToString()
            Next

            Return ""
        End Function

        Private Sub PopupContainerFindRowByEditValue()
            If popupContainerControl.OwnerEdit Is Nothing Then Return
            Dim row As DataRowView
            For i As Integer = 0 To dataTableLookUp.DefaultView.Count - 1
                row = dataTableLookUp.DefaultView(i)
                If row.Row("clnId").Equals(popupContainerControl.OwnerEdit.EditValue) Then
                    For k As Integer = 0 To gridView1Popup.DataRowCount - 1
                        If gridView1Popup.GetRow(k) Is row Then
                            gridView1Popup.FocusedRowHandle = k
                            Return
                        End If
                    Next
                End If
            Next
        End Sub

        Private Sub PopupContainerClosePopup()
            If popupContainerControl.OwnerEdit IsNot Nothing Then popupContainerControl.OwnerEdit.ClosePopup()
        End Sub

        Private Sub repositoryItemPopupContainerEdit_QueryDisplayText(ByVal sender As Object, ByVal e As XtraEditors.Controls.QueryDisplayTextEventArgs)
            e.DisplayText = PopupContainerUserByID(e.EditValue)
        End Sub

        Private Sub repositoryItemPopupContainerEdit_QueryResultValue(ByVal sender As Object, ByVal e As XtraEditors.Controls.QueryResultValueEventArgs)
            If gridView1Popup.FocusedRowHandle >= 0 Then e.Value = gridView1Popup.GetDataRow(gridView1Popup.FocusedRowHandle)("clnId")
        End Sub

        Private Sub repositoryItemPopupContainerEdit_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            PopupContainerFindRowByEditValue()
        End Sub

        Private Sub gridPopup_BindingContextChanged(ByVal sender As Object, ByVal e As EventArgs)
            PopupContainerFindRowByEditValue()
        End Sub

        Private Sub gridView1Popup_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If e.KeyCode = Keys.Enter Then PopupContainerClosePopup()
        End Sub

        Private Sub gridView1Popup_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim info As XtraGrid.Views.Grid.ViewInfo.GridHitInfo = gridView1Popup.CalcHitInfo(gridPopup.PointToClient(MousePosition))
            If info.InRow Then PopupContainerClosePopup()
        End Sub

        Private Sub gridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As XtraGrid.Views.Base.FocusedRowChangedEventArgs)
            Dim item As GridEditorItem = TryCast(gridView1.GetRow(e.FocusedRowHandle), GridEditorItem)
            propertyGridPanel.PropertyGrid.SelectedObject = item.RepositoryItem
            tabNavigationPage1.Text = String.Format("{0} {1}", item.Name, Properties.Resources.Properties)
        End Sub

        Private Sub repositoryItemMRUEdit_ButtonClick(ByVal sender As Object, ByVal e As XtraEditors.Controls.ButtonPressedEventArgs)
            Dim edit As MRUEdit = TryCast(sender, MRUEdit)
            If edit.Properties.Buttons.IndexOf(e.Button) <> edit.Properties.ActionButtonIndex Then
                Dim dlg As ColorDialog = New ColorDialog()
                If dlg.ShowDialog() = DialogResult.OK Then
                    Dim c As Color = dlg.Color
                    Dim colorName As String = If(c.IsNamedColor, c.Name, c.ToString())
                    edit.EditValue = colorName
                    edit.Properties.Items.Add(edit.Text)
                End If
            End If
        End Sub
    End Class

    '<gridControl1>
    Public Class GridEditorItem

        Private fName As String

        Private fValue As Object

        Private fRepositoryItem As RepositoryItem

        Public Sub New(ByVal fRepositoryItem As RepositoryItem, ByVal fName As String, ByVal fValue As Object)
            Me.fRepositoryItem = fRepositoryItem
            Me.fName = fName
            Me.fValue = fValue
        End Sub

        Public ReadOnly Property Name As String
            Get
                Return fName
            End Get
        End Property

        Public Property Value As Object
            Get
                Return fValue
            End Get

            Set(ByVal value As Object)
                fValue = value
            End Set
        End Property

        Public ReadOnly Property RepositoryItem As RepositoryItem
            Get
                Return fRepositoryItem
            End Get
        End Property
    End Class

    Friend Class GridEditorCollection
        Inherits ArrayList

        Public Sub New()
        End Sub

        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As GridEditorItem
            Get
                Return TryCast(MyBase.Item(index), GridEditorItem)
            End Get
        End Property

        Public Overloads Sub Add(ByVal fRepositoryItem As RepositoryItem, ByVal fName As String, ByVal fValue As Object)
            MyBase.Add(New GridEditorItem(fRepositoryItem, fName, fValue))
        End Sub
    End Class
'</gridControl1>
End Namespace
