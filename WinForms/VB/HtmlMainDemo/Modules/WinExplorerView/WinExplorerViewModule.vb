Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Data.Utils
Imports DevExpress.DXperience.Demos
Imports DevExpress.HTML.Demos.Helpers.Data
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.WinExplorer

Namespace DevExpress.HTML.Demos

    Public Partial Class WinExplorerViewModule
        Inherits TutorialControlBase

        Private detailsPopup As HtmlContentPopup

        Public Sub New()
            InitializeComponent()
            Call VehiclesData.InitVehiclesData(gridControl1)
            templateViewer.Fill(winExplorerView1)
            '
            detailsPopup = New HtmlContentPopup()
            AddHandler detailsPopup.ElementMouseClick, AddressOf OnPopupElementMouseClick
            detailsPopup.HtmlImages = svgImageCollection1
            detailsPopup.HtmlTemplate.Assign(winExplorerView1.HtmlTemplates(0))
            '
            AddHandler alertControl1.BeforeFormShow, Sub(s, e) e.Location = gridControl1.PointToScreen(Point.Empty)
            AddHandler alertControl1.GetDesiredAlertFormWidth, Sub(s, e) e.Width = gridControl1.Width
        End Sub

        Protected Overrides ReadOnly Property TakeScreenDelay As Integer
            Get
                Return 300
            End Get
        End Property

        Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
            MyBase.OnHandleCreated(e)
            UpdateBackground()
        End Sub

        Protected Overrides Sub OnLookAndFeelChanged()
            MyBase.OnLookAndFeelChanged()
            UpdateBackground()
        End Sub

        Private Function BlendColor(ByVal bg As Color, ByVal c As Color) As Color
            Dim a As Single = 0.1F
            Return Color.FromArgb(CInt(a * c.R + (1 - a) * bg.R), CInt(a * c.G + (1 - a) * bg.G), CInt(a * c.B + (1 - a) * bg.B))
        End Function

        Private Sub UpdateBackground()
            Dim bg As Color = LookAndFeelHelper.GetSystemColor(UserLookAndFeel.Default, SystemColors.Window)
            Dim fg As Color = LookAndFeelHelper.GetSystemColor(UserLookAndFeel.Default, SystemColors.WindowText)
            winExplorerView1.Appearance.EmptySpace.BackColor = BlendColor(bg, fg)
        End Sub

        Private Sub onDetailButtonClick(ByVal sender As Object, ByVal e As WinExplorerViewHtmlElementEventArgs)
            detailsPopup.DataContext = e.DataItem
            Dim gridBounds As Rectangle = gridControl1.RectangleToScreen(gridControl1.ClientRectangle)
            detailsPopup.UseDirectXPaint = DefaultBoolean.True
            detailsPopup.HtmlTemplate.Assign(winExplorerView1.HtmlTemplates(0))
            detailsPopup.Show(gridControl1, gridBounds)
        End Sub

        Private Sub OnPopupElementMouseClick(ByVal sender As Object, ByVal e As Utils.Html.DxHtmlElementMouseEventArgs)
            If Equals(e.ElementId, "close") Then detailsPopup.Hide()
            If Equals(e.ElementId, "sourceLink") Then
                Dim model As VehiclesData.Model = TryCast(detailsPopup.DataContext, VehiclesData.Model)
                detailsPopup.Hide()
                If model IsNot Nothing Then SafeProcess.Start(model.SourceLink)
            End If
        End Sub

        Private Sub OnWinExplorerViewKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If ModifierKeys.HasFlag(Keys.Control) AndAlso e.KeyCode = Keys.C Then
                Dim text = winExplorerView1.SelectedHtmlText
                If Not String.IsNullOrEmpty(text) Then
                    SafeClipboardWin.Instance.SetText(text)
                    alertControl1.Show(FindForm(), String.Empty, "Selected text copied to clipboard")
                End If
            End If
        End Sub
    End Class
End Namespace
