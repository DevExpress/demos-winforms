Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo

Namespace DevExpress.HTML.Demos

    Public Partial Class TemplateGallery
        Inherits DevExpress.HTML.Demos.CodeTutorialControl

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Protected Overrides Sub CustomizeCodeExample(ByVal codeExample As DevExpress.DXperience.Demos.CodeDemo.CodeExample)
            MyBase.CustomizeCodeExample(codeExample)
            codeExample.ShowExampleCode = False
        End Sub
    End Class
End Namespace
