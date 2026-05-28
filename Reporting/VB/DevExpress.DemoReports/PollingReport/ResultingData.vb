Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.DataAccess.Excel
Imports DevExpress.XtraPrinting

Namespace XtraReportsDemos.PollingReport

    Public Class ResultingData

        Public Property QuestionID As Integer

        Public Property Question As String

        Public Property Answer As String

        Public Property AnswerCount As Integer
    End Class

    Friend Class ResultingDataAdapter

        Private ReadOnly dataSource As DevExpress.DataAccess.Excel.ExcelDataSource

        Public Sub New(ByVal dataSource As DevExpress.DataAccess.Excel.ExcelDataSource)
            Me.dataSource = dataSource
        End Sub

        Public Sub InitializeData(ByVal data As System.Collections.Generic.IList(Of XtraReportsDemos.PollingReport.ResultingData))
            data.Add(Me.CreateResultingData(0, Me.GetAnswer(0), 1))
            data.Add(Me.CreateResultingData(1, Me.GetAnswer(1), 2))
            data.Add(Me.CreateResultingData(4, Me.GetAnswer(4), 2))
            data.Add(Me.CreateResultingData(5, Me.GetAnswer(5), 1))
            data.Add(Me.CreateResultingData(9, "NBC", 1))
            data.Add(Me.CreateResultingData(9, "HBO", 2))
            data.Add(Me.CreateResultingData(10, "2", 2))
            data.Add(Me.CreateResultingData(10, "3", 1))
            data.Add(Me.CreateResultingData(11, Me.GetAnswer(11), 1))
            data.Add(Me.CreateResultingData(12, Me.GetAnswer(12), 2))
        End Sub

        Public Function GetData(ByVal EditingFields As System.Collections.Generic.IList(Of DevExpress.XtraPrinting.EditingField)) As IList(Of XtraReportsDemos.PollingReport.ResultingData)
            Dim data As System.Collections.Generic.List(Of XtraReportsDemos.PollingReport.ResultingData) = New System.Collections.Generic.List(Of XtraReportsDemos.PollingReport.ResultingData)()
            For i As Integer = 0 To EditingFields.Count - 1
                Dim field As DevExpress.XtraPrinting.EditingField = EditingFields(i)
                Dim rowIndex As Integer = System.Convert.ToInt32(field.ID) - 1
                If TypeOf field.EditValue Is DevExpress.XtraPrinting.CheckBoxState Then
                    If System.[Object].Equals(field.Brick.Value, "RadioText") Then Continue For
                    Dim state As DevExpress.XtraPrinting.CheckBoxState = field.GetEditValue(Of DevExpress.XtraPrinting.CheckBoxState)()
                    Dim item As XtraReportsDemos.PollingReport.ResultingData = Me.CreateResultingData(rowIndex, Me.GetAnswer(rowIndex), If(state = DevExpress.XtraPrinting.CheckBoxState.Checked, 1, 0))
                    data.Add(item)
                ElseIf TypeOf field.EditValue Is String AndAlso Not field.[ReadOnly] AndAlso Not String.IsNullOrWhiteSpace(field.GetEditValue(Of String)()) Then
                    Dim item As XtraReportsDemos.PollingReport.ResultingData = Me.CreateResultingData(rowIndex, field.GetEditValue(Of String)(), 1)
                    data.Add(item)
                End If
            Next

            Return data
        End Function

        Private Function GetAnswer(ByVal rowIndex As Integer) As String
            Return GetColumnValue(Of String)(rowIndex, "Answer")
        End Function

        Private Function CreateResultingData(ByVal rowIndex As Integer, ByVal answer As String, ByVal answerCount As Integer) As ResultingData
            Dim questionID As Integer = GetColumnValue(Of Integer)(rowIndex, "QuestionID")
            Return New XtraReportsDemos.PollingReport.ResultingData() With {.Question = GetColumnValue(Of String)(rowIndex, "Question"), .QuestionID = questionID, .Answer = answer, .AnswerCount = answerCount}
        End Function

        Private Function GetColumnValue(Of T)(ByVal rowIndex As Integer, ByVal columnName As String) As T
            Dim list As System.Collections.IList = CType(Me.dataSource, System.ComponentModel.IListSource).GetList()
            Dim row As Object = list(rowIndex)
            Dim column As DevExpress.DataAccess.Native.Excel.ViewColumn = Me.GetColumn(columnName)
            If column IsNot Nothing Then
                Return CType(column.GetValue(row), T)
            End If

            Return DirectCast(Nothing, T)
        End Function

        Private Function GetColumn(ByVal name As String) As DevExpress.DataAccess.Native.Excel.ViewColumn
            Dim dv As DevExpress.DataAccess.Native.Excel.DataView = TryCast(CType(Me.dataSource, System.ComponentModel.IListSource).GetList(), DevExpress.DataAccess.Native.Excel.DataView)
            For i As Integer = 0 To Me.dataSource.Schema.Count - 1
                If Equals(Me.dataSource.Schema(CInt((i))).Name, name) Then Return dv.Columns(i)
            Next

            Return Nothing
        End Function
    End Class
End Namespace
