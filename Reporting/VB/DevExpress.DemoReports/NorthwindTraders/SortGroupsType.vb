Imports System
Imports System.ComponentModel
Imports System.Globalization

Namespace XtraReportsDemos.NorthwindTraders

    Public Class SortGroupsTypeEnumConverter
        Inherits EnumConverter

#Region "inner classes"
        Friend Structure SortGroupsTypeStrings

            Public Const None As String = "None"

            Public Const Count As String = "Count"

            Public Const TotalSales As String = "Total Sales"

            Public Const LowestPrice As String = "Lowest Price"

            Public Const HighestPrice As String = "Highest Price"
        End Structure

#End Region
        Public Sub New()
            MyBase.New(GetType(SortGroupsType))
        End Sub

        Public Overrides Function CanConvertTo(ByVal context As ITypeDescriptorContext, ByVal destinationType As Type) As Boolean
            Return destinationType Is GetType(String)
        End Function

        Public Overrides Function ConvertTo(ByVal context As ITypeDescriptorContext, ByVal culture As CultureInfo, ByVal value As Object, ByVal destType As Type) As Object
            Select Case CType(value, SortGroupsType)
                Case SortGroupsType.Count
                    Return SortGroupsTypeStrings.Count
                Case SortGroupsType.HighestPrice
                    Return SortGroupsTypeStrings.HighestPrice
                Case SortGroupsType.LowestPrice
                    Return SortGroupsTypeStrings.LowestPrice
                Case SortGroupsType.TotalSales
                    Return SortGroupsTypeStrings.TotalSales
                Case Else
                    Return SortGroupsTypeStrings.None
            End Select
        End Function

        Public Overrides Function CanConvertFrom(ByVal context As ITypeDescriptorContext, ByVal srcType As Type) As Boolean
            Return srcType Is GetType(String)
        End Function

        Public Overrides Function ConvertFrom(ByVal context As ITypeDescriptorContext, ByVal culture As CultureInfo, ByVal value As Object) As Object
            Dim type As SortGroupsType = SortGroupsType.None
            If [Enum].TryParse(CStr(value), False, type) Then
                Return type
            End If

            Select Case CStr(value)
                Case SortGroupsTypeStrings.Count
                    Return SortGroupsType.Count
                Case SortGroupsTypeStrings.HighestPrice
                    Return SortGroupsType.HighestPrice
                Case SortGroupsTypeStrings.LowestPrice
                    Return SortGroupsType.LowestPrice
                Case SortGroupsTypeStrings.TotalSales
                    Return SortGroupsType.TotalSales
                Case Else
                    Return SortGroupsType.None
            End Select
        End Function
    End Class

    <TypeConverter(GetType(SortGroupsTypeEnumConverter))>
    Public Enum SortGroupsType
        None
        Count
        TotalSales
        LowestPrice
        HighestPrice
    End Enum
End Namespace
