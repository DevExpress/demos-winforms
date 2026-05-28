Imports System.Windows.Forms
Imports DevExpress.Data.Filtering
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Rows
Imports SampleDataSourceFile = DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS

Namespace DevExpress.XtraVerticalGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Layout", "Layout.cs")>
    Public Module Layout

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim vGridControl As DevExpress.XtraVerticalGrid.VGridControl = New DevExpress.XtraVerticalGrid.VGridControl()
            vGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            vGridControl.Parent = sampleHost
            vGridControl.RowHeaderWidth = DevExpress.Utils.ScaleUtils.ScaleValue(120)
            vGridControl.RecordWidth = DevExpress.Utils.ScaleUtils.ScaleValue(140)
            vGridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(10)
            Return New Object() {vGridControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraVerticalGrid.VGridControl).Dispose()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Caption height"), DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ShowCaption", "Caption", "CaptionHeight")>
        Public Sub CaptionHeight(ByVal vGridControl As DevExpress.XtraVerticalGrid.VGridControl)
            ' Enable this option to show the VGridControl's caption
            vGridControl.OptionsView.ShowCaption = True
            vGridControl.Caption = "Fish database"
            ' This property controls the VGridControl's caption height
            vGridControl.CaptionHeight = 40
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Formatting record headers"), DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ShowRecordHeaders", "RecordHeaderFormat")>
        Public Sub FormattingRecordHeaders(ByVal vGridControl As DevExpress.XtraVerticalGrid.VGridControl)
            ' Hide unecessary row from layout
            vGridControl.Rows(CStr(("Name"))).Visible = False
            ' Enable this option to show the VGridControl's record headers
            vGridControl.OptionsView.ShowRecordHeaders = True
            ' This property controls the VGridControl's record headers formatting
            vGridControl.RecordHeaderFormat = "[{Name}]"
        End Sub
    End Module
End Namespace
