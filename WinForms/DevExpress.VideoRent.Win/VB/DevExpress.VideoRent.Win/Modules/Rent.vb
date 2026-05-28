Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils
Imports DevExpress.VideoRent.Win.Forms
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.VideoRent.Helpers
Imports DevExpress.XtraReports.UI
Imports DevExpress.VideoRent.Win.Reports
Imports DevExpress.Data.Helpers

Namespace DevExpress.VideoRent.Win.Modules
	Partial Public Class Rent
		Inherits GridExportTutorialControl
		Private tmr As Timer
		Public Sub New()
			InitializeComponent()
			GridViewInfo.DefaultMinVertTabDetailHeight = 0
		End Sub
		Protected Friend Overrides ReadOnly Property UseList() As Boolean
			Get
				Return False
			End Get
		End Property
		Protected Overrides ReadOnly Property AllowFlipLayout() As Boolean
			Get
				Return True
			End Get
		End Property
		Public Overrides ReadOnly Property EditObjectName() As String
			Get
				Return ConstStrings.Receipt
			End Get
		End Property
		Public Overrides ReadOnly Property EditObjectsName() As String
			Get
				Return ConstStrings.Receipts
			End Get
		End Property
		Protected Overrides ReadOnly Property MainView() As ColumnView
			Get
				Return gvReceipts
			End Get
		End Property
		Protected Overrides ReadOnly Property MainLayoutControl() As DevExpress.XtraLayout.LayoutControl
			Get
				Return lcMain
			End Get
		End Property
		Protected Overrides ReadOnly Property ExportView() As BaseView
			Get
				If tcgViews.SelectedTabPage Is lcgActiveRents Then
					Return gvActiveRents
				End If
				Return MyBase.ExportView
			End Get
		End Property
		Protected Overrides ReadOnly Property Landscape() As Boolean
			Get
				Return Object.Equals(tcgViews.SelectedTabPage, lcgActiveRents)
			End Get
		End Property
		Private ReadOnly Property ModuleTimer() As Timer
			Get
				If Object.Equals(tmr, Nothing) Then
					tmr = New Timer()
					tmr.Interval = 100
					AddHandler tmr.Tick, AddressOf tmr_Tick
				End If
				Return tmr
			End Get
		End Property
		Protected Overrides Sub DoParentChanged()
			MyBase.DoParentChanged()
			AddHandler LayoutManager.CurrentCustomerChanged, AddressOf LayoutManager_CurrentCustomerChanged
		End Sub
		Private Sub LayoutManager_CurrentCustomerChanged(ByVal sender As Object, ByVal e As EventArgs)
			ShowCurrentUser()
		End Sub

		Private Sub tmr_Tick(ByVal sender As Object, ByVal e As EventArgs)
			ModuleTimer.Stop()
			CheckCurrentUser()
		End Sub
		Protected Friend Overrides Sub ShowTutorial()
			MyBase.ShowTutorial()
			UpdateCustomer(False)
            ModuleTimer.Start()
		End Sub

		Private Sub CheckCurrentUser()
			If Object.Equals(LayoutManager.CurrentCustomer, Nothing) Then
				LayoutManager.ShowFindCustomerForm(Me.FindForm(), MenuManager, False)
			End If
			ShowCurrentUser()
		End Sub
		Private Sub ShowCurrentUser()
			If (Not Me.Visible) Then
				Return
			End If
			UpdateCustomer(True)
        End Sub
        Sub RefreshCurrentCustomerInfo()
            LayoutManager.CurrentCustomer.Reload()
            ucCustomerInfo1.Init(LayoutManager.CurrentCustomer, ConstStrings.FindCustomerHint, ConstStrings.CustomerDetailTooltip)
        End Sub
        Private Sub UpdateCustomer(ByVal updateData As Boolean)
            Cursor.Current = Cursors.WaitCursor
            Try
                RefreshCurrentCustomerInfo()
                returningItems.Clear()
                UpdateBarButtons(True)
                If (Not updateData) Then
                    Return
                End If
                Me.UpdateData()
            Finally
                Cursor.Current = Cursors.Default
            End Try
        End Sub
        Friend Overrides Sub RefreshData()
            MyBase.RefreshData()
            UpdateData()
        End Sub
        Private Sub UpdateData()
            If Object.Equals(LayoutManager.CurrentCustomer, Nothing) Then
                gcReceipts.DataSource = Nothing
                gcActiveRents.DataSource = Nothing
                UpdateTabCaption(False)
            Else
                gvReceipts.ViewCaption = String.Format(ConstStrings.DatePeriodCaption, PeriodManager.ReceiptPeriod.StartDate, PeriodManager.ReceiptPeriod.EndDate)
                Dim receipts As New XPCollection(Of Receipt)(LayoutManager.CurrentCustomer.Receipts, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Date", PeriodManager.ReceiptPeriod.StartDate, BinaryOperatorType.GreaterOrEqual), New BinaryOperator("Date", PeriodManager.ReceiptPeriod.EndDate, BinaryOperatorType.LessOrEqual)))
                gcReceipts.DataSource = receipts
                gcActiveRents.DataSource = LayoutManager.CurrentCustomer.ActiveRents
                UpdateTabCaption(LayoutManager.CurrentCustomer.ActiveRents.Count > 0)
            End If
        End Sub

        Private Sub UpdateTabCaption(ByVal active As Boolean)
            If active Then
                lcgActiveRents.AppearanceTabPage.HeaderHotTracked.Font = ElementHelper.FontBold
                lcgActiveRents.AppearanceTabPage.HeaderActive.Font = lcgActiveRents.AppearanceTabPage.HeaderHotTracked.Font
                lcgActiveRents.AppearanceTabPage.Header.Font = lcgActiveRents.AppearanceTabPage.HeaderActive.Font
            Else
                lcgActiveRents.AppearanceTabPage.HeaderHotTracked.Font = AppearanceObject.DefaultFont
                lcgActiveRents.AppearanceTabPage.HeaderActive.Font = lcgActiveRents.AppearanceTabPage.HeaderHotTracked.Font
                lcgActiveRents.AppearanceTabPage.Header.Font = lcgActiveRents.AppearanceTabPage.HeaderActive.Font
            End If
        End Sub

        Protected Overrides Sub InitData()
            MyBase.InitData()
            colType.ColumnEdit = EditorHelper.CreateReceiptTypeImageComboBox(gcReceipts.RepositoryItems)
            colOverduePayment.ColumnEdit = EditorHelper.CreatePaymentTextEdit(gcReceipts.RepositoryItems)
            colPaymentSale.ColumnEdit = colOverduePayment.ColumnEdit
            colPaymentActive.ColumnEdit = colPaymentSale.ColumnEdit
            colDiscount.ColumnEdit = colPaymentActive.ColumnEdit
            colPaymentRent.ColumnEdit = colDiscount.ColumnEdit
            colPayment.ColumnEdit = colPaymentRent.ColumnEdit
            colActiveType.ColumnEdit = EditorHelper.CreateActiveRentTypeImageComboBox(gcActiveRents.RepositoryItems)
            colItemFormat.ColumnEdit = EditorHelper.CreateMovieItemFormatImageComboBox(gcActiveRents.RepositoryItems)
            gvActiveRents.Images = ElementHelper.ColumnHeaderIcons
            colActiveType.ImageIndex = 0
            colReturn.ImageIndex = 1
        End Sub

        Private Sub gvReceipts_EndGrouping(ByVal sender As Object, ByVal e As EventArgs) Handles gvReceipts.EndGrouping
            gvReceipts.ExpandAllGroups()
        End Sub
        Private Sub UpdateBarButtons(ByVal updateCheck As Boolean)
            RibbonMenuController.CalcRentItemsEnabling((Not Object.Equals(LayoutManager.CurrentCustomer, Nothing)), returningItems.Count > 0)
            If updateCheck Then
                RibbonMenuController.CalcRentItemsEnablingEx((Not Object.Equals(LayoutManager.CurrentCustomer, Nothing)) AndAlso LayoutManager.CurrentCustomer.OverdueTodayItemsExist())
            End If
        End Sub
        Public Overrides Sub EditOptions()
            MyBase.EditOptions()
            Using frm As New frmReceiptGridOptions(Me.FindForm(), gvReceipts, ConstStrings.ReceiptsViewOptions)
                frm.ShowDialog(Me)
            End Using
        End Sub
        Private Sub gvReceipts_MasterRowGetLevelDefaultView(ByVal sender As Object, ByVal e As MasterRowGetLevelDefaultViewEventArgs) Handles gvReceipts.MasterRowGetLevelDefaultView
            Dim view As GridView = TryCast(sender, GridView)
            Dim receiptParent As Receipt = TryCast(view.GetRow(e.RowHandle), Receipt)
            If Object.Equals(receiptParent, Nothing) Then
                Return
            End If
            If receiptParent.Type = ReceiptType.Purchases Then
                e.DefaultView = gvSales
            End If

        End Sub
        Private Sub gvReceipts_MasterRowGetRelationDisplayCaption(ByVal sender As Object, ByVal e As MasterRowGetRelationNameEventArgs) Handles gvReceipts.MasterRowGetRelationDisplayCaption
            Dim view As GridView = TryCast(sender, GridView)
            Dim receiptParent As Receipt = TryCast(view.GetRow(e.RowHandle), Receipt)
            If Object.Equals(receiptParent, Nothing) Then
                Return
            End If
            e.RelationName = MasterDetailHelper.SplitPascalCaseString(receiptParent.Type.ToString())
        End Sub
        Private returningItems As New Dictionary(Of DevExpress.VideoRent.Rent, Boolean)()
        Private Sub gvActiveRents_CustomUnboundColumnData(ByVal sender As Object, ByVal e As CustomColumnDataEventArgs) Handles gvActiveRents.CustomUnboundColumnData
            Dim key As DevExpress.VideoRent.Rent = GetCurrentKey(e.Row)
            If e.IsSetData Then
                If returningItems.ContainsKey(key) Then
                    returningItems.Remove(key)
                End If
                If Convert.ToBoolean(e.Value) Then
                    returningItems.Add(key, True)
                End If
                UpdateBarButtons(False)
            End If
            If e.IsGetData Then
                e.Value = returningItems.ContainsKey(key)
            End If
        End Sub
        Private Function GetCurrentKey(ByVal row As Object) As DevExpress.VideoRent.Rent
            Return TryCast(row, DevExpress.VideoRent.Rent)
        End Function

        Private Sub repositoryItemCheckEdit1_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles repositoryItemCheckEdit1.CheckStateChanged
            gvActiveRents.CloseEditor()
        End Sub
        Private ReadOnly Property CurrentReturnLateFee() As Boolean
            Get
                For Each rent As DevExpress.VideoRent.Rent In returningItems.Keys
                    If rent.ActiveType = ActiveRentType.Overdue Then
                        Return True
                    End If
                Next rent
                Return False
            End Get
        End Property
        Protected Friend Overrides Sub ReturnMovie()
            MyBase.ReturnMovie()
            Dim overdueReceipt As Receipt = Nothing
            Using nestedSession As NestedUnitOfWork = Session.BeginNestedUnitOfWork()
                If XtraMessageBox.Show(Me.FindForm(), IIf(CurrentReturnLateFee, ConstStrings.ReturnAndPaymentLateFeeQuestion, ConstStrings.ReturnQuestion).ToString(), ConstStrings.Question, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim returns As New List(Of DevExpress.VideoRent.Rent)()
                    For Each rent As DevExpress.VideoRent.Rent In returningItems.Keys
                        returns.Add(SessionHelper.GetObject(Of DevExpress.VideoRent.Rent)(rent, nestedSession))
                    Next rent
                    Dim currentCustomer As Customer = SessionHelper.GetObject(Of Customer)(LayoutManager.CurrentCustomer, nestedSession)
                    overdueReceipt = currentCustomer.ReturnRents(returns)
                    SessionHelper.CommitSession(nestedSession, New ExceptionsProcesser(Me.FindForm()))
                End If
            End Using
            SessionHelper.CommitSession(Session, New ExceptionsProcesser(Me.FindForm()))
            UpdateCustomer(True)
            ShowBill(overdueReceipt)
        End Sub

        Private Sub ShowBill(ByVal overdueReceipt As Receipt)
            If Object.Equals(overdueReceipt, Nothing) Then
                Return
            End If
            lcMain.FocusHelper.PlaceItemIntoView(lciRecepts)
            gvReceipts.CollapseAllDetails()
            WinHelper.GridViewFocusObject(gvReceipts, overdueReceipt)
            gvReceipts.ExpandMasterRow(gvReceipts.FocusedRowHandle)
            Cursor.Current = Cursors.WaitCursor
            Dim report As XtraReport = New LatefeeReceipt(TryCast(gvReceipts.GetRow(gvReceipts.FocusedRowHandle), Receipt))
            report.CreateDocument()
            ShowRibbonPreviewDialog(report)
            Cursor.Current = Cursors.Default
        End Sub
        Protected Friend Overrides Sub RentMovie()
            MyBase.RentMovie()
            XtraMessageBox.Show("//TODO Rent")
        End Sub
        Protected Friend Overrides Sub CheckActiveItems()
            MyBase.CheckActiveItems()
            gvActiveRents.ActiveFilterString = String.Empty
            lcMain.FocusHelper.PlaceItemIntoView(lciActiveRents)
            For Each rent As DevExpress.VideoRent.Rent In LayoutManager.CurrentCustomer.ActiveRents
                If rent.ActiveType <> ActiveRentType.Active AndAlso (Not returningItems.ContainsKey(rent)) Then
                    returningItems.Add(rent, True)
                End If
            Next rent
            gvActiveRents.LayoutChanged()
            UpdateBarButtons(False)
        End Sub
        Protected Overrides Sub CloseDetailForm(ByVal result As DialogResult, ByVal currentObject As Object)
            MyBase.CloseDetailForm(result, currentObject)
            Me.Refresh()
            If result = DialogResult.OK Then
                ShowCurrentUser()
            End If
        End Sub
        Private Sub ucCustomerInfo1_DoEdit(ByVal sender As Object, ByVal e As EventArgs) Handles ucCustomerInfo1.DoEdit
            Cursor.Current = Cursors.WaitCursor
            If (Not IsDetailExist(LayoutManager.CurrentCustomer.Oid)) Then
                ShowModuleDialog(New CustomerDetail(Me.FindForm(), Session, LayoutManager.CurrentCustomer, MenuManager, AddressOf CloseDetailForm))
            End If
            Cursor.Current = Cursors.Default
        End Sub
    End Class
End Namespace
