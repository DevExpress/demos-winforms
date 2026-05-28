Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.Utils.Layout

Namespace DevExpress.XtraLayout.Demos.Modules.XtraLayoutPanel

    Public Partial Class LoginView
        Inherits XtraLayoutPanelDemoViewBase

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Overrides ReadOnly Property LayoutPanel As XtraLayoutPanelBase
            Get
                Return stackPanelField
            End Get
        End Property

        Public ReadOnly Property StackPanel As StackPanel
            Get
                Return stackPanelField
            End Get
        End Property
    End Class
End Namespace
