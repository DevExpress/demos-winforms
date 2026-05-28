Imports System
Imports System.Drawing
Imports System.ComponentModel

Namespace DevExpress.XtraNavBar.Demos

    ''' <summary>
    ''' Summary description for GroupStyles.
    ''' </summary>
    Public Partial Class GroupStyles
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            InitProperties()
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

        Private Sub InitProperties()
            If navBarControl1.LinkSelectionMode = LinkSelectionModeType.None Then
                ceAllowSelectedLink.Checked = False
            Else
                ceAllowSelectedLink.Checked = True
            End If

            AddGroupStyleItems(cbLocalStyle)
            AddGroupStyleItems(cbContactStyle)
            AddGroupImageStyle(cbLocalImage)
            AddGroupImageStyle(cbContactImage)
            cbLocalStyle.Text = navBarGroup1.GroupStyle.ToString()
            cbContactStyle.Text = navBarGroup2.GroupStyle.ToString()
            cbLocalImage.Text = navBarGroup1.GroupCaptionUseImage.ToString()
            cbContactImage.Text = navBarGroup2.GroupCaptionUseImage.ToString()
        End Sub

        Private Sub ceAllowSelectedLink_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If navBarControl1.LinkSelectionMode = LinkSelectionModeType.None AndAlso ceAllowSelectedLink.Checked Then navBarControl1.LinkSelectionMode = LinkSelectionModeType.OneInControl
            If Not navBarControl1.LinkSelectionMode = LinkSelectionModeType.None AndAlso Not ceAllowSelectedLink.Checked Then navBarControl1.LinkSelectionMode = LinkSelectionModeType.None
        End Sub

        Private Sub AddGroupImageStyle(ByVal cb As XtraEditors.ComboBoxEdit)
            For Each _name As String In [Enum].GetNames(GetType(NavBarImage))
                cb.Properties.Items.Add(_name)
            Next
        End Sub

        Private Sub AddGroupStyleItems(ByVal cb As XtraEditors.ComboBoxEdit)
            For Each _name As String In [Enum].GetNames(GetType(NavBarGroupStyle))
                If _name.IndexOf("Text") > 0 Then cb.Properties.Items.Add(_name)
            Next
        End Sub

        Private Function GetGroupStyleByString(ByVal sender As Object) As NavBarGroupStyle
            Dim cb As XtraEditors.ComboBoxEdit = TryCast(sender, XtraEditors.ComboBoxEdit)
            Return CType([Enum].Parse(GetType(NavBarGroupStyle), cb.SelectedItem.ToString()), NavBarGroupStyle)
        End Function

        Private Function GetGroupImageStyleByString(ByVal sender As Object) As NavBarImage
            Dim cb As XtraEditors.ComboBoxEdit = TryCast(sender, XtraEditors.ComboBoxEdit)
            Return CType([Enum].Parse(GetType(NavBarImage), cb.SelectedItem.ToString()), NavBarImage)
        End Function

        Private Sub cbLocalStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            navBarGroup1.GroupStyle = GetGroupStyleByString(sender)
        End Sub

        Private Sub cbContactStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            navBarGroup2.GroupStyle = GetGroupStyleByString(sender)
        End Sub

        Private Sub cbLocalImage_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            navBarGroup1.GroupCaptionUseImage = GetGroupImageStyleByString(sender)
        End Sub

        Private Sub cbContactImage_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            navBarGroup2.GroupCaptionUseImage = GetGroupImageStyleByString(sender)
        End Sub
    End Class
End Namespace
