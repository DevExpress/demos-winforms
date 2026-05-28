Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports System.ComponentModel
Imports DevExpress.Utils
Imports System.IO
Imports System.Xml.Serialization
Imports System.Drawing
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS

Namespace DevExpress.XtraGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Focus and navigation", "FocusAndNavigation.cs")>
    Public Module FocusAndNavigation

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim gridControl As DevExpress.XtraGrid.GridControl = New DevExpress.XtraGrid.GridControl()
            Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            gridControl.MainView = gridView
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            gridControl.Parent = sampleHost
            gridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(50)
            Return New Object() {gridControl, gridView}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraGrid.GridControl).Dispose()
        End Sub

#Region "Focus and Navigation"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Scroll horizontally"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("LeftCoord")>
        Public Sub ScrollHorizontally(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.OptionsView.ColumnAutoWidth = False
            For Each col As DevExpress.XtraGrid.Columns.GridColumn In gridView.Columns
                col.Width = 400
            Next

            Dim b As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Scroll forward", .Dock = System.Windows.Forms.DockStyle.Top}
            ' The property controls the offset by which the View is scrolled horizontally
            AddHandler b.Click, Sub(s, e) gridView.LeftCoord += 10
            Dim b1 As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Scroll backward", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler b1.Click, Sub(s, e) gridView.LeftCoord -= 10
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Scroll vertically by rows"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("TopRowIndex")>
        Public Sub ScrollViewVerticallyByRows(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            Dim b As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Scroll down", .Dock = System.Windows.Forms.DockStyle.Top}
            ' The property gets or sets the rowHandle of the top visible row
            AddHandler b.Click, Sub(s, e) gridView.TopRowIndex += 1
            Dim b1 As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Scroll up", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler b1.Click, Sub(s, e) gridView.TopRowIndex -= 1
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Scroll vertically by pixels"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("TopRowPixel")>
        Public Sub ScrollViewVerticallyByPixels(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' This option controls whether pixel-based vertical scrolling is enabled
            gridView.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Dim b As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Scroll down", .Dock = System.Windows.Forms.DockStyle.Top}
            ' This property specifies the vertical scroll position, in pixels.
            AddHandler b.Click, Sub(s, e) gridView.TopRowPixel += 6
            Dim b1 As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Scroll up", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler b1.Click, Sub(s, e) gridView.TopRowPixel -= 6
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Prevent row focus changes"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("BeforeLeaveRow")>
        Public Sub BeforeLeaveRow(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.SetRowCellValue(2, "Length", 0)
            gridView.FocusedRowHandle = 2
            ' Handle this event to prevent row focus changes
            AddHandler gridView.BeforeLeaveRow, Sub(s, e)
                Dim _length As Double = System.Convert.ToDouble(TryCast(s, DevExpress.XtraGrid.Views.Grid.GridView).GetRowCellValue(e.RowHandle, "Length"))
                If _length <= 0 Then
                    e.Allow = DevExpress.XtraEditors.XtraMessageBox.Show("Length should be greater than zero. Would you like to leave the row anyway?", "Confirmation dialog", System.Windows.Forms.MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Focus a cell and show its in-place editor"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("FocusedRowHandle", "FocusedColumn", "ShowEditor")>
        Public Sub FocusingCellAndShowingEditor(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' Focusing a cell and showing its in-place editor
            AddHandler gridControl.Load, Sub(sender, e)
                gridView.FocusedRowHandle = 2
                gridView.FocusedColumn = gridView.Columns("Length")
                gridView.ShowEditor()
                Dim edit As DevExpress.XtraEditors.TextEdit = TryCast(gridView.ActiveEditor, DevExpress.XtraEditors.TextEdit)
                If edit IsNot Nothing Then
                    edit.BackColor = System.Drawing.Color.DodgerBlue
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Prohibit focusing a column"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("FocusedColumnChanged", "FocusedColumn", "PrevFocusedColumn")>
        Public Sub ProhibitFocusingColumn(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' The event is raised each time focus is moved to another column
            AddHandler gridView.FocusedColumnChanged, Sub(s, e)
                If e.FocusedColumn.VisibleIndex Mod 2 = 1 Then
                    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(s, DevExpress.XtraGrid.Views.Grid.GridView)
                    view.FocusedColumn = e.PrevFocusedColumn
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Prohibit focusing a row"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("FocusedRowChanged", "FocusedRowHandle", "PrevFocusedRowHandle")>
        Public Sub ProhibitFocusingRow(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.FocusedColumn = gridView.Columns(1)
            ' The event is raised each time focus is moved to another row
            AddHandler gridView.FocusedRowChanged, Sub(s, e)
                If e.FocusedRowHandle Mod 2 = 1 Then
                    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(s, DevExpress.XtraGrid.Views.Grid.GridView)
                    view.FocusedRowHandle = e.PrevFocusedRowHandle
                End If
            End Sub
        End Sub
#End Region
    End Module
End Namespace
