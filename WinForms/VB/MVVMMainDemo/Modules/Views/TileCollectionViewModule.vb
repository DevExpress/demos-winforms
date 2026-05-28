Imports System
Imports System.Linq
Imports DevExpress.MVVM.Demos.ViewModels
Imports DevExpress.Utils.MVVM.Services
Imports DevExpress.XtraEditors

Namespace DevExpress.MVVM.Demos.Views
    Partial Public Class TileCollectionViewModule
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            If Not mvvmContext.IsDesignMode Then
                InitBindings()
            End If
            LoadSourceCode(sourceCode, "InitBindings")
        End Sub
        Private Sub InitBindings()
            ' // All child Views, opened from this View, will be hosted within a Ribbon Form (double click rows to try this feature)
            mvvmContext.RegisterService(WindowedDocumentManagerService.CreateRibbonFormService(Me))

            Dim fluentAPI = mvvmContext.OfType(Of AccountCollectionViewModel)()
            Dim group As TileGroup = tileControl1.Groups(0)
            ' Populating the current TileGroup with tiles, generated from the Entities collection.
            'Using the Change and Dispose expressions allows these generated items to dynamically respond to modifying or removing records within the source
            fluentAPI.SetItemsSourceBinding(group, Function(g) g.Items, Function(x) x.Entities, Function(tileItem, entity) Object.Equals(tileItem.Tag, entity), Function(entity)
                                                                                                                                                                    Dim item As New TileItem() With {.Tag = entity}
                                                                                                                                                                    item.ItemSize = TileItemSize.Wide
                                                                                                                                                                    Dim account = New TileItemElement()
                                                                                                                                                                    account.Appearance.Normal.Font = New System.Drawing.Font("Segoe", 24.0F, System.Drawing.GraphicsUnit.Point)
                                                                                                                                                                    item.Elements.Add(account)
                                                                                                                                                                    Dim amount = New TileItemElement()
                                                                                                                                                                    amount.TextAlignment = TileItemContentAlignment.BottomRight
                                                                                                                                                                    item.Elements.Add(amount)
                                                                                                                                                                    Return item
                                                                                                                                                                End Function, Nothing, Sub(tileItem, entity)
                                                                                                                                                                                           tileItem.Elements(0).Text = entity.Name
                                                                                                                                                                                           tileItem.Elements(1).Text = String.Format("{0:C}", entity.Amount)
                                                                                                                                                                                       End Sub)
            ' A two-way synchronization of the ViewModel.SelectedEntity and the TileControl.SelectedItem properties
            fluentAPI.SetBinding(tileControl1, Function(tc) tc.SelectedItem, Function(x) x.SelectedEntity, Function(entity) CType(group.Items.FirstOrDefault(Function(i) Object.ReferenceEquals(i.Tag, entity)), TileItem), Function(item) If(item IsNot Nothing, DirectCast(item.Tag, Model.Account), Nothing))
            ' A double-click on a tile should invoke the Edit command for the related entity
            fluentAPI.WithEvent(Of TileItemEventArgs)(tileControl1, "ItemDoubleClick").EventToCommand(Sub(x) x.Edit(Nothing), Function(x) x.SelectedEntity)
        End Sub
    End Class
End Namespace
