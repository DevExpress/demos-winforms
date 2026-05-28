Imports System.ComponentModel.DataAnnotations
Imports DevExpress.DXperience.Demos
Imports DevExpress.DXperience.Demos.CodeDemo

Namespace DevExpress.XtraLayout.Demos

    Public Class CodeFirstModule
        Inherits CodeTutorialControlBase

        Public Sub New()
            MyBase.New()
            Dim cmAssemblyName As String = GetType(DisplayAttribute).Assembly.FullName
            Data.Internal.SafeTypeResolver.GetOrLoadAssembly(cmAssemblyName)
        End Sub

        Protected Overrides ReadOnly Property CurrentExampleLanguage As ExampleLanguage
            Get
                Return DemoHelper.GetExampleLanguage()
            End Get
        End Property
    End Class
End Namespace
