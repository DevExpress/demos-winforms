Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports System.ComponentModel
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS

Namespace DevExpress.XtraGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Preview (read-only row section)", "Preview.cs")>
    Public Module Preview

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim gridControl As DevExpress.XtraGrid.GridControl = New DevExpress.XtraGrid.GridControl()
            Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            gridControl.MainView = gridView
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            gridControl.Parent = sampleHost
            gridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(5)
            Return New Object() {gridControl, gridView}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraGrid.GridControl).Dispose()
        End Sub

#Region "Preview"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Show preview sections"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("PreviewFieldName", "ShowPreview", "AutoCalcPreviewLineCount")>
        Public Sub ShowPreview(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.Columns(CStr(("Notes"))).Visible = False
            ' Specify the field name whose values are displayed in preview sections.
            gridView.PreviewFieldName = "Notes"
            ' Preview sections are enabled by setting the GridOptionsView.ShowPreview option to true.
            gridView.OptionsView.ShowPreview = True
            ' The GridView.OptionsView.AutoCalcPreviewLineCount property gets or sets if the number of text lines are calculated automatically
            gridView.OptionsView.AutoCalcPreviewLineCount = True
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Custom preview text (using an event)"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CalcPreviewText", "PreviewText")>
        Public Sub DynamicPreviewText(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.Columns(CStr(("Notes"))).Visible = False
            gridView.PreviewFieldName = "Notes"
            gridView.OptionsView.ShowPreview = True
            gridView.OptionsView.AutoCalcPreviewLineCount = True
            ' Handle this event to supply custom text to preview sections 
            ' or to modify the text provided by the PreviewFieldName field.
            AddHandler gridView.CalcPreviewText, Sub(s, e)
                If e.RowHandle Mod 2 = 0 Then e.PreviewText = String.Format("Dynamic preview text {0}", e.RowHandle)
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Custom preview height"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("PreviewLineCount")>
        Public Sub PreviewLineCount(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.Columns(CStr(("Notes"))).Visible = False
            gridView.PreviewFieldName = "Notes"
            gridView.OptionsView.ShowPreview = True
            ' This property controls the height of a preview section (in text lines)
            gridView.PreviewLineCount = 3
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Dynamic Preview height (using an event)"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("MeasurePreviewHeight", "RowHeight")>
        Public Sub DynamicPreviewLineCount(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.Columns(CStr(("Notes"))).Visible = False
            gridView.PreviewFieldName = "Notes"
            gridView.OptionsView.ShowPreview = True
            ' Handle this event to specify a custom height for individual preview sections
            AddHandler gridView.MeasurePreviewHeight, Sub(s, e)
                If e.RowHandle Mod 2 = 0 Then
                    e.RowHeight = DevExpress.Utils.ScaleUtils.ScaleValue(50)
                Else
                    e.RowHeight = 0
                End If
            End Sub
        End Sub
#End Region
    End Module
End Namespace
