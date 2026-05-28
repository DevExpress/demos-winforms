Imports System
Imports System.Drawing
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO

Namespace DevExpress.DevAV.ViewModels

    Public Class CustomerMapViewModel
        Inherits CustomerViewModel
        Implements ISalesMapViewModel

        Public Overridable Property Period As Period Implements ISalesMapViewModel.Period

        <Command>
        Public Sub SetLifetimePeriod()
            Period = Period.Lifetime
        End Sub

        Public Function CanSetLifetimePeriod() As Boolean
            Return Period <> Period.Lifetime
        End Function

        <Command>
        Public Sub SetThisYearPeriod()
            Period = Period.ThisYear
        End Sub

        Public Function CanSetThisYearPeriod() As Boolean
            Return Period <> Period.ThisYear
        End Function

        <Command>
        Public Sub SetThisMonthPeriod()
            Period = Period.ThisMonth
        End Sub

        Public Function CanSetThisMonthPeriod() As Boolean
            Return Period <> Period.ThisMonth
        End Function

        Protected Overridable Sub OnPeriodChanged()
            RaiseCanExecuteChanged(Sub(x) x.SetLifetimePeriod())
            RaiseCanExecuteChanged(Sub(x) x.SetThisYearPeriod())
            RaiseCanExecuteChanged(Sub(x) x.SetThisMonthPeriod())
            RaisePeriodChanged()
        End Sub

        Public Event PeriodChanged As EventHandler Implements ISalesMapViewModel.PeriodChanged

        Private Sub RaisePeriodChanged()
            Dim handler As EventHandler = PeriodChangedEvent
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub

#Region "Properties"
        Public ReadOnly Property Name As String
            Get
                Return If(Entity IsNot Nothing, Entity.Name, Nothing)
            End Get
        End Property

        Public ReadOnly Property Image As Image
            Get
                Return If(Entity IsNot Nothing, Entity.Image, Nothing)
            End Get
        End Property

        Public ReadOnly Property AddressLine1 As String
            Get
                Return If(Entity IsNot Nothing, Entity.HomeOffice.Line, Nothing)
            End Get
        End Property

        Public ReadOnly Property AddressLine2 As String
            Get
                Return If(Entity IsNot Nothing, Entity.HomeOffice.CityLine, Nothing)
            End Get
        End Property
#End Region
    End Class
End Namespace
