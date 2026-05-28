Imports System.Windows.Forms
Imports DevExpress.Data.Filtering
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Rows
Imports SampleDataSourceFile = DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS
Imports DevExpress.Utils
Imports System.Drawing

Namespace DevExpress.XtraVerticalGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Focus and navigation", "FocusAndNavigation.cs")>
    Public Module FocusAndNavigation

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim vGridControl As DevExpress.XtraVerticalGrid.VGridControl = New DevExpress.XtraVerticalGrid.VGridControl()
            vGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            vGridControl.Parent = sampleHost
            vGridControl.RowHeaderWidth = DevExpress.Utils.ScaleUtils.ScaleValue(120)
            vGridControl.RecordWidth = DevExpress.Utils.ScaleUtils.ScaleValue(140)
            vGridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(50)
            Return New Object() {vGridControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraVerticalGrid.VGridControl).Dispose()
        End Sub

#Region "Focus and Navigation"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Scroll horizontally by rows"), DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("LeftVisibleRecord")>
        Public Sub ScrollViewVerticallyByRows(ByVal vGridControl As DevExpress.XtraVerticalGrid.VGridControl)
            Dim b As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = vGridControl.Parent, .Text = "Scroll right", .Dock = System.Windows.Forms.DockStyle.Top}
            ' The index of the leftmost visible record
            AddHandler b.Click, Sub(s, e) vGridControl.LeftVisibleRecord += 1
            Dim b1 As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = vGridControl.Parent, .Text = "Scroll left", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler b1.Click, Sub(s, e) vGridControl.LeftVisibleRecord -= 1
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Scroll horizontally by pixels"), DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("LeftVisibleRecordPixel")>
        Public Sub ScrollViewVerticallyByPixels(ByVal vGridControl As DevExpress.XtraVerticalGrid.VGridControl)
            ' Toggles pixel-based vertical scrolling on or off
            vGridControl.OptionsBehavior.AllowAnimatedScrolling = True
            Dim b As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = vGridControl.Parent, .Text = "Scroll right", .Dock = System.Windows.Forms.DockStyle.Top}
            ' The horizontal scroll position of the leftmost record.
            AddHandler b.Click, Sub(s, e) vGridControl.LeftVisibleRecordPixel += 6
            Dim b1 As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = vGridControl.Parent, .Text = "Scroll left", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler b1.Click, Sub(s, e) vGridControl.LeftVisibleRecordPixel -= 6
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Prohibit focusing a column"), DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("FocusedColumnChanged", "FocusedColumn", "PrevFocusedColumn")>
        Public Sub ProhibitFocusingColumn(ByVal vGridControl As DevExpress.XtraVerticalGrid.VGridControl)
            ' This event fires each time a user selects another column
            AddHandler vGridControl.FocusedRowChanged, Sub(s, e)
                If e.Row.VisibleIndex Mod 2 = 1 Then
                    vGridControl.FocusedRow = e.OldRow
                End If
            End Sub
        End Sub
#End Region
    End Module
End Namespace
