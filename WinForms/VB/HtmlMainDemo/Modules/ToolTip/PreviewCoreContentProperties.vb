Imports DevExpress.XtraEditors
Imports DevExpress.XtraVerticalGrid

Namespace DevExpress.HTML.Demos

    Public Partial Class PreviewCoreContentProperties
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
            AddHandler propertyGridControl1.StyleChanged, Sub() BestFitHeight()
        End Sub

        Public ReadOnly Property Properties As PropertyGridControl
            Get
                Return propertyGridControl1
            End Get
        End Property

        Public Overridable Sub BestFitHeight()
        End Sub
    End Class
End Namespace
