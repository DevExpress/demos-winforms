Imports System.Windows.Forms
Imports DevExpress.XtraNavBar

Namespace DevExpress.XtraBars.Demos.DockingDemo

    Public Partial Class ucToolbox
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
            Dim standardGroup As NavBarGroup = navBar.Groups.Add()
            standardGroup.Caption = "Standard"
            standardGroup.Name = "Standard"
            Dim devexpressGroup As NavBarGroup = navBar.Groups.Add()
            devexpressGroup.Caption = "DevExpress"
            devexpressGroup.Name = "DevExpress"
            devexpressGroup.Expanded = True
            Dim index As Integer = 0
            For Each key As String In toolboxSvgImages.Keys
                Dim item As NavBarItem = New NavBarItem()
                Dim caption = GetCaption(key)
                item.Caption = caption
                item.Name = caption
                item.ImageOptions.SmallImageIndex = index
                navBar.Items.Add(item)
                If Not key.Contains("DX") Then
                    standardGroup.ItemLinks.Add(item)
                Else
                    devexpressGroup.ItemLinks.Add(item)
                End If

                index += 1
            Next
        End Sub

        Private Function GetCaption(ByVal key As String) As String
            Return If(key.Contains("_"), key.Substring(0, key.IndexOf("_"c)), key)
        End Function
    End Class
End Namespace
