Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.DXperience.Demos.CodeDemo.Helpers
Imports DevExpress.Utils
Imports DevExpress.Utils.Html
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.TableLayout
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Tile
Imports DevExpress.XtraGrid.Views.Tile.ViewInfo
Imports DevExpress.XtraTreeList

Namespace DevExpress.HTML.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("ListBox control", "CustomDraw.cs")>
    Public Module CustomDraw_ListBoxControl

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim panel = New DevExpress.XtraEditors.PanelControl()
            panel.Padding = New System.Windows.Forms.Padding(64)
            panel.Dock = System.Windows.Forms.DockStyle.Fill
            panel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            panel.Parent = sampleHost
            Dim resetButton = New DevExpress.XtraEditors.SimpleButton()
            resetButton.Text = "Remove ListBox items"
            resetButton.Dock = System.Windows.Forms.DockStyle.Bottom
            resetButton.Visible = False
            resetButton.Parent = panel
            Dim listControl = New DevExpress.XtraEditors.ListBoxControl()
            listControl.Dock = System.Windows.Forms.DockStyle.Fill
            listControl.Parent = panel
            AddHandler resetButton.Click, Sub(s, e) listControl.Items.Clear()
            AddHandler listControl.Items.ListChanged, Sub(s, e) resetButton.Visible = listControl.ItemCount > 0
            Return New Object() {listControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
        ' do nothing 
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("The CustomDrawEmptyForeground event")>
        <DevExpress.HTML.Demos.CodeExamples.HtmlFile("CustomDraw.ListBoxEmptyForeground"), DevExpress.HTML.Demos.CodeExamples.CssFile("CustomDraw.ListBoxEmptyForeground"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomDrawEmptyForeground")>
        Public Sub CustomDrawEmptyForeground(ByVal listControl As DevExpress.XtraEditors.ListBoxControl)
            ' local painting context which contains html tree state
            Dim ctx As DevExpress.Utils.Html.DxHtmlPainterContext = New DevExpress.Utils.Html.DxHtmlPainterContext()
            ' handle html-template painting
            Dim htmlTemplate As DevExpress.Utils.Html.HtmlTemplate = New DevExpress.Utils.Html.HtmlTemplate(DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("ListBoxEmptyForeground.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("ListBoxEmptyForeground.css"))
            AddHandler listControl.CustomDrawEmptyForeground, Sub(s, e) e.DrawHtml(htmlTemplate, ctx)
            ' handle UI feedback (hover/cursor)
            AddHandler listControl.MouseMove, Sub(s, e)
                If listControl.ItemCount = 0 Then
                    ctx.OnMouseMove(e)
                    listControl.Cursor = ctx.GetCursor(e.Location)
                    listControl.Invalidate()
                Else
                    listControl.Cursor = System.Windows.Forms.Cursors.[Default]
                End If
            End Sub
            ' handle Click within the btnAdd element
            Dim items = System.Linq.Enumerable.Range(1, 10).[Select](Function(n) String.Format("Item #{0:d2}", n)).ToArray()
            AddHandler listControl.MouseDown, Sub(s, e)
                If listControl.ItemCount = 0 AndAlso e.Button = System.Windows.Forms.MouseButtons.Left Then
                    Dim clickInfo = ctx.CalcHitInfo(e.Location)
                    If clickInfo IsNot Nothing AndAlso clickInfo.HasId("btnAdd") Then listControl.Items.AddRange(items)
                End If
            End Sub
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Grid control", "CustomDraw.cs")>
    Public Module CustomDraw_GridControl

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim gridControl As DevExpress.XtraGrid.GridControl = New DevExpress.XtraGrid.GridControl()
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            gridControl.Parent = sampleHost
            gridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(6)
            Return New Object() {gridControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("The CustomDrawRowPreview event")>
        <DevExpress.HTML.Demos.CodeExamples.HtmlFile("CustomDraw.GridViewRowPreview"), DevExpress.HTML.Demos.CodeExamples.CssFile("CustomDraw.GridViewRowPreview"), DevExpress.HTML.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomDrawRowPreview")>
        Public Sub CustomDrawRowPreview(ByVal gridControl As DevExpress.XtraGrid.GridControl)
            ' configure GridView
            Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            gridControl.MainView = gridView
            gridView.Columns(CStr(("Notes"))).Visible = False
            gridView.OptionsView.ShowPreview = True
            gridView.PreviewLineCount = 2
            ' local painting context which contains html tree state
            Dim ctx As DevExpress.Utils.Html.DxHtmlPainterContext = New DevExpress.Utils.Html.DxHtmlPainterContext()
            ' handle html-template painting
            Dim htmlTemplate As DevExpress.Utils.Html.HtmlTemplate = New DevExpress.Utils.Html.HtmlTemplate(DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("GridViewRowPreview.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("GridViewRowPreview.css"))
            AddHandler gridView.CustomDrawRowPreview, Sub(s, e)
                Dim index As Integer = TryCast(s, DevExpress.XtraGrid.Views.Grid.GridView).GetDataSourceRowIndex(e.RowHandle)
                e.DrawHtml(htmlTemplate, ctx, Sub(args) args.InteractivityKey = index)
                e.Handled = True
            End Sub
            ' handle UI feedback (hover/cursor)
            AddHandler gridView.MouseMove, Sub(s, e)
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(s, DevExpress.XtraGrid.Views.Grid.GridView)
                Dim hitInfo As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo = view.CalcHitInfo(e.Location)
                If hitInfo.RowHandle >= 0 Then
                    Dim index As Integer = view.GetDataSourceRowIndex(hitInfo.RowHandle)
                    ctx.OnMouseMove(e, index)
                    view.GridControl.Cursor = ctx.GetCursor(e.Location, index)
                    view.InvalidateRow(hitInfo.RowHandle)
                End If
            End Sub
            ' handle Click within the link element
            AddHandler gridView.MouseDown, Sub(s, e)
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(s, DevExpress.XtraGrid.Views.Grid.GridView)
                Dim rowHitInfo As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo = view.CalcHitInfo(e.Location)
                If rowHitInfo.RowHandle >= 0 Then
                    Dim index As Integer = view.GetDataSourceRowIndex(rowHitInfo.RowHandle)
                    Dim htmlHitInfo As DevExpress.Utils.Html.DxHtmlHitInfo = ctx.CalcHitInfo(e.Location, index)
                    If htmlHitInfo IsNot Nothing AndAlso htmlHitInfo.HasClassName("link") Then
                        Dim name As String = CStr(view.GetRowCellValue(rowHitInfo.RowHandle, "Name"))
                        ctx.OnMouseLeave(e, index)
                        Call DevExpress.XtraEditors.XtraMessageBox.Show("Getting information about " & name & "...")
                    End If
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("The TileView's CustomDrawTile event")>
        <DevExpress.HTML.Demos.CodeExamples.HtmlFile("CustomDraw.TileViewItem"), DevExpress.HTML.Demos.CodeExamples.CssFile("CustomDraw.TileViewItem"), DevExpress.HTML.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomDrawTile")>
        Public Sub CustomDrawTile(ByVal gridControl As DevExpress.XtraGrid.GridControl)
            ' create TileView
            Dim tileView As DevExpress.XtraGrid.Views.Tile.TileView = New DevExpress.XtraGrid.Views.Tile.TileView()
            gridControl.MainView = tileView
            ' local painting context which contains html tree state
            Dim ctx As DevExpress.Utils.Html.DxHtmlPainterContext = New DevExpress.Utils.Html.DxHtmlPainterContext()
            ' handle html-template painting
            Dim htmlTemplate As DevExpress.Utils.Html.HtmlTemplate = New DevExpress.Utils.Html.HtmlTemplate(DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("TileViewItem.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("TileViewItem.css"))
            AddHandler tileView.CustomDrawTile, Sub(s, e)
                Dim obj As DevExpress.DXperience.Demos.CodeDemo.Data.SampleData = TryCast(tileView.GetRow(e.RowHandle), DevExpress.DXperience.Demos.CodeDemo.Data.SampleData)
                If obj.Mark Then
                    If e.DrawingProcess = DevExpress.XtraGrid.Views.Tile.TileViewItemCustomDrawProcess.DrawTile Then
                        e.DrawBackground()
                        e.DrawHtml(htmlTemplate, ctx, Sub(args) args.InteractivityKey = obj.ID)
                        e.DrawBorder()
                        e.Handled = True
                    End If
                End If
            End Sub
            ' handle UI feedback (hover/cursor)
            AddHandler tileView.MouseMove, Sub(s, e)
                Dim view As DevExpress.XtraGrid.Views.Tile.TileView = TryCast(s, DevExpress.XtraGrid.Views.Tile.TileView)
                Dim hitInfo As DevExpress.XtraGrid.Views.Tile.ViewInfo.TileViewHitInfo = view.CalcHitInfo(e.Location)
                If hitInfo.RowHandle >= 0 Then
                    Dim obj As DevExpress.DXperience.Demos.CodeDemo.Data.SampleData = TryCast(tileView.GetRow(hitInfo.RowHandle), DevExpress.DXperience.Demos.CodeDemo.Data.SampleData)
                    If obj.Mark Then
                        ctx.OnMouseMove(e, obj.ID)
                        view.GridControl.Cursor = ctx.GetCursor(e.Location, obj.ID)
                        view.InvalidateRect(hitInfo.ItemInfo.Bounds)
                    Else
                        view.GridControl.Cursor = System.Windows.Forms.Cursors.[Default]
                    End If
                End If
            End Sub
            ' handle Click within the link element
            AddHandler tileView.MouseDown, Sub(s, e)
                Dim view As DevExpress.XtraGrid.Views.Tile.TileView = TryCast(s, DevExpress.XtraGrid.Views.Tile.TileView)
                Dim hitInfo As DevExpress.XtraGrid.Views.Tile.ViewInfo.TileViewHitInfo = view.CalcHitInfo(e.Location)
                If hitInfo.RowHandle >= 0 Then
                    Dim obj As DevExpress.DXperience.Demos.CodeDemo.Data.SampleData = TryCast(tileView.GetRow(hitInfo.RowHandle), DevExpress.DXperience.Demos.CodeDemo.Data.SampleData)
                    If obj.Mark Then
                        Dim htmlHitInfo As DevExpress.Utils.Html.DxHtmlHitInfo = ctx.CalcHitInfo(e.Location, obj.ID)
                        If htmlHitInfo IsNot Nothing AndAlso htmlHitInfo.HasClassName("show-action") Then
                            obj.Mark = False
                            ctx.OnMouseLeave(e, obj.ID)
                            view.InvalidateRect(hitInfo.ItemInfo.Bounds)
                        End If

                        TryCast(e, DevExpress.Utils.DXMouseEventArgs).Handled = True
                    End If
                End If
            End Sub
            ' configure TileTemplate
            tileView.OptionsTiles.RowCount = 2
            tileView.OptionsTiles.ItemSize = New System.Drawing.Size(180, 100)
            Dim tileElementName = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement() With {.Column = tileView.Columns("Name")}
            Dim tileElementDesc = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement() With {.Column = tileView.Columns("Notes")}
            tileView.TileTemplate.Add(tileElementName)
            tileView.TileTemplate.Add(tileElementDesc)
            tileElementName.Appearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold
            tileElementDesc.AnchorElement = tileElementName
            tileElementDesc.AnchorIndent = 5
            tileElementDesc.MaxLineCount = 5
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("TreeList control", "CustomDraw.cs")>
    Public Module CustomDraw_TreeList

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim treeList = New DevExpress.XtraTreeList.TreeList()
            treeList.Dock = System.Windows.Forms.DockStyle.Fill
            treeList.Parent = sampleHost
            treeList.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject.LoadData()
            treeList.ExpandToLevel(0)
            Return New Object() {treeList}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("The CustomDrawRowPreview event")>
        <DevExpress.HTML.Demos.CodeExamples.HtmlFile("CustomDraw.TreeListRowPreview"), DevExpress.HTML.Demos.CodeExamples.CssFile("CustomDraw.TreeListRowPreview"), DevExpress.HTML.Demos.CodeExamples.SpaceObjectCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomDrawNodePreview")>
        Public Sub CustomDrawRowPreview(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' configure Preview section
            treeList.Columns(CStr(("Notes"))).Visible = False
            treeList.OptionsView.ShowPreview = True
            treeList.PreviewFieldName = "Notes"
            treeList.PreviewLineCount = 2
            ' local painting context which contains html tree state
            Dim ctx As DevExpress.Utils.Html.DxHtmlPainterContext = New DevExpress.Utils.Html.DxHtmlPainterContext()
            ' handle html-template painting
            Dim htmlTemplate As DevExpress.Utils.Html.HtmlTemplate = New DevExpress.Utils.Html.HtmlTemplate(DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("TreeListRowPreview.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("TreeListRowPreview.css"))
            AddHandler treeList.CustomDrawNodePreview, Sub(s, e)
                e.DrawHtml(htmlTemplate, ctx, Sub(args) args.InteractivityKey = e.Node.Id)
                e.Handled = True
            End Sub
            ' handle UI feedback (hover/cursor)
            AddHandler treeList.MouseMove, Sub(s, e)
                Dim control As DevExpress.XtraTreeList.TreeList = TryCast(s, DevExpress.XtraTreeList.TreeList)
                Dim hitInfo As DevExpress.XtraTreeList.TreeListHitInfo = control.CalcHitInfo(e.Location)
                If hitInfo.Node IsNot Nothing Then
                    ctx.OnMouseMove(e, hitInfo.Node.Id)
                    control.Cursor = ctx.GetCursor(e.Location, hitInfo.Node.Id)
                    control.InvalidateRowPreview(hitInfo.Node)
                End If
            End Sub
            ' handle Click within the link element
            AddHandler treeList.MouseDown, Sub(s, e)
                Dim control As DevExpress.XtraTreeList.TreeList = TryCast(s, DevExpress.XtraTreeList.TreeList)
                Dim hitInfo As DevExpress.XtraTreeList.TreeListHitInfo = control.CalcHitInfo(e.Location)
                If hitInfo.Node IsNot Nothing Then
                    Dim htmlHitInfo As DevExpress.Utils.Html.DxHtmlHitInfo = ctx.CalcHitInfo(e.Location, hitInfo.Node.Id)
                    If htmlHitInfo IsNot Nothing AndAlso htmlHitInfo.HasClassName("link") Then
                        Dim name As String = CStr(control.GetRowCellValue(hitInfo.Node, "Name"))
                        ctx.OnMouseLeave(e, hitInfo.Node.Id)
                        Call DevExpress.XtraEditors.XtraMessageBox.Show("Getting information about " & name & "...")
                    End If
                End If
            End Sub
        End Sub
    End Module
End Namespace
