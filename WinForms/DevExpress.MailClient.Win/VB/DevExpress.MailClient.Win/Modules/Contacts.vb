Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.MailClient.Win.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Namespace DevExpress.MailClient.Win
    Partial Public Class Contacts
        Inherits BaseModule

        Public Overrides ReadOnly Property ModuleName() As String
            Get
                Return My.Resources.ContactsName
            End Get
        End Property
        '
        Public Sub New()
            InitializeComponent()
            EditorHelper.InitTitleComboBox(repositoryItemImageComboBox1)
            gridControl1.DataSource = DataHelper.Contacts
            gridView1.ShowFindPanel()
            InitIndex(DataHelper.Contacts)
        End Sub
        Protected Overrides ReadOnly Property Grid() As DevExpress.XtraGrid.GridControl
            Get
                Return gridControl1
            End Get
        End Property
        Protected Overrides ReadOnly Property AllowZoomControl() As Boolean
            Get
                Return True
            End Get
        End Property
        Public Overrides Property ZoomFactor() As Single
            Get
                Return ucContactInfo1.ZoomFactor
            End Get
            Set(ByVal value As Single)
                ucContactInfo1.ZoomFactor = value
                SetZoomCaption()
            End Set
        End Property
        Protected Overrides Sub SetZoomCaption()
            MyBase.SetZoomCaption()
            If ZoomFactor = 1 Then
                OwnerForm.ZoomManager.SetZoomCaption(My.Resources.Picture100Zoom)
            End If
        End Sub
        Friend Overrides Sub ShowModule(ByVal firstShow As Boolean)
            MyBase.ShowModule(firstShow)
            gridControl1.Focus()
            UpdateActionButtons()
            If firstShow Then
                gridControl1.ForceInitialize()
                GridHelper.SetFindControlImages(gridControl1)
                If DataHelper.Contacts.Count = 0 Then
                    UpdateCurrentContact()
                End If
            End If
        End Sub
        Private Sub UpdateActionButtons()
            OwnerForm.EnableLayoutButtons(gridControl1.MainView IsNot layoutView1)
            OwnerForm.EnableZoomControl(gridControl1.MainView IsNot layoutView1)
        End Sub
        Private ReadOnly Property CurrentContact() As Contact
            Get
                Return TryCast(CType(gridControl1.MainView, ColumnView).GetFocusedRow(), Contact)
            End Get
        End Property
        Private Sub gridView1_ColumnFilterChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gridView1.ColumnFilterChanged
            UpdateCurrentContact()
        End Sub
        Private Sub gridView1_FocusedRowObjectChanged(ByVal sender As Object, ByVal e As FocusedRowObjectChangedEventArgs) Handles gridView1.FocusedRowObjectChanged
            If e.FocusedRowHandle = GridControl.AutoFilterRowHandle Then
                gridView1.FocusedColumn = colName
            ElseIf e.FocusedRowHandle >= 0 Then
                gridView1.FocusedColumn = Nothing
            End If
            UpdateCurrentContact()
        End Sub
        Private Sub UpdateCurrentContact()
            ucContactInfo1.Init(CurrentContact, Nothing)
            If gridControl1.MainView Is gridView1 Then
                gridView1.MakeRowVisible(gridView1.FocusedRowHandle)
            End If
            OwnerForm.EnableEditContact(CurrentContact IsNot Nothing)
        End Sub
        Protected Friend Overrides Sub ButtonClick(ByVal tag As String)
            Select Case tag
                Case TagResources.ContactList
                    UpdateMainView(gridView1)
                    ClearSortingAndGrouping()
                Case TagResources.ContactAlphabetical
                    UpdateMainView(gridView1)
                    ClearSortingAndGrouping()
                    colName.Group()
                Case TagResources.ContactByState
                    UpdateMainView(gridView1)
                    ClearSortingAndGrouping()
                    colState.Group()
                    colCity.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
                Case TagResources.ContactCard
                    UpdateMainView(layoutView1)
                Case TagResources.FlipLayout
                    layoutControl1.Root.FlipLayout()
                Case TagResources.ContactDelete
                    If CurrentContact Is Nothing Then
                        Return
                    End If
                    Dim index As Integer = gridView1.FocusedRowHandle
                    gridControl1.MainView.BeginDataUpdate()
                    Try
                        DataHelper.Contacts.Remove(CurrentContact)
                    Finally
                        gridControl1.MainView.EndDataUpdate()
                    End Try
                    If index > gridView1.DataRowCount - 1 Then
                        index -= 1
                    End If
                    gridView1.FocusedRowHandle = index
                    ShowInfo(gridView1)
                Case TagResources.ContactNew
                    Dim contact As New Contact()
                    If EditContact(contact) = DialogResult.OK Then
                        gridControl1.MainView.BeginDataUpdate()
                        Try
                            DataHelper.Contacts.Add(contact)
                        Finally
                            gridControl1.MainView.EndDataUpdate()
                        End Try
                        Dim view As ColumnView = TryCast(gridControl1.MainView, ColumnView)
                        If view IsNot Nothing Then
                            GridHelper.GridViewFocusObject(view, contact)
                            ShowInfo(view)
                        End If
                    End If
                Case TagResources.ContactEdit
                    EditContact(CurrentContact)
            End Select
            UpdateCurrentContact()
            UpdateInfo()
        End Sub
        Private Sub UpdateMainView(ByVal view As ColumnView)
            Dim isGrid As Boolean = TypeOf view Is GridView
            gridControl1.MainView = view
            splitterItem1.Visibility = If(isGrid, DevExpress.XtraLayout.Utils.LayoutVisibility.Always, DevExpress.XtraLayout.Utils.LayoutVisibility.Never)
            layoutControlItem2.Visibility = If(isGrid, DevExpress.XtraLayout.Utils.LayoutVisibility.Always, DevExpress.XtraLayout.Utils.LayoutVisibility.Never)
            GridHelper.SetFindControlImages(gridControl1)
            UpdateActionButtons()
        End Sub
        Private Sub ClearSortingAndGrouping()
            gridView1.ClearGrouping()
            gridView1.ClearSorting()
        End Sub
        Private Sub gridView1_RowCellClick(ByVal sender As Object, ByVal e As RowCellClickEventArgs) Handles gridView1.RowCellClick
            If e.Button = MouseButtons.Left AndAlso e.RowHandle >= 0 AndAlso e.Clicks = 2 Then
                EditContact(CurrentContact)
            End If
        End Sub
        Private Sub gridView1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gridView1.KeyDown
            If e.KeyData = Keys.Enter AndAlso gridView1.FocusedRowHandle >= 0 Then
                EditContact(CurrentContact)
            End If
        End Sub
        Private Sub layoutView1_CardClick(ByVal sender As Object, ByVal e As XtraGrid.Views.Layout.Events.CardClickEventArgs) Handles layoutView1.CardClick
            If e.Button = MouseButtons.Left AndAlso e.RowHandle >= 0 AndAlso e.Clicks = 2 Then
                EditContact(CurrentContact)
                layoutView1.UpdateCurrentRow()
            End If
        End Sub
        Private Function EditContact(ByVal contact As Contact) As DialogResult
            If contact Is Nothing Then
                Return DialogResult.Ignore
            End If
            Dim result As DialogResult = DialogResult.Cancel
            Cursor.Current = Cursors.WaitCursor
            Using frm As New frmEditContact(contact, OwnerForm.Ribbon)
                result = frm.ShowDialog(OwnerForm)
            End Using
            UpdateCurrentContact()
            Cursor.Current = Cursors.Default
            Return result
        End Function
        Private Sub UpdateInfo()
            ShowInfo(TryCast(gridControl1.MainView, ColumnView))
        End Sub
        Private Sub layoutView1_ColumnFilterChanged(ByVal sender As Object, ByVal e As EventArgs) Handles layoutView1.ColumnFilterChanged
            UpdateInfo()
        End Sub
        Private Sub repositoryItemHyperLinkEdit1_OpenLink(ByVal sender As Object, ByVal e As OpenLinkEventArgs) Handles repositoryItemHyperLinkEdit1.OpenLink
            If e.EditValue IsNot Nothing Then
                e.EditValue = "mailto:" & e.EditValue.ToString()
            End If
        End Sub
        Protected Sub InitIndex(ByVal list As List(Of Contact))
            SetupGrid(Generate(list, Function(c) AlphaIndex.Group(c.LastName)), indexGridControl)
        End Sub
        Public Sub SetupGrid(ByVal list As List(Of AlphaIndex), ByVal grid As GridControl)
            Dim view As GridView = TryCast(grid.MainView, GridView)
            view.Columns.AddVisible("Index")
            grid.DataSource = list
            AddHandler view.FocusedRowChanged, AddressOf view_FocusedRowChanged
        End Sub
        Private alphaChange As Timer = Nothing
        Private Sub view_FocusedRowChanged(ByVal sender As Object, ByVal e As FocusedRowChangedEventArgs)
            If alphaChange IsNot Nothing Then
                alphaChange.Dispose()
            End If
            alphaChange = New Timer()
            alphaChange.Interval = 200
            AddHandler alphaChange.Tick, Sub(s, ea)
                CType(s, Timer).Stop()
                Dim focusedIndex = TryCast(DirectCast(sender, GridView).GetFocusedRow(), AlphaIndex)
                gridControl1.DataSource = ApplyFilter(DataHelper.Contacts, focusedIndex)
                CType(s, Timer).Dispose()
                Me.alphaChange = Nothing
                UpdateInfo()
            End Sub
            alphaChange.Start()
        End Sub
        Private Function ApplyFilter(ByVal list As List(Of Contact), ByVal alpha As AlphaIndex) As IList
            If alpha Is AlphaIndex.All OrElse alpha Is Nothing Then
                Return list
            End If
            Return list.Where(Function(c) alpha.Match(AlphaIndex.Group(c.LastName))).ToList()
        End Function
        Public Function Generate(ByVal values As List(Of Contact), ByVal extractName As Func(Of Contact, String)) As List(Of AlphaIndex)
            Dim data = From q In values
                       Where extractName(q) IsNot Nothing
                       Group q By GroupKey = extractName(q) Into g = Group
                       Order By GroupKey
                       Select New AlphaIndex() With {.Index = GroupKey, .Count = g.Count()}
            Dim res = data.ToList()
            res.Insert(0, AlphaIndex.All)
            Return res
        End Function
    End Class
    Public Class AlphaIndex
        Public Property Index() As String
        Public Property Count() As Integer
        Public Overrides Function ToString() As String
            Return String.Format("{0}: {1}", Index, Count)
        End Function
        Public Function Match(ByVal text As String) As Boolean
            Return Group(text) = Index
        End Function
        Public Shared Function Group(ByVal text As String) As String
            If String.IsNullOrEmpty(text) Then
                Return Nothing
            End If
            If text.Length > 1 Then
                text = text.Substring(0, 1)
            End If
            If text.Length = 1 Then
                If Char.IsNumber(text.Chars(0)) Then
                    Return "0-9"
                End If
            End If
            Return text.ToUpper()
        End Function
        Private Shared all_Field As AlphaIndex
        Public Shared ReadOnly Property All() As AlphaIndex
            Get
                If all_Field Is Nothing Then
                    all_Field = New AlphaIndex() With {.Count = 0, .Index = "ALL"}
                End If
                Return all_Field
            End Get
        End Property
        Private Shared alphaNumber_Field As AlphaIndex
        Public Shared ReadOnly Property AlphaNumber() As AlphaIndex
            Get
                If alphaNumber_Field Is Nothing Then
                    alphaNumber_Field = New AlphaIndex() With {.Count = 0, .Index = "0-9"}
                End If
                Return alphaNumber_Field
            End Get
        End Property
    End Class
End Namespace
