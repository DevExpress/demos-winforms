Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Layout.ViewInfo
Imports DevExpress.ProductsDemo.Win.Forms
Imports DevExpress.MailClient.Win
Imports DevExpress.MailDemo.Win

Imports System.Collections

Namespace DevExpress.ProductsDemo.Win.Modules
	Partial Public Class Contacts
		Inherits BaseModule

		Public Overrides ReadOnly Property ModuleName() As String
			Get
				Return My.Resources.ContactsName
			End Get
		End Property
		Public Sub New()
			InitializeComponent()
			EditorHelper.InitPersonComboBox(repositoryItemImageComboBox1)
			gridControl1.DataSource = DataHelper.Contacts
			gridView1.ShowFindPanel()
			InitIndex(DataHelper.Contacts)
		End Sub
		Protected Overrides ReadOnly Property Grid() As DevExpress.XtraGrid.GridControl
			Get
				Return gridControl1
			End Get
		End Property
		Friend Overrides Sub ShowModule(ByVal firstShow As Boolean)
			MyBase.ShowModule(firstShow)
			gridControl1.Focus()
			UpdateActionButtons()
			If firstShow Then
				ButtonClick(TagResources.ContactCard)
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
				Return TryCast(gridView1.GetRow(gridView1.FocusedRowHandle), Contact)
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

		Private Sub gridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView1.FocusedRowChanged
		End Sub

		Private Sub UpdateCurrentContact()
			ucContactInfo1.Init(CurrentContact, Nothing)
			gridView1.MakeRowVisible(gridView1.FocusedRowHandle)
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

		Private Sub gridView1_RowCellClick(ByVal sender As Object, ByVal e As RowCellClickEventArgs) Handles gridView1.RowCellClick
			If e.Button = MouseButtons.Left AndAlso e.RowHandle >= 0 AndAlso e.Clicks = 2 Then
				EditContact(CurrentContact)
			End If
		End Sub

		Private Sub layoutView1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles layoutView1.MouseDown
			If e.Clicks = 2 AndAlso e.Button = MouseButtons.Left Then
				Dim info As LayoutViewHitInfo = layoutView1.CalcHitInfo(e.Location)
				If info.InCard Then
					Dim current As Contact = TryCast(layoutView1.GetRow(info.RowHandle), Contact)
					If current IsNot Nothing Then
						EditContact(current)
						layoutView1.UpdateCurrentRow()
					End If
				End If
			End If
		End Sub
		Private Function EditContact(ByVal contact As Contact) As DialogResult
			If contact Is Nothing Then
				Return DialogResult.Ignore
			End If
			Dim ret As DialogResult = DialogResult.Cancel
			Cursor.Current = Cursors.WaitCursor
			Using frm As New frmEditContact(contact, OwnerForm.Ribbon)
				ret = frm.ShowDialog(OwnerForm)
			End Using
			UpdateCurrentContact()
			Cursor.Current = Cursors.Default
			Return ret
		End Function
		Private Sub gridView1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gridView1.KeyDown
			If e.KeyData = Keys.Enter AndAlso gridView1.FocusedRowHandle >=0 Then
				EditContact(CurrentContact)
			End If
		End Sub
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
			Me.extractName = Function(s)
				Dim name As String = CType(s, Contact).LastName
				If String.IsNullOrEmpty(name) Then
					Return Nothing 'todo?
				End If
				Return AlphaIndex.Group(name.Substring(0, 1))
			End Function
			Dim dict As List(Of AlphaIndex) = Generate(list, extractName)
			SetupGrid(dict, indexGridControl)
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
			AddHandler alphaChange.Tick, Sub(s, ee)
				gridControl1.DataSource = ApplyFilter(DataHelper.Contacts, TryCast(DirectCast(sender, GridView).GetFocusedRow(), AlphaIndex))
				CType(s, Timer).Dispose()
				Me.alphaChange = Nothing
				UpdateInfo()
			End Sub
			alphaChange.Start()
		End Sub
		Private extractName As GetAlphaMehtod
		Private Function ApplyFilter(ByVal list As List(Of Contact), ByVal alpha As AlphaIndex) As IList
			If alpha Is Nothing OrElse alpha Is AlphaIndex.All Then
				Return list
			End If
			Dim res = From q In list
				Where alpha.Match(extractName(q))
				Select q
			Return res.ToList()

		End Function
        Public Function Generate(ByVal values As List(Of Contact), ByVal extractName As GetAlphaMehtod) As List(Of AlphaIndex)
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
			If Group(text) = Index Then
				Return True
			End If
			Return False
		End Function
		Public Shared Function Group(ByVal text As String) As String
			If text.Length = 1 Then
				Dim ch As Char = text.Chars(0)
				If Char.IsNumber(ch) Then
					Return "0-9"
				End If
			End If
			Return text.ToUpper()
		End Function
'INSTANT VB NOTE: The field all was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field alphaNumber was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private Shared all_Renamed, alphaNumber_Renamed As AlphaIndex
		Public Shared ReadOnly Property All() As AlphaIndex
			Get
				If all_Renamed Is Nothing Then
					all_Renamed = New AlphaIndex() With {
						.Count = 0,
						.Index = "All"
					}
				End If
				Return all_Renamed
			End Get
		End Property
		Public Shared ReadOnly Property AlphaNumber() As AlphaIndex
			Get
				If alphaNumber_Renamed Is Nothing Then
					alphaNumber_Renamed = New AlphaIndex() With {
						.Count = 0,
						.Index = "0-9"
					}
				End If
				Return alphaNumber_Renamed
			End Get
		End Property
	End Class
	Public Delegate Function GetAlphaMehtod(ByVal target As Object) As String
End Namespace
