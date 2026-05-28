Imports DevExpress.XtraEditors

Namespace DevExpress.XtraBars.Demos.RibbonSimplePad

    Public Class BackstageViewLabel
        Inherits LabelControl

        Public Sub New()
            Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            AutoSizeMode = LabelAutoSizeMode.None
            LineLocation = LineLocation.Bottom
            LineVisible = True
            ShowLineShadow = False
        End Sub
    End Class
End Namespace
