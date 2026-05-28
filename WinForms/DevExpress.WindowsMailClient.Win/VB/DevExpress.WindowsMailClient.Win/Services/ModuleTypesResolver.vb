Imports System
Imports DevExpress.WindowsMailClient.Win.Modules

Namespace DevExpress.WindowsMailClient.Win.Services

    Public Interface IModuleTypesResolver

        Function GetName(ByVal moduleType As ModuleType) As String

        Function GetTypeName(ByVal moduleType As ModuleType) As String

        Function GetId(ByVal moduleType As ModuleType) As Guid

        Function GetMainModuleType(ByVal type As ModuleType) As ModuleType

        Function GetAccordionModuleType(ByVal type As ModuleType) As ModuleType

    End Interface

    Friend Class ModuleTypesResolver
        Implements IModuleTypesResolver

        Public Function GetName(ByVal moduleType As ModuleType) As String Implements IModuleTypesResolver.GetName
            If moduleType = ModuleType.Unknown Then Return Nothing
            Return moduleType.ToString()
        End Function

        Public Function GetTypeName(ByVal moduleType As ModuleType) As String Implements IModuleTypesResolver.GetTypeName
            If moduleType = ModuleType.Unknown Then Return Nothing
            Return moduleType.ToString()
        End Function

        Public Function GetId(ByVal moduleType As ModuleType) As Guid Implements IModuleTypesResolver.GetId
            Select Case moduleType
                Case ModuleType.MailModule
                    Return New Guid("d4f3a688-3785-41f3-8b62-97dafdbb33f1")
                Case ModuleType.Accounts
                    Return New Guid("d4f3a688-3785-41f3-8b62-97dafdbb33f2")
                Case ModuleType.MailViewer
                    Return New Guid("d4f3a688-3785-41f3-8b62-97dafdbb33f3")
                Case Else
                    Return Guid.Empty
            End Select
        End Function

        Public Function GetMainModuleType(ByVal type As ModuleType) As ModuleType Implements IModuleTypesResolver.GetMainModuleType
            Return type
        End Function

        Public Function GetAccordionModuleType(ByVal type As ModuleType) As ModuleType Implements IModuleTypesResolver.GetAccordionModuleType
            Return type
        End Function
    End Class
End Namespace
