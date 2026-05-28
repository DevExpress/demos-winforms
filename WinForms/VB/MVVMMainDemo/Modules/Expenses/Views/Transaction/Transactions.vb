Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.MVVM.Demos.ViewModels

Namespace DevExpress.MVVM.Demos.Views
    <DevExpress.Utils.MVVM.UI.ViewType("TransactionCollectionView")>
    Partial Public Class Transactions
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
            If Not DesignMode Then
                InitBindings()
            End If
        End Sub
        Private Sub InitBindings()
            Dim fluentAPI = mvvmContext.OfType(Of TransactionCollectionViewModel)()
            fluentAPI.SetBinding(gridView, Function(gView) gView.LoadingPanelVisible, Function(x) x.IsLoading)
            fluentAPI.SetBinding(gridControl, Function(gControl) gControl.DataSource, Function(x) x.Entities)

            fluentAPI.WithEvent(Of ColumnView, FocusedRowObjectChangedEventArgs)(gridView, "FocusedRowObjectChanged").SetBinding(Function(x) x.SelectedEntity, Function(args) TryCast(args.Row, Model.Transaction), Sub(gView, entity) gView.FocusedRowHandle = gView.FindRow(entity))
            fluentAPI.WithEvent(Of RowCellClickEventArgs)(gridView, "RowCellClick").EventToCommand(Sub(x) x.Edit(Nothing), Function(x) x.SelectedEntity, Function(args) (args.Clicks = 2) AndAlso (args.Button = MouseButtons.Left))
        End Sub
    End Class
End Namespace
