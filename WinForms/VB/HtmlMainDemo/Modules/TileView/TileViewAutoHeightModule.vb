Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.HTML.Demos.Helpers.Tasks
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Views.Tile

Namespace DevExpress.HTML.Demos

    Public Partial Class TileViewAutoHeightModule
        Inherits TutorialControlBase

        Public Sub New()
            InitializeComponent()
            If MainFormHelper.TakeScreens Then tileView1.AnimateArrival = False
            tileViewTemplateCodeViewer1.Fill(tileView1)
            gridControl1.DataSource = TaskGenerator.Default.GenerateSource(37)
            tileView1.FocusedRowHandle = 2
            AddHandler alertControl1.BeforeFormShow, Sub(s, e) e.Location = gridControl1.PointToScreen(Point.Empty)
            AddHandler alertControl1.GetDesiredAlertFormWidth, Sub(s, e) e.Width = gridControl1.Width
            AddHandler tileView1.KeyDown, AddressOf TileView1_KeyDown
            copyMenu = New DXPopupMenu()
            copyMenu.Items.Add(New DXMenuItem("Copy", AddressOf CopySelected, svgImageCollection1(0), DXMenuItemPriority.Normal))
            AddHandler tileView1.HtmlElementMouseClick, AddressOf TileView1_HtmlElementMouseClick
        End Sub

        Private copyMenu As DXPopupMenu

        Private Sub TileView1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If ModifierKeys.HasFlag(Keys.Control) AndAlso e.KeyCode = Keys.C Then CopySelected(sender, e)
        End Sub

        Private Sub TileView1_HtmlElementMouseClick(ByVal sender As Object, ByVal e As TileViewHtmlElementMouseEventArgs)
            If e.MouseArgs.Button = MouseButtons.Right AndAlso e.HitInfo.InSelection Then MenuManagerHelper.ShowMenu(copyMenu, LookAndFeel, MenuManagerHelper.GetMenuManager(LookAndFeel, Parent), Me, e.MouseArgs.Location)
        End Sub

        Private Sub CopySelected(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim text = tileView1.SelectedHtmlText
            If Not String.IsNullOrEmpty(text) Then
                Data.Utils.SafeClipboardWin.Instance.SetText(text)
                alertControl1.Show(FindForm(), String.Empty, "Selected text copied to clipboard")
            End If
        End Sub
    End Class
End Namespace
