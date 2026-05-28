Imports System.Windows.Forms
Imports DevExpress.MVVM.Demos.ViewModels
Imports DevExpress.Utils.MVVM.Services
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Layout.Events

Namespace DevExpress.MVVM.Demos.Views
    Partial Public Class CardCollectionViewModule
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            If Not mvvmContext.IsDesignMode Then
                InitBindings()
            End If
            LoadSourceCode(sourceCode, "InitBindings")
        End Sub
        Private Sub InitBindings()
            ' We want all child views, opened from this view, to be a RibbonUI-based (Double click cards to try this feature)
            mvvmContext.RegisterService(WindowedDocumentManagerService.CreateRibbonFormService(Me))

            Dim fluentAPI = mvvmContext.OfType(Of AccountCollectionViewModel)()
            ' We want to show the Entities collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluentAPI.SetBinding(gridControl, Function(gControl) gControl.DataSource, Function(x) x.Entities)

            ' We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent(Of ColumnView, FocusedRowObjectChangedEventArgs)(layoutView, "FocusedRowObjectChanged").
                SetBinding(Function(x) x.SelectedEntity,
                           Function(args) TryCast(args.Row, Model.Account),
                           Sub(lView, entity) lView.FocusedRowHandle = lView.FindRow(entity))
            ' We want to proceed the Edit command when card double-clicked
            fluentAPI.WithEvent(Of CardClickEventArgs)(layoutView, "CardClick").
                EventToCommand(Sub(x) x.Edit(Nothing),
                               Function(x) x.SelectedEntity,
                               Function(args) (args.Clicks = 2) AndAlso (args.Button = MouseButtons.Left))
        End Sub
    End Class
End Namespace
