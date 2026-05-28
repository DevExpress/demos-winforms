Imports System.ComponentModel
Imports System.Drawing

Namespace DevExpress.RealtorWorld.Win

    Public Partial Class ucDraft
        Inherits BaseModule

        Public Overrides ReadOnly Property ModuleCaption As String
            Get
                Return "User management"
            End Get
        End Property

        Public Overrides ReadOnly Property AllowWaitDialog As Boolean
            Get
                Return False
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class
End Namespace
