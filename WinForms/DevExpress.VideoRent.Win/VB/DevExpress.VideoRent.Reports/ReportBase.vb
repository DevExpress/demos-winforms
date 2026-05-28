Imports Microsoft.VisualBasic
Imports DevExpress.Xpo
Imports System.Windows.Forms

Namespace DevExpress.VideoRent.Reports
	Public Class ReportBase
		Inherits DevExpress.XtraReports.UI.XtraReport
        Private fsession As UnitOfWork

        Public Property Session() As UnitOfWork
            Get
                Return fsession
            End Get
            Set(ByVal value As UnitOfWork)
                fsession = value
            End Set
        End Property

		Protected Overrides Sub OnParametersRequestSubmit(ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs)
			MyBase.OnParametersRequestSubmit(e)
			Cursor.Current = Cursors.WaitCursor
		End Sub
	End Class
End Namespace
