Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.DXperience.Demos
Imports DevExpress.HTML.Demos.Helpers
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Tile

Namespace DevExpress.HTML.Demos

    Public Partial Class TileViewModule
        Inherits TutorialControlBase

        Public Sub New()
            InitializeComponent()
            tileViewTemplateCodeViewer1.Fill(tileView1)
            gridControl1.DataSource = DataHelper.Messages
            colDate.SortOrder = Data.ColumnSortOrder.Descending
            If MainFormHelper.TakeScreens Then tileView1.AnimateArrival = False
            tileView1.FocusedRowHandle = 2
        End Sub

        Private Sub OnReply(ByVal sender As Object, ByVal e As TileViewHtmlElementMouseEventArgs)
            ShowPopup(popupReply, e.Row)
        End Sub

        Private Sub OnDelete(ByVal sender As Object, ByVal e As TileViewHtmlElementMouseEventArgs)
            ShowPopup(popupDelete, e.Row)
        End Sub

        Private Sub OnFlag(ByVal sender As Object, ByVal e As TileViewHtmlElementMouseEventArgs)
            Dim msg = TryCast(e.Row, EmailMessage)
            If msg IsNot Nothing Then msg.Flagged = Not msg.Flagged
        End Sub

        Private Sub ShowPopup(ByVal popup As HtmlContentPopup, ByVal msg As Object)
            popup.DataContext = msg
            Dim size = popup.CalcBestSize(gridControl1, 1000)
            Dim rect = gridControl1.RectangleToScreen(gridControl1.ClientRectangle)
            Dim pt = New Point(rect.X + (rect.Width - size.Width) \ 2, rect.Y + (rect.Height - size.Height) \ 2)
            popup.Show(gridControl1, New Rectangle(pt, size))
        End Sub
    End Class
End Namespace
