Imports DevExpress.XtraEditors
Namespace DevExpress.MailClient.Win.Controls
    Public Class BackstageViewLabel
        Inherits LabelControl

        Public Sub New()
            Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
            LineVisible = True
            ShowLineShadow = False
        End Sub
    End Class
End Namespace
