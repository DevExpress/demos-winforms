Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DevAV.Common.Utils
Imports DevExpress.DevAV.Reports.Spreadsheet
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.Spreadsheet
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraSpreadsheet

Namespace DevExpress.DevAV.Modules

    Public Partial Class OrderEditView
        Inherits BaseModuleControl
        Implements IRibbonModule

        Public Sub New()
            MyBase.New(GetType(OrderViewModel))
            InitializeComponent()
            Dim fluent = mvvmContext.OfType(Of OrderViewModel)()
            fluent.SetBinding(ribbonControl, Function(r) r.ApplicationDocumentCaption, Function(x) x.Title)
            SwapFluentIcons(Me)
        End Sub

        Private Sub BindCommands()
            Dim fluent = mvvmContext.OfType(Of OrderViewModel)()
            fluent.BindCommand(biSave, Sub(x) x.Save())
            fluent.BindCommand(biClose, Sub(x) x.Close())
            fluent.BindCommand(biSaveAndClose, Sub(x) x.SaveAndClose())
            fluent.BindCommand(biDelete, Sub(x) x.Delete())
            fluent.BindCommand(biReset, Sub(x) x.Reset())
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            BindCommands()
            LoadInvoiceTemplate()
            CreateInvoiceHelper()
            spreadsheetControl1.Document.History.Clear()
            spreadsheetControl1.Options.Events.RaiseOnModificationsViaAPI = True
        End Sub

        Public ReadOnly Property ViewModel As OrderViewModel
            Get
                Return GetViewModel(Of OrderViewModel)()
            End Get
        End Property

        Private Sub LoadInvoiceTemplate()
            Using stream = InvoiceHelper.GetInvoiceTemplate()
                spreadsheetControl1.LoadDocument(stream)
            End Using
        End Sub

        Private invoiceHelper As InvoiceHelper

        Private Sub CreateInvoiceHelper()
            Dim actions = CreateInvoiceEditActions()
            Dim dataSource = ViewModel.CreateInvoiceDataSource()
            invoiceHelper = New InvoiceHelper(spreadsheetControl1.Document, dataSource, actions)
        End Sub

        Private Function CreateInvoiceEditActions() As EditActions
            Dim actions As EditActions = New EditActions()
            actions.IsDefaultActions = False
            actions.GetCustomerStores = New Func(Of Long?, IEnumerable(Of CustomerStore))(AddressOf ViewModel.GetCustomerStores)
            actions.CreateOrderItem = New Func(Of OrderItem)(AddressOf ViewModel.CreateOrderItem)
            actions.AddOrderItem = New Action(Of OrderItem)(AddressOf ViewModel.AddOrderItem)
            actions.RemoveOrderItem = New Action(Of OrderItem)(AddressOf ViewModel.RemoveOrderItem)
            actions.ActivateEditor = New Action(AddressOf SpreadsheetControl_ActivateEditor)
            actions.CloseEditor = New Action(AddressOf SpreadsheetControl_CloseEditor)
            Return actions
        End Function

        Private Sub SpreadsheetControl_ActivateEditor()
            Dim activeSheet As Worksheet = spreadsheetControl1.ActiveWorksheet
            If Equals(activeSheet.Name, CellsHelper.InvoiceWorksheetName) Then
                If activeSheet.CustomCellInplaceEditors.GetCustomCellInplaceEditors(activeSheet.Selection).Count > 0 Then spreadsheetControl1.OpenCellEditor(CellEditorMode.Edit)
            End If
        End Sub

        Private Sub SpreadsheetControl_CloseEditor()
            If spreadsheetControl1.IsCellEditorActive Then spreadsheetControl1.CloseCellEditor(CellEditorEnterValueMode.Cancel)
        End Sub

        Private Sub SpreadsheetControl_CustomCellEdit(ByVal sender As Object, ByVal e As SpreadsheetCustomCellEditEventArgs)
            If Not e.ValueObject.IsText Then Return
            Dim editorInfo = CellsHelper.FindEditor(e.ValueObject.TextValue)
            If editorInfo IsNot Nothing AndAlso TypeOf e.RepositoryItem Is RepositoryItemSpinEdit Then
                Dim repositoryItemSpinEdit As RepositoryItemSpinEdit = TryCast(e.RepositoryItem, RepositoryItemSpinEdit)
                repositoryItemSpinEdit.MinValue = editorInfo.MinValue
                repositoryItemSpinEdit.MaxValue = editorInfo.MaxValue
                repositoryItemSpinEdit.Increment = editorInfo.Increment
                repositoryItemSpinEdit.IsFloatValue = False
            End If
        End Sub

        Private Sub SpreadsheetControl_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            invoiceHelper.SelectionChanged()
        End Sub

        Private Sub SpreadsheetControl_CellValueChanged(ByVal sender As Object, ByVal e As SpreadsheetCellEventArgs)
            invoiceHelper.CellValueChanged(sender, e)
            ViewModel.Update()
        End Sub

        Private Sub SpreadsheetControl_RowsInserted(ByVal sender As Object, ByVal e As RowsChangedEventArgs)
            UnsubscribeFromCellValueAndSelectionChanged()
            Try
                invoiceHelper.RowsInserted(e.StartIndex, e.Count)
            Finally
                SubscribeToCellValueAndSelectionChanged()
            End Try
        End Sub

        Private Sub SpreadsheetControl_RowsRemoved(ByVal sender As Object, ByVal e As RowsChangedEventArgs)
            UnsubscribeFromCellValueAndSelectionChanged()
            Try
                invoiceHelper.RowsRemoved(e.StartIndex, e.Count)
            Finally
                SubscribeToCellValueAndSelectionChanged()
            End Try
        End Sub

        Private Sub SpreadsheetControl_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            If e.Button = MouseButtons.Left Then invoiceHelper.OnPreviewMouseLeftButton(spreadsheetControl1.GetCellFromPoint(e.Location))
        End Sub

        Private Sub SpreadsheetControl_ProtectionWarning(ByVal sender As Object, ByVal e As HandledEventArgs)
            e.Handled = True
        End Sub

        Private Sub SpreadsheetControl_CustomDrawCell(ByVal sender As Object, ByVal e As CustomDrawCellEventArgs)
            Dim sheet As Worksheet = e.Cell.Worksheet
            If Not Equals(sheet.Name, "Invoice") Then Return
            Dim invoiceItems As DefinedName = sheet.DefinedNames.GetDefinedName("InvoiceItems")
            If e.Cell.ColumnIndex = 2 AndAlso e.Cell.RowIndex = If(invoiceItems Is Nothing, 21, invoiceItems.Range.BottomRowIndex + 1) Then DrawLink(e, e.Cache, "Add Order Item")
            If invoiceItems IsNot Nothing AndAlso e.Cell.ColumnIndex = 13 AndAlso invoiceItems.Range.RowCount > 1 AndAlso e.Cell.RowIndex >= invoiceItems.Range.TopRowIndex AndAlso e.Cell.RowIndex < invoiceItems.Range.BottomRowIndex Then DrawLink(e, e.Cache, "Delete Order Item")
        End Sub

        Private Sub DrawLink(ByVal e As CustomDrawCellEventArgs, ByVal cache As GraphicsCache, ByVal text As String)
            e.DrawDefault()
            e.Handled = True
            Dim brush = cache.GetSolidBrush(Color.FromArgb(5, 111, 206))
            Dim font = cache.GetFont(e.Font, FontStyle.Underline)
            Dim size As SizeF = cache.CalcTextSize(text, font, StringFormat.GenericDefault, 0)
            Dim bounds As Rectangle = e.FillBounds
            Dim height As Single = CSng(bounds.Height) - size.Height
            Dim textBounds As RectangleF = New RectangleF(bounds.Left + 11, bounds.Top + height / 2, size.Width + 4, size.Height)
            cache.DrawString(text, font, brush, Rectangle.Round(textBounds), StringFormat.GenericDefault)
        End Sub

        Private Sub SubscribeToCellValueAndSelectionChanged()
            AddHandler spreadsheetControl1.CellValueChanged, AddressOf SpreadsheetControl_CellValueChanged
            AddHandler spreadsheetControl1.SelectionChanged, AddressOf SpreadsheetControl_SelectionChanged
        End Sub

        Private Sub UnsubscribeFromCellValueAndSelectionChanged()
            RemoveHandler spreadsheetControl1.CellValueChanged, AddressOf SpreadsheetControl_CellValueChanged
            RemoveHandler spreadsheetControl1.SelectionChanged, AddressOf SpreadsheetControl_SelectionChanged
        End Sub

#Region ""
        Private ReadOnly Property Ribbon As XtraBars.Ribbon.RibbonControl Implements IRibbonModule.Ribbon
            Get
                Return ribbonControl
            End Get
        End Property
#End Region
    End Class
End Namespace
