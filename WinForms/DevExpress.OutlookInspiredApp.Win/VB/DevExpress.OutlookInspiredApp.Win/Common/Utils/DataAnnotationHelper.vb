Imports System
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.Reflection
Imports DevExpress.DataAnnotations

Namespace DevExpress.DevAV.Common.Utils

    Public Module DataAnnotationHelper

        Public Function IsRequired(Of TEntity)(ByVal propertyName As String) As Boolean
            Return IsSet(Of RequiredAttribute)(GetType(TEntity), propertyName)
        End Function

        Public Function IsPhone(Of TEntity)(ByVal propertyName As String) As Boolean
            Return IsSet(Of PhoneAttribute)(GetType(TEntity), propertyName)
        End Function

        Public Function IsEmail(Of TEntity)(ByVal propertyName As String) As Boolean
            Return IsSet(Of EmailAddressAttribute)(GetType(TEntity), propertyName)
        End Function

        Public Function IsZipcode(Of TEntity)(ByVal propertyName As String) As Boolean
            Return IsSet(Of ZipCodeAttribute)(GetType(TEntity), propertyName)
        End Function

        Public Function IsSet(Of TAttribute As ValidationAttribute)(ByVal type As Type, ByVal propertyName As String) As Boolean
            Dim path As String() = propertyName.Split("."c)
            If path.Length > 1 Then
                Dim nestedPropertyInfo As PropertyInfo = type.GetProperty(path(0))
                If nestedPropertyInfo Is Nothing Then Return False
                Return IsSet(Of TAttribute)(nestedPropertyInfo.PropertyType, String.Join(".", path.Skip(1)))
            End If

            Dim propertyInfo As PropertyInfo = type.GetProperty(propertyName)
            If propertyInfo Is Nothing Then Return False
            Return propertyInfo.GetCustomAttributes(False).OfType(Of TAttribute)().Any()
        End Function
    End Module
End Namespace
