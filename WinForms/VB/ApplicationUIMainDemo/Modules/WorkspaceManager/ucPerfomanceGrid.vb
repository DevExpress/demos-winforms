Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class ucPerfomanceGrid
        Inherits XtraEditors.XtraUserControl

        Public Sub New()
            InitializeComponent()
            gridControl1.DataSource = LoadPerformanceReport()
        End Sub
    End Class
End Namespace
