Imports DevExpress.Tutorials
Imports System.Drawing
Imports DevExpress.Utils.About

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class About
        Inherits ucOverviewPage

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides ReadOnly Property Line1Text As String
            Get
                Return "The XtraPivotGrid Suite"
            End Get
        End Property

        Protected Overrides ReadOnly Property Line2Text As String
            Get
                Return "Multi-dimensional data analysis and data mining for the WinForms platform."
            End Get
        End Property

        Protected Overrides ReadOnly Property Line3Text As String
            Get
                Return "DevExpress Desktop Controls"
            End Get
        End Property

        Protected Overrides ReadOnly Property Line4Text As String
            Get
                Return votedVSM
            End Get
        End Property

        Protected Overrides ReadOnly Property ProductKind As ProductKind
            Get
                Return ProductKind.DXperienceWin
            End Get
        End Property

        Public Overrides ReadOnly Property AllowCopyDxDemoLink As Boolean
            Get
                Return False
            End Get
        End Property
    End Class
End Namespace
