Imports System
Imports System.Reflection

Namespace DevExpress.WindowsMailClient.Win.Services

    Public Interface IModuleActivator

        Function CreateModule(ByVal moduleTypeName As String) As Object

        Function CreateModule(ByVal moduleTypeName As String, ByVal viewModel As Object) As Object

    End Interface

    Friend NotInheritable Class ModuleActivator
        Implements IModuleActivator

        Private moduleAssembly As Assembly

        Private rootNamespace As String

        Public Sub New(ByVal moduleAssembly As Assembly, ByVal rootNamespace As String)
            Me.moduleAssembly = moduleAssembly
            Me.rootNamespace = rootNamespace
        End Sub

        Public Function CreateModule(ByVal moduleTypeName As String) As Object Implements IModuleActivator.CreateModule
            Dim moduleType As Type = DevExpress.Data.Internal.SafeTypeResolver.GetKnownType(moduleAssembly, rootNamespace & "."c & moduleTypeName)
            Return Activator.CreateInstance(moduleType)
        End Function

        Public Function CreateModule(ByVal moduleTypeName As String, ByVal viewModel As Object) As Object Implements IModuleActivator.CreateModule
            Dim moduleType As Type = DevExpress.Data.Internal.SafeTypeResolver.GetKnownType(moduleAssembly, rootNamespace & "."c & moduleTypeName)
            Return Activator.CreateInstance(moduleType, New Object() {viewModel})
        End Function
    End Class
End Namespace
