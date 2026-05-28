Imports DevExpress.Data.Filtering
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraVerticalGrid.Rows
Imports System.Windows.Forms
Imports DevExpress.XtraVerticalGrid
Imports SampleDataSourceFile = DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS
Imports ImageHelperSourceFile = DevExpress.XtraVerticalGrid.Demos.CodeExamples.ImageHelperCS
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Utils

Namespace DevExpress.XtraVerticalGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("HTML Text Formatting", "HtmlText.cs")>
    Public Module Html

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim vGridControl As DevExpress.XtraVerticalGrid.VGridControl = New DevExpress.XtraVerticalGrid.VGridControl()
            vGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            vGridControl.Parent = sampleHost
            vGridControl.RowHeaderWidth = DevExpress.Utils.ScaleUtils.ScaleValue(120)
            vGridControl.RecordWidth = DevExpress.Utils.ScaleUtils.ScaleValue(140)
            vGridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.LoadData()
            Return New Object() {vGridControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraVerticalGrid.VGridControl).Dispose()
        End Sub

#Region "Selection"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Cells"), DevExpress.XtraVerticalGrid.Demos.CodeExamples.ImageHelperCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("OptionsView", "AllowHtmlText", "HtmlImages")>
        Public Sub HtmlInCell(ByVal vGridControl As DevExpress.XtraVerticalGrid.VGridControl)
            ' Enable HTML Text Formatting and populate the image collection with glyphs.
            vGridControl.OptionsView.AllowHtmlText = True
            vGridControl.HtmlImages = DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.GetGlyphs()
            ' Assign the HypertextLabel editor to the Name row.
            Dim row As DevExpress.XtraVerticalGrid.Rows.BaseRow = vGridControl.GetRowByFieldName("Name")
            row.Properties.RowEdit = New DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel()
            'Enumerate records in the row, and update cell values.
            For i As Integer = 0 To vGridControl.RecordCount - 1
                Dim value As String = CStr(vGridControl.GetCellValue(row, i))
                vGridControl.SetCellValue(row, i, "<Image=" & value(0) & ">" & value)
            Next
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Headers"), DevExpress.XtraVerticalGrid.Demos.CodeExamples.ImageHelperCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("OptionsView", "AllowHtmlText", "HtmlImages")>
        Public Sub HtmlInHeader(ByVal vGridControl As DevExpress.XtraVerticalGrid.VGridControl)
            ' Enable HTML Text Formatting and populate the image collection with glyphs.
            vGridControl.OptionsView.AllowHtmlText = True
            vGridControl.HtmlImages = DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.GetGlyphs()
            ' Enumerate rows and update header captions.
            For Each row As DevExpress.XtraVerticalGrid.Rows.BaseRow In vGridControl.Rows
                Dim caption As String = row.Properties.GetTextCaption()
                ' To specify the glyph in the Image tag, use the glyph name in the ImageCollection.
                row.Properties.Caption = "<Image=" & caption(0) & "> " & caption
            Next
        End Sub
#End Region
    End Module
End Namespace
