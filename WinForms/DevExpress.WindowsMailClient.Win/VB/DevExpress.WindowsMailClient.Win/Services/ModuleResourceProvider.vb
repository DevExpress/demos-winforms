Imports DevExpress.WindowsMailClient.Win.Modules

Namespace DevExpress.WindowsMailClient.Win.Services

    Public Interface IModuleResourceProvider

        Function GetCaption(ByVal moduleType As ModuleType) As String

        Function GetModuleImageUri(ByVal moduleType As ModuleType, ByVal Optional smallImage As Boolean = False) As String

    End Interface

    Public Class ModuleResourceProvider
        Implements IModuleResourceProvider

        Public Function GetCaption(ByVal moduleType As ModuleType) As String Implements IModuleResourceProvider.GetCaption
            Select Case moduleType
                Case ModuleType.Unknown
                    Return Nothing
                Case ModuleType.Accounts
                    Return "Accounts"
                Case ModuleType.MailViewer
                    Return "Folders"
                Case ModuleType.MailModule
                    Return "NewMail"
                Case Else
                    Return moduleType.ToString()
            End Select
        End Function

        Public Function GetModuleImageUri(ByVal moduleType As ModuleType, ByVal Optional smallImage As Boolean = False) As String Implements IModuleResourceProvider.GetModuleImageUri
            Return Nothing
        End Function
    End Class
End Namespace
