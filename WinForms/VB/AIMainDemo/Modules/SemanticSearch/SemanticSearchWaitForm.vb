Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraWaitForm

Namespace DevExpress.AI.Demos.Modules.SemanticSearch

    Public Partial Class SemanticSearchWaitForm
        Inherits WaitForm

        Public Sub New()
            InitializeComponent()
            progressPanel1.AutoHeight = True
        End Sub

#Region "Overrides"
        Public Overrides Sub SetCaption(ByVal caption As String)
            MyBase.SetCaption(caption)
            progressPanel1.Caption = caption
        End Sub

        Public Overrides Sub SetDescription(ByVal description As String)
            MyBase.SetDescription(description)
            progressPanel1.Description = description
        End Sub
#End Region
    End Class
End Namespace
