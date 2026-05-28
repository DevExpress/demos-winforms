Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Data
Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS

Namespace DevExpress.XtraGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Summaries", "Summaries.cs")>
    Public Module Summaries

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim gridControl As DevExpress.XtraGrid.GridControl = New DevExpress.XtraGrid.GridControl()
            Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            gridControl.MainView = gridView
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            gridControl.Parent = sampleHost
            gridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(10)
            Return New Object() {gridControl, gridView}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraGrid.GridControl).Dispose()
        End Sub

#Region "Summaries"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Create total and group summaries"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("SummaryItem", "SummaryType", "DisplayFormat", "GroupSummary")>
        Public Sub CreatingTotalAndGroupSummaries(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.OptionsView.ShowFooter = True
            gridView.Columns(CStr(("Mark"))).Group()
            ' Creating total and group summaries
            Dim column As DevExpress.XtraGrid.Columns.GridColumn = gridView.Columns("Length")
            column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            ' format the total summary
            column.SummaryItem.DisplayFormat = "Total: {0:n3}"
            ' group summary
            gridView.GroupSummary.Add(DevExpress.Data.SummaryItemType.Count, "Mark")
            gridView.GroupSummary.Add(New DevExpress.XtraGrid.GridGroupSummaryItem() With {.FieldName = "Length", .SummaryType = DevExpress.Data.SummaryItemType.Sum, .DisplayFormat = "Sum: {0:n5}", .ShowInGroupColumnFooter = gridView.Columns("Length")})
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Manual total summary"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomSummaryCalculate", "SummaryProcess", "TotalValue", "UpdateTotalSummary")>
        Public Sub CreatingCustomSummary(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' Handle this event to calculate summary values manually
            Dim sum As Double = 0
            AddHandler gridView.CustomSummaryCalculate, Sub(sender, e)
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                If e.IsTotalSummary Then
                    Dim item As DevExpress.XtraGrid.GridSummaryItem = TryCast(e.Item, DevExpress.XtraGrid.GridSummaryItem)
                    If Equals(item.FieldName, "Length") Then
                        Select Case e.SummaryProcess
                            Case DevExpress.Data.CustomSummaryProcess.Start
                                sum = 0
                            Case DevExpress.Data.CustomSummaryProcess.Calculate
                                Dim shouldSum As Boolean = CBool(view.GetRowCellValue(e.RowHandle, "Mark"))
                                If shouldSum Then
                                    sum += CDbl(e.FieldValue)
                                End If

                            Case DevExpress.Data.CustomSummaryProcess.Finalize
                                e.TotalValue = sum
                        End Select
                    End If
                End If
            End Sub
            gridView.OptionsView.ShowFooter = True
            Dim column As DevExpress.XtraGrid.Columns.GridColumn = gridView.Columns("Length")
            column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
            Dim edit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit = TryCast(gridView.Columns(CStr(("Mark"))).RealColumnEdit, DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit)
            AddHandler edit.EditValueChanged, Sub(sender, e)
                'Post an editor's value to a data source
                gridView.PostEditor()
                'Force calculation of the total summary
                gridView.UpdateTotalSummary()
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Hide certain summaries"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomSummaryExists", "Exists")>
        Public Sub CustomSummaryExists(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.OptionsView.ShowFooter = True
            gridView.Columns(CStr(("Mark"))).Group()
            ' Handle this event to calculate summary values manually
            Dim sum As Integer = 0
            AddHandler gridView.CustomSummaryCalculate, Sub(s, e)
                Dim item As DevExpress.XtraGrid.GridSummaryItem = TryCast(e.Item, DevExpress.XtraGrid.GridSummaryItem)
                If Equals(item.FieldName, "ID") OrElse Equals(item.FieldName, "Length") Then
                    Select Case e.SummaryProcess
                        Case DevExpress.Data.CustomSummaryProcess.Start
                            sum = 0
                        Case DevExpress.Data.CustomSummaryProcess.Calculate
                            sum += System.Convert.ToInt32(e.FieldValue)
                        Case DevExpress.Data.CustomSummaryProcess.Finalize
                            e.TotalValue = sum
                    End Select
                End If
            End Sub
            ' Handle this event to specify which summaries should be calculated and displayed
            AddHandler gridView.CustomSummaryExists, Sub(s, e) e.Exists = Equals(TryCast(e.Item, DevExpress.XtraGrid.GridSummaryItem).Tag.ToString(), "VisibleSummary")
            ' Creating total and group summaries
            Dim column As DevExpress.XtraGrid.Columns.GridColumn = gridView.Columns("Length")
            column.Summary.Add(New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "Length", "Custom Sum: {0:n}", "VisibleSummary"))
            column.Summary.Add(New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "Length", "Custom Sum: {0:n}", "HiddenSummary"))
            gridView.GroupSummary.Add(New DevExpress.XtraGrid.GridGroupSummaryItem() With {.FieldName = "ID", .SummaryType = DevExpress.Data.SummaryItemType.Custom, .DisplayFormat = "Custom Total: {0:n}", .ShowInGroupColumnFooter = gridView.Columns("ID"), .Tag = "VisibleSummary"})
            gridView.GroupSummary.Add(New DevExpress.XtraGrid.GridGroupSummaryItem() With {.FieldName = "ID", .SummaryType = DevExpress.Data.SummaryItemType.Custom, .DisplayFormat = "Custom Total: {0:n}", .ShowInGroupColumnFooter = gridView.Columns("Length"), .Tag = "HiddenSummary"})
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Align group summaries in group rows"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("AlignGroupSummaryInGroupRow", "ShowInGroupColumnFooter")>
        Public Sub AlignGroupSummaryInGroupRow(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.Columns(CStr(("Mark"))).Group()
            'Enable this option to move group footer summaries to group rows under corresponding column headers
            gridView.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.[True]
            'Create group summary
            gridView.GroupSummary.Add(New DevExpress.XtraGrid.GridGroupSummaryItem() With {.FieldName = "Length", .SummaryType = DevExpress.Data.SummaryItemType.Sum, .ShowInGroupColumnFooter = gridView.Columns("Length")})
        End Sub
#End Region
    End Module
End Namespace
