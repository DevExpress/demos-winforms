' Assembly {TutorialsAssembly}
Imports DevExpress.Dialogs.Core.Items
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Base.Controls.Preview
Imports DevExpress.XtraEditors.Controls
Imports System.Windows.Forms

Namespace DevExpress.DXperience.Demos.CodeDemo.Data

    Public Class SvgPreviewHandler
        Inherits DevExpress.XtraEditors.Base.Controls.Preview.WinPreviewHandlerBase

        Private svgImage As DevExpress.Utils.Svg.SvgImage

        Public Overrides Function Load(ByVal file As String, ByVal shellItem As DevExpress.Dialogs.Core.Items.ShellItem) As Boolean
            MyBase.Load(file, shellItem)
            Dim loaded As Boolean = False
            If Equals(shellItem.Extension.ToLower(), ".svg") Then
                Try
                    Me.svgImage = DevExpress.Utils.Svg.SvgImage.FromFile(file)
                    loaded = True
                Catch
                End Try
            End If

            Return loaded
        End Function

        Public Overrides Function CreatePreviewControl() As Control
            Dim picEdit = New DevExpress.XtraEditors.PictureEdit()
            picEdit.SvgImage = Me.svgImage
            picEdit.Enabled = False
            picEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            picEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            picEdit.Properties.UseDisabledStatePainter = False
            Return picEdit
        End Function
    End Class
End Namespace
