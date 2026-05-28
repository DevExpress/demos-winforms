Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Drawing
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS

Namespace DevExpress.XtraGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Print and export", "PrintAndExport.cs")>
    Public Module PrintAndExport

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim gridControl As DevExpress.XtraGrid.GridControl = New DevExpress.XtraGrid.GridControl()
            Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            gridControl.MainView = gridView
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            gridControl.Parent = sampleHost
            gridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(6)
            Return New Object() {gridControl, gridView}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraGrid.GridControl).Dispose()
        End Sub

#Region "Helpers"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass("")>
        Public NotInheritable Class DemoHelper

            Public Shared Function GetRandomImage(ByVal w As Integer, ByVal h As Integer) As Image
                Dim img As System.Drawing.Image = New System.Drawing.Bitmap(w, h)
                Using g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(img)
                    Using brush = DevExpress.XtraGrid.Demos.CodeExamples.PrintAndExport.DemoHelper.GetRandomBrush()
                        g.FillRectangle(brush, New System.Drawing.Rectangle(0, 0, img.Width, img.Height))
                    End Using
                End Using

                Return img
            End Function

            Public Shared Function GetRandomColor() As Color
                Dim r = DevExpress.Data.Utils.NonCryptographicRandom.[Default]
                System.Threading.Thread.Sleep(15)
                Return System.Drawing.Color.FromArgb(r.[Next](50, 200), r.[Next](50, 200), r.[Next](50, 200))
            End Function

            Public Shared Function GetRandomBrush() As Brush
                Return New System.Drawing.SolidBrush(DevExpress.XtraGrid.Demos.CodeExamples.PrintAndExport.DemoHelper.GetRandomColor())
            End Function
        End Class

#End Region
#Region "Printing / Exporting"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Add custom information to the print/export output after a row is printed", New System.Type() {GetType(DevExpress.XtraGrid.Demos.CodeExamples.PrintAndExport.DemoHelper)}), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("AfterPrintRow")>
        Public Sub AfterPrintRow(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' Handle this event to add custom information to the printout/export output after a row is printed
            Dim offset As Single = 1
            AddHandler gridView.AfterPrintRow, Sub(s, e)
                Dim ib As DevExpress.XtraPrinting.ImageBrick = New DevExpress.XtraPrinting.ImageBrick()
                ib.Image = DevExpress.XtraGrid.Demos.CodeExamples.PrintAndExport.DemoHelper.GetRandomImage(100, 20)
                Using g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(ib.Image)
                    g.DrawString("AfterPrintRow", DevExpress.Utils.AppearanceObject.DefaultFont, DevExpress.XtraGrid.Demos.CodeExamples.PrintAndExport.DemoHelper.GetRandomBrush(), New System.Drawing.PointF(3, 3))
                End Using

                Dim r As System.Drawing.RectangleF = New System.Drawing.RectangleF(2, offset, 100, 20)
                e.BrickGraphics.DrawBrick(ib, r)
                offset +=(r.Height + 1)
            End Sub
            Dim b As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Show PrintPreview", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler b.Click, Sub(s, e)
                offset = 1
                gridView.ShowPrintPreview()
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Add custom information to the print/export output before a row is printed", New System.Type() {GetType(DevExpress.XtraGrid.Demos.CodeExamples.PrintAndExport.DemoHelper)}), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("BeforePrintRow")>
        Public Sub BeforePrintRow(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' Handle this event to add custom information to the printout/export output before a row is printed
            AddHandler gridView.BeforePrintRow, Sub(s, e)
                If e.RowHandle Mod 2 <> 0 Then
                    ' Create a text brick and customize its appearance settings.
                    Dim tb As DevExpress.XtraPrinting.TextBrick = New DevExpress.XtraPrinting.TextBrick()
                    tb.Text = "BeforePrintRow"
                    tb.Font = New DevExpress.Drawing.DXFont(tb.Font, DevExpress.Drawing.DXFontStyle.Bold)
                    tb.HorzAlignment = DevExpress.Utils.HorzAlignment.Near
                    tb.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0)
                    tb.BackColor = DevExpress.XtraGrid.Demos.CodeExamples.PrintAndExport.DemoHelper.GetRandomColor()
                    tb.ForeColor = DevExpress.XtraGrid.Demos.CodeExamples.PrintAndExport.DemoHelper.GetRandomColor()
                    ' Get the client page width.
                    Dim brickGraphics As DevExpress.XtraPrinting.BrickGraphics = CType(e.BrickGraphics, DevExpress.XtraPrinting.BrickGraphics)
                    Dim clientPageSize As System.Drawing.SizeF = brickGraphics.ClientPageSize
                    Dim textBrickHeight As Single = brickGraphics.MeasureString(CStr((tb.Text)), CType((tb.Font), DevExpress.Drawing.DXFont)).Height + 4
                    ' Calculate a rectangle for the brick and draw the brick.
                    Dim textBrickRect As System.Drawing.RectangleF = New System.Drawing.RectangleF(0, e.Y, CInt(clientPageSize.Width), textBrickHeight)
                    e.BrickGraphics.DrawBrick(tb, textBrickRect)
                    ' Adjust the current Y position to print the following row below the brick.
                    e.Y += CInt(textBrickHeight)
                End If
            End Sub
            Dim b As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Show PrintPreview", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler b.Click, Sub(s, e) gridView.ShowPrintPreview()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Customize general print/export settings when the View is being printed/exported"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("AfterBuildPages", "PrintInitialize")>
        Public Sub PrintInitialize(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            Dim afterBuildPages As System.EventHandler = Nothing
            afterBuildPages = Sub(s, e)
                Dim pb As DevExpress.XtraPrinting.PrintingSystemBase = TryCast(s, DevExpress.XtraPrinting.PrintingSystemBase)
                RemoveHandler pb.AfterBuildPages, afterBuildPages
                'Set the document's scale factor
                pb.Document.ScaleFactor = 1.5F
            End Sub
            ' Handle this event to customize general print/export settings when the View is being printed/exported
            AddHandler gridView.PrintInitialize, Sub(s, e)
                Dim pb As DevExpress.XtraPrinting.PrintingSystemBase = TryCast(e.PrintingSystem, DevExpress.XtraPrinting.PrintingSystemBase)
                'Set the paper orientation to Landscape
                pb.PageSettings.Landscape = True
                'Specify the document's scale factor
                AddHandler pb.AfterBuildPages, afterBuildPages
            End Sub
            Dim b As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Show PrintPreview", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler b.Click, Sub(s, e) gridView.ShowPrintPreview()
        End Sub
#End Region
    End Module
End Namespace
