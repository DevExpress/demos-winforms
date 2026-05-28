Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class WebStyleColumnSelection
        Inherits TutorialControl

        Private _initData As Boolean = False

        Private unboundSelectedRows As Integer(), selectedRows As Integer() = New Integer() {}

        Public Sub New()
            InitializeComponent()
            InitNWindData()
            InitEditors()
            InitData()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"WebStyleColumnSelection"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "WebStyleColumnSelection"
            End Get
        End Property

        Public Overrides ReadOnly Property ExportView As BaseView
            Get
                Return gridView1
            End Get
        End Property

        Protected Overrides Function InitNWindXMLData(ByVal dataFileName As String) As DataSet
            Dim tblGrid As String = "Order Details", tblLookUp As String = "Products"
            Dim ds As DataSet = New DataSet()
            SetWaitDialogCaption(Properties.Resources.LoadingOrderDetails)
            ds.ReadXml(dataFileName)
            gridControl1.DataSource = OrderItem.GetOrderItems(ds.Tables(tblGrid))
            repositoryItemLookUpEdit1.DataSource = ds.Tables(tblLookUp)
            Return ds
        End Function

        Private Sub InitEditors()
            For Each val As DefaultBoolean In [Enum].GetValues(GetType(DefaultBoolean))
                icbShowCheckBoxSelectorInGroupRow.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of DefaultBoolean).GetTitle(val), val, -1))
                icbShowCheckBoxSelectorInHeader.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of DefaultBoolean).GetTitle(val), val, -1))
                icbShowCheckBoxSelectorInPrintExport.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of DefaultBoolean).GetTitle(val), val, -1))
            Next
        End Sub

        Private Sub InitData()
            _initData = True
            Try
                icbShowCheckBoxSelectorInGroupRow.EditValue = gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow
                icbShowCheckBoxSelectorInHeader.EditValue = gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader
                icbShowCheckBoxSelectorInPrintExport.EditValue = gridView1.OptionsSelection.ShowCheckBoxSelectorInPrintExport
                cePrintSelectedRowsOnly.Checked = gridView1.OptionsPrint.PrintSelectedRowsOnly
            Finally
            End Try

            _initData = False
        End Sub

        '<icbShowCheckBoxSelectorInGroupRow>
        Private Sub icbShowCheckBoxSelectorInGroupRow_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _initData Then Return
            Dim edit As ImageComboBoxEdit = TryCast(sender, ImageComboBoxEdit)
            gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow = CType(edit.EditValue, DefaultBoolean)
        End Sub

        '</icbShowCheckBoxSelectorInGroupRow>
        '<icbShowCheckBoxSelectorInHeader>
        Private Sub icbShowCheckBoxSelectorInColumnHeader_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _initData Then Return
            Dim edit As ImageComboBoxEdit = TryCast(sender, ImageComboBoxEdit)
            gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = CType(edit.EditValue, DefaultBoolean)
        End Sub

        '</icbShowCheckBoxSelectorInHeader>
        '<icbShowCheckBoxSelectorInPrintExport>
        Private Sub icbShowCheckBoxSelectorInPrintExport_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _initData Then Return
            Dim edit As ImageComboBoxEdit = TryCast(sender, ImageComboBoxEdit)
            gridView1.OptionsSelection.ShowCheckBoxSelectorInPrintExport = CType(edit.EditValue, DefaultBoolean)
        End Sub

        '</icbShowCheckBoxSelectorInPrintExport>
        '<cePrintSelectedRowsOnly>
        Private Sub cePrintSelectedRowsOnly_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _initData Then Return
            Dim edit As CheckEdit = TryCast(sender, CheckEdit)
            gridView1.OptionsPrint.PrintSelectedRowsOnly = edit.Checked
        End Sub

        '</cePrintSelectedRowsOnly>
#Region "ReportGeneration"
        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property

#End Region
        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            gridControl1.ShowRibbonPrintPreview()
            Cursor.Current = currentCursor
        End Sub

        '<ceBindSelection>
        Private Sub ceBindSelection_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As CheckEdit = TryCast(sender, CheckEdit)
            If edit.Checked Then
                unboundSelectedRows = gridView1.GetSelectedRows()
            Else
                selectedRows = gridView1.GetSelectedRows()
            End If

            gridView1.OptionsSelection.CheckBoxSelectorField = If(edit.Checked, "Selector", String.Empty)
            gridView1.ClearSelection()
            Dim rows = If(edit.Checked, selectedRows, unboundSelectedRows)
            Utils.Extensions.EnumerableExtensions.ForEach(rows, New Action(Of Integer)(AddressOf gridView1.SelectRow))
        End Sub
    '</ceBindSelection>
    End Class
End Namespace
