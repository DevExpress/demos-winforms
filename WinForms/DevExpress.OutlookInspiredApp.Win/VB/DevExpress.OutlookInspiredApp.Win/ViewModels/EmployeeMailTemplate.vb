Imports System.ComponentModel.DataAnnotations
Imports System.Runtime.CompilerServices

Namespace DevExpress.DevAV.ViewModels

    Public Enum EmployeeMailTemplate
        <Display(Name:="Employee of The Month")>
        EmployeeOfTheMonth
        <Display(Name:="Probation Notice")>
        ProbationNotice
        <Display(Name:="Service Excellence")>
        ServiceExcellence
        <Display(Name:="Thank you note")>
        ThankYouNote
        <Display(Name:="Welcome to DevAV")>
        WelcomeToDevAV
    End Enum

    Public Module EmployeeMailTemplateExtension

        <Extension()>
        Public Function ToFileName(ByVal mailTemplate As EmployeeMailTemplate) As String
            Select Case mailTemplate
                Case EmployeeMailTemplate.ProbationNotice
                    Return "Employee Probation Notice"
                Case EmployeeMailTemplate.ServiceExcellence
                    Return "Employee Service Excellence"
                Case EmployeeMailTemplate.ThankYouNote
                    Return "Employee Thank You Note"
                Case EmployeeMailTemplate.WelcomeToDevAV
                    Return "Welcome to DevAV"
                Case Else
                    Return "Employee of the Month"
            End Select
        End Function
    End Module
End Namespace
