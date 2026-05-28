Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.DataAccess.Excel
Imports DevExpress.XtraPrinting

Namespace XtraReportsDemos.PollingReport

    Public Partial Class PollingReport
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.PollingReportName
            DisplayName = ReportNames.PollingReport
        End Sub

        Public Sub UpdateData(ByVal data As IList(Of ResultingData))
            UpdateData(data, PrintingSystem.EditingFields)
        End Sub

        Public Sub UpdateData(ByVal data As IList(Of ResultingData), ByVal editingFields As EditingFieldCollection)
            Dim adapter As ResultingDataAdapter = New ResultingDataAdapter(TryCast(DataSource, ExcelDataSource))
            If data.Count = 0 Then adapter.InitializeData(data)
            Dim newData As IList(Of ResultingData) = adapter.GetData(editingFields)
            For Each item As ResultingData In newData
                Dim item2 As ResultingData = data.FirstOrDefault(Function(item3) Equals(item3.Question, item.Question) AndAlso Equals(item3.Answer, item.Answer))
                If item2 IsNot Nothing Then
                    item2.AnswerCount += item.AnswerCount
                Else
                    data.Add(item)
                End If
            Next
        End Sub

        Private Sub detailBand1_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            Dim id As String = Report.GetCurrentColumnValue("AnswerID").ToString()
            xrLabel3.EditOptions.ID = id
            xrLabel2.EditOptions.ID = xrLabel3.EditOptions.ID
            xrCheckBox1.EditOptions.ID = xrLabel2.EditOptions.ID
            If Report.GetCurrentColumnValue("AnswerType").ToString().Contains("Radio") Then
                Dim id2 As String = Report.GetCurrentColumnValue("QuestionID").ToString()
                xrCheckBox1.EditOptions.GroupID = id2
            End If

            If Equals(Report.GetCurrentColumnValue("AnswerType").ToString(), "Number") Then xrLabel3.EditOptions.EditorName = EditingFieldEditorNames.IntegerPositive
        End Sub

        Private Sub detailBand1_AfterPrint(ByVal sender As Object, ByVal e As EventArgs)
            xrLabel3.EditOptions.ID = String.Empty
            xrLabel2.EditOptions.ID = xrLabel3.EditOptions.ID
            xrCheckBox1.EditOptions.ID = xrLabel2.EditOptions.ID
            xrCheckBox1.EditOptions.GroupID = String.Empty
            xrLabel3.EditOptions.EditorName = String.Empty
        End Sub

        Private Sub PollingReport_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            RemoveHandler PrintingSystem.EditingFieldChanged, AddressOf PrintingSystem_EditingFieldChanged
            AddHandler PrintingSystem.EditingFieldChanged, AddressOf PrintingSystem_EditingFieldChanged
        End Sub

        Private Sub PrintingSystem_EditingFieldChanged(ByVal sender As Object, ByVal e As EditingFieldEventArgs)
            If Equals("RadioText", e.EditingField.Brick.Value) Then
                Dim EditingFields As IEnumerable(Of EditingField) = PrintingSystem.EditingFields.Where(Function(item) Equals(item.ID, e.EditingField.ID))
                For Each item As EditingField In EditingFields
                    If Not ReferenceEquals(item, e.EditingField) Then
                        item.ReadOnly = e.EditingField.EditValue.Equals(CheckBoxState.Unchecked)
                        CType(item.Brick, TextBrick).ForeColor = If(item.ReadOnly, System.Drawing.Color.LightGray, System.Drawing.Color.Black)
                    End If
                Next
            End If
        End Sub
    End Class
End Namespace
