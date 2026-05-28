Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
' <icbAlignment>
' <icbKind>
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ButtonProperties
        Inherits XtraUserControl

        Public Sub New(ByVal button As EditorButton)
            Me.button = button
            InitializeComponent()
            InitComboBoxes()
            updateValues = True
            teCaption.Text = button.Caption
            teToolTip.Text = button.ToolTip
            icbKind.EditValue = button.Kind
            seWidth.Value = button.Width
            ceEnabled.Checked = button.Enabled
            ceVisible.Checked = button.Visible
            icbAlignment.EditValue = button.ImageLocation
            updateValues = False
        End Sub

        Private button As EditorButton

        Private updateValues As Boolean = False

        Private Sub InitComboBoxes()
            ' <icbKind>
            icbKind.Properties.Items.AddEnum(GetType(ButtonPredefines))
            ' </icbKind>
            ' <icbAlignment>
            icbAlignment.Properties.Items.AddEnum(GetType(ImageLocation))
        ' </icbAlignment>
        End Sub

        ' <teCaption>
        Private Sub teCaption_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            button.Caption = teCaption.Text
        End Sub

        ' </teCaption>
        ' <teToolTip>
        Private Sub teToolTip_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            button.ToolTip = teToolTip.Text
        End Sub

        ' </teToolTip>
        ' <icbKind>
        Private Sub icbKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            button.Kind = CType(icbKind.EditValue, ButtonPredefines)
        End Sub

        ' </icbKind>
        ' <seWidth>
        Private Sub seWidth_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            button.Width = Convert.ToInt32(seWidth.Value)
        End Sub

        ' </seWidth>
        ' <ceEnabled>
        Private Sub ceEnabled_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            button.Enabled = ceEnabled.Checked
        End Sub

        ' </ceEnabled>
        ' <ceVisible>
        Private Sub ceVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            button.Visible = ceVisible.Checked
        End Sub

        ' </ceVisible>
        ' <icbAlignment>
        Private Sub icbAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            button.ImageLocation = CType(icbAlignment.EditValue, ImageLocation)
        End Sub

        ' </icbAlignment>
        ' <sbImageLoad>
        Private Sub sbImageLoad_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim file As String = GetImage()
            If Equals(file, Nothing) Then Return
            LoadImage(file)
        End Sub

        Private Function GetImage() As String
            Dim dialog As OpenFileDialog = New OpenFileDialog()
            dialog.Multiselect = False
            dialog.Title = "Select image file"
            dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.PNG;*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"
            If dialog.ShowDialog(Me) = DialogResult.OK Then
                Return dialog.FileName
            End If

            Return Nothing
        End Function

        Private Sub LoadImage(ByVal fileName As String)
            Try
                Dim image As Bitmap = TryCast(Utils.Controls.ImageHelper.LoadImageFromFileEx(fileName), Bitmap)
                If image IsNot Nothing Then button.Image = image
            Catch e As Exception
                XtraMessageBox.Show(e.Message, "Can't load file")
            End Try
        End Sub

        '</sbImageLoad>
        ' <sbImageClear>
        Private Sub sbImageClear_Click(ByVal sender As Object, ByVal e As EventArgs)
            button.Image = Nothing
        End Sub
    ' </sbImageClear>
    End Class
End Namespace
