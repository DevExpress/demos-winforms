Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.DragDrop
Imports DevExpress.Export

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class DragDrop
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            Init()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"DragDrop"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "DragDrop"
            End Get
        End Property

        '<gridControl1>
        Private Sub InitializeGridControl1DragDrop()
            behaviorManager1.Attach(Of DragDropBehavior)(gridView1, Sub(behavior) AddHandler behavior.DragDrop, AddressOf Behavior_DragDropToGrid1)
        End Sub

        Private Sub Behavior_DragDropToGrid1(ByVal sender As Object, ByVal e As DragDropEventArgs)
        End Sub

        '</gridControl1>
        '<gridControl2>
        Private Sub InitializeGridControl2DragDrop()
            behaviorManager1.Attach(Of DragDropBehavior)(gridView2, Sub(behavior) AddHandler behavior.DragDrop, AddressOf Behavior_DragDropToGrid2)
        End Sub

        Private Sub Behavior_DragDropToGrid2(ByVal sender As Object, ByVal e As DragDropEventArgs)
        End Sub

        '</gridControl2>
        Private Sub Init()
            Dim generateSales As SaleOverviewData() = SaleOverviewDataGenerator.GenerateSales()
            Dim count As Integer = 0
            Dim list = generateSales.TakeWhile(Function(e) Math.Min(Threading.Interlocked.Increment(count), count - 1) < generateSales.Count() \ 2).ToList()
            Call InitializeOptions(icbSelectMode1, imageComboBoxEdit1, ceMultiSelect1, gridView1, gridControl1, New BindingList(Of SaleOverviewData)(list))
            count = 0
            list = generateSales.SkipWhile(Function(e) Math.Min(Threading.Interlocked.Increment(count), count - 1) < generateSales.Count() \ 2).ToList()
            Call InitializeOptions(icbSelectMode2, imageComboBoxEdit2, ceMultiSelect2, gridView2, gridControl2, New BindingList(Of SaleOverviewData)(list))
            InitializeGridControl1DragDrop()
            InitializeGridControl2DragDrop()
        End Sub

        Private Shared Sub InitializeOptions(ByVal imageComboBoxMultiSelectMode As ImageComboBoxEdit, ByVal imageComboBoxPasteMode As ImageComboBoxEdit, ByVal checkEdit As CheckEdit, ByVal gridView As GridView, ByVal gridControl As GridControl, ByVal dataSource As Object)
            gridControl.DataSource = dataSource
            imageComboBoxMultiSelectMode.Properties.Items.Add(New ImageComboBoxItem(Properties.Resources.RowSelect, GridMultiSelectMode.RowSelect, -1))
            imageComboBoxMultiSelectMode.Properties.Items.Add(New ImageComboBoxItem(Properties.Resources.CellSelect, GridMultiSelectMode.CellSelect, -1))
            imageComboBoxMultiSelectMode.Properties.Items.Add(New ImageComboBoxItem(Properties.Resources.CheckBoxRowSelect, GridMultiSelectMode.CheckBoxRowSelect, -1))
            imageComboBoxMultiSelectMode.DataBindings.Add("EditValue", gridView.OptionsSelection, "MultiSelectMode", True, DataSourceUpdateMode.OnPropertyChanged)
            checkEdit.DataBindings.Add("EditValue", gridView.OptionsSelection, "MultiSelect", True, DataSourceUpdateMode.OnPropertyChanged)
            imageComboBoxPasteMode.Properties.Items.Add(New ImageComboBoxItem(PasteMode.Default, -1))
            imageComboBoxPasteMode.Properties.Items.Add(New ImageComboBoxItem(PasteMode.Append, -1))
            imageComboBoxPasteMode.Properties.Items.Add(New ImageComboBoxItem(PasteMode.None, -1))
            imageComboBoxPasteMode.Properties.Items.Add(New ImageComboBoxItem(PasteMode.Update, -1))
            imageComboBoxPasteMode.DataBindings.Add("EditValue", gridView.OptionsClipboard, "PasteMode", True, DataSourceUpdateMode.OnPropertyChanged)
            gridView.BestFitColumns()
        End Sub

        Private Sub gridView2_ShowingEditor(ByVal sender As Object, ByVal e As CancelEventArgs)
            e.Cancel = True
        End Sub
    End Class
End Namespace
