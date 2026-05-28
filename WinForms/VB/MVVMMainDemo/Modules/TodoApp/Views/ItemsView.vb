Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo
Imports TodoApp.Model
Imports TodoApp.ViewModels

Namespace TodoApp.Views
    Public Partial Class ItemsView
        Inherits XtraUserControl
        Public Sub New()
            InitializeComponent()
            If Not mvvmContext.IsDesignMode Then InitializeBindings()
        End Sub
        Sub InitializeBindings()
            Dim fluent = mvvmContext.OfType(Of ItemsViewModel)()
            fluent.BindCommand(btnNew, Sub(x) x.[New]())
            fluent.WithEvent(CObj(listBoxControl), CStr("DoubleClick")).EventToCommand(Sub(x) x.Edit())
            fluent.WithEvent(Of ContextItemClickEventArgs)(listBoxControl, "ContextButtonClick").EventToCommand(Sub(x) x.Complete(Nothing), Function(args) TryCast(args.DataItem, TodoItem))
            fluent.SetBinding(titleLabel, Function(lbl) lbl.Text, Function(x) x.Title)
            fluent.SetBinding(toggleShowAll, Function(tgl) tgl.EditValue, Function(x) x.ShowAllItems)
            fluent.SetBinding(todoItemBindingSource, Function(bs) bs.DataSource, Function(x) x.Items)
            fluent.SetBinding(listBoxControl, Function(lb) lb.SelectedValue, Function(x) x.SelectedItem)
        End Sub
        Sub listBoxControl1_CustomizeItem(ByVal sender As Object, ByVal e As CustomizeTemplatedItemEventArgs)
            Dim item = TryCast(e.DataItem, TodoItem)
            If Not item.IsCompleted Then e.TemplatedItem.Elements("IsCompleted").ImageOptions.SvgImage = Nothing
        End Sub
        Sub ListBoxControl1_CustomizeContextItem(ByVal sender As Object, ByVal e As ListBoxControlContextButtonCustomizeEventArgs)
            Dim item = TryCast(e.Item, TodoItem)
            e.ContextItem.Visibility = If(item.IsCompleted, ContextItemVisibility.Hidden, ContextItemVisibility.Auto)
        End Sub
    End Class
End Namespace
