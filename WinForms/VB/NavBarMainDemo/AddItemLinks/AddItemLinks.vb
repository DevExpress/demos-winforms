Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraNavBar.Demos

    ''' <summary>
    ''' Summary description for AddItemLinks.
    ''' </summary>
    Public Partial Class AddItemLinks
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            ExistSelectedItemLink()
            ExistSeparatorItemLink()
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

        Private Sub ExistSelectedItemLink()
            button3.Enabled = navBarControl1.ActiveGroup.SelectedLink IsNot Nothing
            button2.Enabled = button3.Enabled
        End Sub

        Private Sub ExistSeparatorItemLink()
            Dim res As Boolean = False
            If navBarControl1.ActiveGroup IsNot Nothing Then
                For i As Integer = navBarControl1.ActiveGroup.ItemLinks.Count - 1 To 0 Step -1
                    Dim itemLinks = navBarControl1.ActiveGroup.ItemLinks(i)
                    Dim separator = TryCast(itemLinks.Item, NavBarSeparatorItem)
                    If separator Is Nothing Then Continue For
                    res = True
                    Exit For
                Next
            End If

            button5.Enabled = res
        End Sub

        '<button1>
        Private i As Integer = 0

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim item As NavBarItem = navBarControl1.Items.Add()
            item.SmallImageIndex = imageComboBoxEdit1.SelectedIndex
            item.LargeImageIndex = item.SmallImageIndex
            item.Caption = "Item " & Math.Min(Threading.Interlocked.Increment(i), i - 1).ToString()
            navBarControl1.ActiveGroup.ItemLinks.Add(item)
            ExistSelectedItemLink()
        End Sub

        '</button1>
        Private Sub navBarControl1_ActiveGroupChanged(ByVal sender As Object, ByVal e As NavBarGroupEventArgs)
            ExistSelectedItemLink()
        End Sub

        Private Sub navBarControl1_SelectedLinkChanged(ByVal sender As Object, ByVal e As ViewInfo.NavBarSelectedLinkChangedEventArgs)
            ExistSelectedItemLink()
        End Sub

        '<button2>
        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            If navBarControl1.ActiveGroup.SelectedLink IsNot Nothing Then navBarControl1.ActiveGroup.SelectedLink.Dispose()
            ExistSelectedItemLink()
        End Sub

        '</button2>
        '<button3>
        Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs)
            If navBarControl1.ActiveGroup.SelectedLink IsNot Nothing Then navBarControl1.ActiveGroup.SelectedLink.Item.Dispose()
            ExistSelectedItemLink()
        End Sub

        '</button3>
        '<button4>
        Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim item As NavBarItem = navBarControl1.Items.Add(True)
            navBarControl1.ActiveGroup.ItemLinks.Add(item)
            navBarControl1.ActiveGroup.SelectedLink = Nothing
            ExistSeparatorItemLink()
        End Sub

        '</button4>
        '<button5>
        Private Sub button5_Click(ByVal sender As Object, ByVal e As EventArgs)
            If navBarControl1.ActiveGroup IsNot Nothing Then
                For i As Integer = navBarControl1.ActiveGroup.ItemLinks.Count - 1 To 0 Step -1
                    Dim itemLinks = navBarControl1.ActiveGroup.ItemLinks(i)
                    Dim separator = TryCast(itemLinks.Item, NavBarSeparatorItem)
                    If separator Is Nothing Then Continue For
                    separator.Dispose()
                    Exit For
                Next
            End If

            ExistSeparatorItemLink()
        End Sub

        '</button5>
        Private Sub AddItemLinks_Load(ByVal sender As Object, ByVal e As EventArgs)
            For i As Integer = 0 To imageCollection1.Images.Count - 1
                imageComboBoxEdit1.Properties.Items.Add(New ImageComboBoxItem("", i, i))
            Next

            imageComboBoxEdit1.Properties.LargeImages = imageCollection1
            imageComboBoxEdit1.Properties.SmallImages = imageCollection2
            imageComboBoxEdit1.SelectedIndex = 1
        End Sub
    End Class
End Namespace
