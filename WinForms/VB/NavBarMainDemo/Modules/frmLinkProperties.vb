Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.Utils

Namespace DevExpress.XtraNavBar.Demos

    Public Partial Class frmLinkProperties
        Inherits XtraEditors.XtraForm

        Public Sub New(ByVal location As Point, ByVal group As NavBarGroup, ByVal link As NavBarItemLink, ByVal items As NavItemCollection, ByVal imlL As ImageCollection, ByVal imlS As ImageCollection)
            InitializeComponent()
            If location.X + Width > Screen.PrimaryScreen.WorkingArea.Width Then location.X = Screen.PrimaryScreen.WorkingArea.Width - Width
            If location.Y + Height > Screen.PrimaryScreen.WorkingArea.Height Then location.Y = Screen.PrimaryScreen.WorkingArea.Height - Height
            DesktopLocation = location
            Me.link = link
            Me.items = items
            Me.group = group
            imlLarge = imlL
            imlSmall = imlS
            For Each i As NavBarItem In items
                cbItem.Properties.Items.Add(i.Caption)
            Next

            cbItem.SelectedItem = link.Item.Caption
        End Sub

        Private link As NavBarItemLink

        Private items As NavItemCollection

        Private group As NavBarGroup

        Private imlLarge, imlSmall As ImageCollection

        Private Sub cbItem_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            txtCaption.Text = items(cbItem.SelectedIndex).Caption
            Invalidate(New Rectangle(cbItem.Left, lbImages.Top, 100, 100))
        End Sub

        Private Sub SetNewProperties()
            If group IsNot Nothing Then
                Dim ind As Integer = group.ItemLinks.IndexOf(link)
                If ind <> -1 Then
                    link.Dispose()
                    group.ItemLinks.Insert(ind, items(cbItem.SelectedIndex))
                End If
            End If

            items(cbItem.SelectedIndex).Caption = txtCaption.Text
        End Sub

        Private Sub frmLinkProperties_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            If DialogResult = DialogResult.OK Then SetNewProperties()
        End Sub

        Private Sub frmLinkProperties_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
            e.Graphics.DrawImage(imlLarge.Images(items(cbItem.SelectedIndex).LargeImageIndex), cbItem.Left, lbImages.Top)
            e.Graphics.DrawImage(imlSmall.Images(items(cbItem.SelectedIndex).SmallImageIndex), cbItem.Left + 56, lbImages.Top)
        End Sub
    End Class
End Namespace
