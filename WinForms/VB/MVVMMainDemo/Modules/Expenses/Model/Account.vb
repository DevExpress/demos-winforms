Imports System.ComponentModel.DataAnnotations

Namespace DevExpress.MVVM.Demos.Model

    Public Class Account
        <Key, Display(AutoGenerateField := False)>
        Public Property ID() As Long
        <Required, StringLength(30, MinimumLength := 4), Display(Name := "ACCOUNT")>
        Public Property Name() As String
        <DataType(DataType.Currency), Display(Name := "AMOUNT")>
        Public Property Amount() As Decimal
        Public Overrides Function ToString() As String
            Return Name & " (" & Amount.ToString("C") & ")"
        End Function
    End Class
End Namespace
