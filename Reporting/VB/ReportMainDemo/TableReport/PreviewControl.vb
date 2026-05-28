Imports System
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraReports.Extensions
Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.TableReport

    Public Class PreviewControl
        Inherits ReportModule

        Private Class TableReportExtension
            Inherits DemoReportExtension

            Public Overrides Function GetEditableDataTypes() As Type()
                Return New Type() {GetType(Integer)}
            End Function

            Protected Overrides Function CreateRepositoryItem(ByVal parameter As Parameter, ByVal dataType As Type, ByVal report As XtraReport) As RepositoryItem
                If Equals(parameter.Name, "OrderIdParameter") Then
                    Dim item As RepositoryItemSpinEdit = New RepositoryItemSpinEdit()
                    item.IsFloatValue = False
                    item.MinValue = 10248
                    item.MaxValue = 11077
                    Return item
                End If

                If Equals(parameter.Name, "MaxRowCountParameter") Then
                    Dim item As RepositoryItemSpinEdit = New RepositoryItemSpinEdit()
                    item.IsFloatValue = False
                    item.MinValue = 1
                    item.MaxValue = Decimal.MaxValue
                    Return item
                End If

                Return Nothing
            End Function
        End Class

        Shared Sub New()
            Call ReportDesignExtension.RegisterExtension(New TableReportExtension(), ReportNames.TableReport)
        End Sub

        Protected Overrides Function CreateReport() As XtraReport
            Dim rep As Report = New Report()
            ReportDesignExtension.AssociateReportWithExtension(rep, ReportNames.TableReport)
            Return rep
        End Function
    End Class
End Namespace
