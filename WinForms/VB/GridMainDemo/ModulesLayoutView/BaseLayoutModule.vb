Imports System.Data

Namespace DevExpress.XtraGrid.Demos

    Public Class BaseLayoutModule
        Inherits TutorialControl

        Protected Overrides Sub InitXMLData(ByVal dataFileName As String, ByVal ds As DataSet)
            ds.ReadXml(dataFileName)
        End Sub

        Protected Overrides ReadOnly Property ModulesFolder As String
            Get
                Return "GridMainDemo\ModulesLayoutView\"
            End Get
        End Property
    End Class
End Namespace
