Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraBars.Demos.BrowserDemo

    Public Partial Class ctrlFavorites
        Inherits UserControl

        Public Event AddNewFavorite As EventHandler

        Public Event EditFavorite As EventHandler

        Public Event DeleteFavorite As EventHandler

        Public Event OpenFavorite As EventHandler

        Public Sub New()
            InitializeComponent()
            ItemsEnabled()
        End Sub

        Private Sub ItemsEnabled()
            iEdit.Enabled = listBox1.SelectedIndex >= 0
            iDelete.Enabled = iEdit.Enabled
            iOpen.Enabled = iDelete.Enabled
        End Sub

        Private Sub listBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ItemsEnabled()
        End Sub

        Public Sub DeleteItems()
            listBox1.Items.Clear()
        End Sub

        Public Sub AddItem(ByVal item As BarItem, ByVal init As Boolean)
            listBox1.Items.Add(item.Caption)
            If Not init Then listBox1.SelectedIndex = listBox1.Items.Count - 1
        End Sub

        Private Sub iAdd_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            RaiseEvent AddNewFavorite(Me, EventArgs.Empty)
        End Sub

        Private Sub iEdit_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim i As Integer = listBox1.SelectedIndex
            If EditFavoriteEvent IsNot Nothing AndAlso listBox1.SelectedItem IsNot Nothing Then RaiseEvent EditFavorite(listBox1.SelectedItem.ToString(), EventArgs.Empty)
            listBox1.SelectedIndex = i
        End Sub

        Private Sub iDelete_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim i As Integer = listBox1.SelectedIndex
            If DeleteFavoriteEvent IsNot Nothing AndAlso listBox1.SelectedItem IsNot Nothing Then RaiseEvent DeleteFavorite(listBox1.SelectedItem.ToString(), EventArgs.Empty)
            Try
                listBox1.SelectedIndex = i
            Catch
            End Try

            ItemsEnabled()
        End Sub

        Private Sub DoOpenFavorite()
            If OpenFavoriteEvent IsNot Nothing AndAlso listBox1.SelectedItem IsNot Nothing Then RaiseEvent OpenFavorite(listBox1.SelectedItem.ToString(), EventArgs.Empty)
        End Sub

        Private Sub iOpen_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            DoOpenFavorite()
        End Sub

        Private Sub listBox1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            DoOpenFavorite()
        End Sub
    End Class
End Namespace
