Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors.DXErrorProvider

'
 '* Since the release of version 6.3 XPO supports error notifications. To support error notifications, a persistent class
 '* must implement the IDXDataErrorInfo interface. This provides the GetPropertyError method. You should implement this method
 '* to provide a validation procedure to verify data.
 '* If persistent objects implement this interface, the bound controls with invalid data will display error/warning icons.
 '

Namespace DevExpress.Xpo.Demos
    '<gridControl1>
    Public Class Contact
        Inherits XPObject
        Implements IDXDataErrorInfo
        '</gridControl1>
        Private _firstName As String
        Private _lastName As String
        Private _address As String
        Private _phoneNumber As String
        Private _email As String

        Public Sub New()
        End Sub
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
            Me._firstName = ""
            Me._lastName = ""
            Me._address = ""
            Me._phoneNumber = ""
            Me._email = "@hotmail.com"
        End Sub
        Public Sub New(ByVal session As Session, ByVal _firstName As String, ByVal _lastName As String, ByVal age As Integer, ByVal _address As String, ByVal _phoneNumber As String, ByVal _email As String)
            MyBase.New(session)
            Me._firstName = _firstName
            Me._lastName = _lastName
            Me._address = _address
            Me._phoneNumber = _phoneNumber
            Me._email = _email
        End Sub

        Public Property FirstName() As String
            Get
                Return _firstName
            End Get
            Set(ByVal value As String)
                Dim oldValue As String = FirstName
                If oldValue = Value Then
                    Return
                End If
                _firstName = value
                OnChanged(NameOf(FirstName), oldValue, value)
            End Set
        End Property
        Public Property LastName() As String
            Get
                Return _lastName
            End Get
            Set(ByVal value As String)
                Dim oldValue As String = LastName
                If oldValue = Value Then
                    Return
                End If
                _lastName = value
                OnChanged(NameOf(LastName), oldValue, value)
            End Set
        End Property
        Public Property Address() As String
            Get
                Return _address
            End Get
            Set(ByVal value As String)
                Dim oldValue As String = Address
                If oldValue = Value Then
                    Return
                End If
                _address = value
                OnChanged(NameOf(Address), oldValue, value)
            End Set
        End Property
        Public Property PhoneNumber() As String
            Get
                Return _phoneNumber
            End Get
            Set(ByVal value As String)
                Dim oldValue As String = PhoneNumber
                If oldValue = Value Then
                    Return
                End If
                _phoneNumber = value
                OnChanged(NameOf(PhoneNumber), oldValue, value)
            End Set

        End Property
        Public Property Email() As String
            Get
                Return _email
            End Get
            Set(ByVal value As String)
                Dim oldValue As String = Email
                If oldValue = Value Then
                    Return
                End If
                _email = value
                OnChanged(NameOf(Email), oldValue, value)
            End Set
        End Property
        '<gridControl1>
        Private Sub GetPropertyError(ByVal propertyName As String, ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetPropertyError
            Select Case propertyName
                Case NameOf(FirstName)
                    If IsStringEmpty(FirstName) Then
                        SetErrorInfo(info, "First Name field can't be empty", ErrorType.Critical)
                    End If
                Case NameOf(LastName)
                    If IsStringEmpty(LastName) Then
                        SetErrorInfo(info, "Last Name field can't be empty", ErrorType.Critical)
                    End If
                Case NameOf(Address)
                    If IsStringEmpty(Address) Then
                        SetErrorInfo(info, "Address hasn't been entered", ErrorType.Information)
                    End If
                Case NameOf(Email)
                    If IsStringEmpty(Email) Then
                        SetErrorInfo(info, "Email hasn't been entered", ErrorType.Information)
                    ElseIf (Not IsEmailCorrect(Email)) Then
                        SetErrorInfo(info, "Wrong email address", ErrorType.Warning)
                    End If
            End Select
        End Sub
        Private Sub GetError(ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetError
        End Sub
        Private Function IsStringEmpty(ByVal str As String) As Boolean
            Return (Not str Is Nothing AndAlso str.Trim().Length = 0)
        End Function
        Private Function IsEmailCorrect(ByVal emailAddress As String) As Boolean
            Return Not (Not emailAddress Is Nothing AndAlso emailAddress.IndexOf("@") < 1)
        End Function
        Private Sub SetErrorInfo(ByVal info As ErrorInfo, ByVal errorText As String, ByVal errorType As ErrorType)
            info.ErrorText = errorText
            info.ErrorType = errorType
        End Sub
    End Class
    '</gridControl1>
End Namespace
