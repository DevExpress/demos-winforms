Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.XtraTreeList.ViewInfo

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Custom painting", "CustomPainting.cs")>
    Public Class CustomPainting

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim treeList As DevExpress.XtraTreeList.TreeList = New DevExpress.XtraTreeList.TreeList()
            treeList.OptionsBehavior.Editable = False
            treeList.Dock = System.Windows.Forms.DockStyle.Fill
            treeList.Parent = sampleHost
            treeList.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject.GetData()
            AddHandler treeList.Load, Sub(s, e) treeList.ExpandAll()
            Return New Object() {treeList}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next

            sampleHost.Controls.Clear()
        End Sub

        '
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Highlight the specific cells")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomDrawNodeCell")>
        Public Shared Sub HighlightCells(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' Handle this event to modify the specific cell's paint appearance
            AddHandler treeList.CustomDrawNodeCell, Sub(sender, e)
                If Object.Equals(e.CellValue, "Planet") Then e.Appearance.BackColor = System.Drawing.Color.LightGreen
                If Object.Equals(e.Node("Name"), "Earth") Then e.Appearance.BackColor = System.Drawing.Color.LightSeaGreen
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Adding the custom painting into cell content")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomDrawNodeCell")>
        Public Shared Sub DrawNodeCellIcons(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            Dim colTypeOfObject As DevExpress.XtraTreeList.Columns.TreeListColumn = treeList.Columns("TypeOfObject")
            colTypeOfObject.Width = 120
            ' Handle this event to paint node cells manually
            AddHandler treeList.CustomDrawNodeCell, Sub(sender, e)
                If e.Column IsNot colTypeOfObject Then Return
                ' draw the default content
                e.DefaultDraw()
                ' select the brush for painting based on cell value 
                Dim objectColor As System.Drawing.Color = System.Drawing.Color.LightGray
                If Object.Equals(e.CellValue, "Star") Then objectColor = System.Drawing.Color.Yellow
                If Object.Equals(e.CellValue, "Planet") Then objectColor = System.Drawing.Color.LightGreen
                If Object.Equals(e.CellValue, "Satellite") Then objectColor = System.Drawing.Color.LightSkyBlue
                If Object.Equals(e.CellValue, "Asteroid") Then objectColor = System.Drawing.Color.LightPink
                ' draw the object icons
                Dim iconSize As System.Drawing.Size = New System.Drawing.Size(10, 10)
                Dim content As System.Drawing.Rectangle = System.Drawing.Rectangle.Inflate(e.Bounds, -4, -4)
                e.Cache.FillEllipse(objectColor, DevExpress.Utils.PlacementHelper.Arrange(iconSize, content, System.Drawing.ContentAlignment.MiddleRight))
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Highlight the specific column header")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomDrawColumnHeader")>
        Public Shared Sub HighlightColumnHeaders(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            Dim colName As DevExpress.XtraTreeList.Columns.TreeListColumn = treeList.Columns("Name")
            AddHandler treeList.CustomDrawColumnHeader, Sub(sender, e)
                If e.Column IsNot colName Then Return
                ' update the painting arguments
                Dim columnInfo As DevExpress.XtraTreeList.ViewInfo.ColumnInfo = TryCast(e.ObjectArgs, DevExpress.XtraTreeList.ViewInfo.ColumnInfo)
                columnInfo.AllowColoring = True
                columnInfo.Appearance.BackColor = System.Drawing.Color.Orange
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Drawing row numbers")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomDrawNodeIndicator")>
        Public Shared Sub DrawRowNumbers(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            AddHandler treeList.CustomDrawNodeIndicator, Sub(sender, e)
                ' fill the background
                Using brush As System.Drawing.SolidBrush = New System.Drawing.SolidBrush(System.Drawing.Color.LightGreen)
                    e.Cache.FillRectangle(brush, System.Drawing.Rectangle.Inflate(e.Bounds, -1, -1))
                End Using

                ' draw row number
                Using sf = New System.Drawing.StringFormat()
                    sf.Alignment = System.Drawing.StringAlignment.Center
                    sf.LineAlignment = System.Drawing.StringAlignment.Center
                    e.Cache.DrawString(e.Node.Id.ToString(), e.Appearance.GetFont(), e.Cache.GetSolidBrush(e.Appearance.GetForeColor(e.Cache)), System.Drawing.Rectangle.Inflate(e.Bounds, -2, -2), sf)
                End Using

                ' supress the default painting
                e.Handled = True
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("CustomDrawRowPreview")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomDrawRowPreview")>
        Public Shared Sub CustomDrawRowPreview(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            treeList.Columns(CStr(("Notes"))).Visible = False
            treeList.PreviewFieldName = "Notes"
            treeList.PreviewLineCount = 3
            treeList.OptionsView.ShowPreview = True
            Dim padding As Integer = 5
            ' Handle this event to paint Preview row manually
            AddHandler treeList.CustomDrawNodePreview, Sub(s, e)
                e.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
                Dim radius As Double = CDbl(e.Node("MeanRadiusByEarth"))
                If radius > 5 Then
                    Dim rect As System.Drawing.Rectangle = e.Bounds
                    rect.Inflate(-padding, -padding)
                    e.Cache.FillEllipse(rect.X, rect.Y, rect.Height, rect.Height, System.Drawing.Color.Coral)
                    rect.X += rect.Height + padding * 2
                    rect.Width -=(rect.Height + padding * 3)
                    e.Appearance.ForeColor = System.Drawing.Color.Black
                    e.Appearance.DrawString(e.Cache, e.PreviewText, rect)
                    e.Handled = True
                Else
                    e.DefaultDraw()
                End If
            End Sub
        End Sub
    End Class
End Namespace
