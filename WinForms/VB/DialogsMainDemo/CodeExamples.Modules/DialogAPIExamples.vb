Imports System.Collections.Generic

Namespace DevExpress.XtraDialogs.Demos

    Public Partial Class DialogAPIExamples
        Inherits DevExpress.XtraDialogs.Demos.CodeTutorialControl

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Protected Overrides Function InitializeHighlightTokens() As List(Of String)
            Dim list = MyBase.InitializeHighlightTokens()
            list.Add("XtraFolderBrowserDialog")
            list.Add("XtraOpenFileDialog")
            list.Add("XtraSaveFileDialog")
            Return list
        End Function
    End Class
End Namespace
