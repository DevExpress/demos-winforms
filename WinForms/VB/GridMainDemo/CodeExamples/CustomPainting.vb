Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Data
Imports System.Drawing
Imports DevExpress.Data.Filtering
Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Drawing
Imports DevExpress.Utils.Drawing
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS

Namespace DevExpress.XtraGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Custom painting", "CustomPainting.cs")>
    Public Module CustomPainting

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

#Region "CustomPainting"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("CustomDrawCell"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomDrawCell")>
        Public Sub CustomDrawCell(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' Handle this event to paint cells manually
            AddHandler gridView.CustomDrawCell, Sub(s, e)
                If e.Column.VisibleIndex <> 2 Then Return
                e.Cache.FillRectangle(System.Drawing.Color.Salmon, e.Bounds)
                e.Appearance.DrawString(e.Cache, e.DisplayText, e.Bounds)
                e.Handled = True
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("CustomDrawColumnHeader"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomDrawColumnHeader")>
        Public Sub CustomDrawColumnHeader(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' Handle this event to paint columns headers manually
            AddHandler gridView.CustomDrawColumnHeader, Sub(s, e)
                If e.Column Is Nothing OrElse Not Equals(e.Column.FieldName, "Name") Then Return
                ' Fill column headers with the specified colors.
                e.Cache.FillRectangle(System.Drawing.Color.Coral, e.Bounds)
                e.Appearance.DrawString(e.Cache, e.Info.Caption, e.Info.CaptionRect)
                ' Draw the filter and sort buttons.
                For Each info As DevExpress.Utils.Drawing.DrawElementInfo In e.Info.InnerElements
                    If Not info.Visible Then Continue For
                    Call DevExpress.Utils.Drawing.ObjectPainter.DrawObject(e.Cache, info.ElementPainter, info.ElementInfo)
                Next

                e.Handled = True
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("CustomDrawFooter"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomDrawFooter", "CustomDrawCell")>
        Public Sub CustomDrawFooter(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.OptionsView.ShowFooter = True
            gridView.FooterPanelHeight = 70
            Dim highPriority As System.Drawing.Color = System.Drawing.Color.Green
            Dim normalPriority As System.Drawing.Color = System.Drawing.Color.Orange
            Dim lowPriority As System.Drawing.Color = System.Drawing.Color.Red
            Dim markWidth As Integer = 16
            ' Handle this event to paint the footer panel manually
            AddHandler gridView.CustomDrawFooter, Sub(s, e)
                Dim offset As Integer = 5
                e.DefaultDraw()
                Dim color As System.Drawing.Color = highPriority
                Dim markRectangle As System.Drawing.Rectangle
                Dim priorityText As String = " - High level"
                For i As Integer = 0 To 3 - 1
                    If i = 1 Then
                        color = normalPriority
                        priorityText = " - Normal level"
                    ElseIf i = 2 Then
                        color = lowPriority
                        priorityText = " - Low level"
                    End If

                    markRectangle = New System.Drawing.Rectangle(e.Bounds.X + offset, e.Bounds.Y + offset + (markWidth + offset) * i, markWidth, markWidth)
                    e.Cache.FillEllipse(markRectangle.X, markRectangle.Y, markRectangle.Width, markRectangle.Height, color)
                    e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                    e.Appearance.Options.UseTextOptions = True
                    e.Appearance.DrawString(e.Cache, priorityText, New System.Drawing.Rectangle(markRectangle.Right + offset, markRectangle.Y, e.Bounds.Width, markRectangle.Height))
                Next
            End Sub
            AddHandler gridView.CustomDrawCell, Sub(s, e)
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                e.Appearance.Options.UseTextOptions = True
                e.DefaultDraw()
                If Equals(e.Column.FieldName, "ID") Then
                    Dim color As System.Drawing.Color
                    Dim cellValue As Integer = System.Convert.ToInt32(e.CellValue)
                    If cellValue < 3 Then
                        color = highPriority
                    ElseIf cellValue > 2 AndAlso cellValue < 5 Then
                        color = normalPriority
                    Else
                        color = lowPriority
                    End If

                    e.Cache.FillEllipse(e.Bounds.X + 1, e.Bounds.Y + 1, markWidth, markWidth, color)
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("CustomDrawFooterCell"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomDrawFooterCell")>
        Public Sub CustomDrawFooterCell(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.OptionsView.ShowFooter = True
            gridView.FooterPanelHeight = 70
            gridView.Columns(CStr(("ID"))).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Average
            ' Handle this event to paint footer cells manually
            AddHandler gridView.CustomDrawFooterCell, Sub(s, e)
                e.Bounds.Inflate(-5, -5)
                e.Appearance.ForeColor = System.Drawing.Color.Teal
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                e.Appearance.FontSizeDelta = 7
                e.DefaultDraw()
                e.Cache.DrawRectangle(e.Cache.GetPen(System.Drawing.Color.DarkOliveGreen, 5), e.Bounds)
                e.Handled = True
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("CustomDrawEmptyForeground"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomDrawEmptyForeground")>
        Public Sub CustomDrawEmptyForeground(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            Dim searchName As String = String.Empty
            gridView.ActiveFilterCriteria = New DevExpress.Data.Filtering.BinaryOperator("Name", searchName)
            ' Initialize variables used to paint View's empty space in a custom manner
            Dim noMatchesFoundTextFont As System.Drawing.Font = New System.Drawing.Font("Tahoma", 10)
            Dim trySearchingAgainTextFont As System.Drawing.Font = New System.Drawing.Font("Tahoma", 15, System.Drawing.FontStyle.Underline)
            Dim trySearchingAgainTextFontBold As System.Drawing.Font = New System.Drawing.Font(trySearchingAgainTextFont, System.Drawing.FontStyle.Underline Or System.Drawing.FontStyle.Bold)
            Dim linkBrush As System.Drawing.SolidBrush = New System.Drawing.SolidBrush(DevExpress.Skins.EditorsSkins.GetSkin(CType((DevExpress.LookAndFeel.UserLookAndFeel.[Default].ActiveLookAndFeel), DevExpress.Skins.ISkinProvider)).Colors("HyperLinkTextColor"))
            Dim noMatchesFoundText As String = "No matches found"
            Dim trySearchingAgainText As String = "Try searching again"
            Dim noMatchesFoundBounds As System.Drawing.Rectangle = System.Drawing.Rectangle.Empty
            Dim trySearchingAgainBounds As System.Drawing.Rectangle = System.Drawing.Rectangle.Empty
            Dim trySearchingAgainBoundsContainCursor As Boolean = False
            Dim offset As Integer = 10
            'Handle this event to paint View's empty space in a custom manner
            AddHandler gridView.CustomDrawEmptyForeground, Sub(s, e)
                e.DefaultDraw()
                e.Appearance.Options.UseFont = True
                e.Appearance.Font = noMatchesFoundTextFont
                'Draw the noMatchesFoundText string
                Dim size As System.Drawing.Size = e.Appearance.CalcTextSize(CType((e.Cache), DevExpress.Utils.Drawing.GraphicsCache), CStr((noMatchesFoundText)), CInt((e.Bounds.Width))).ToSize()
                Dim x As Integer =(e.Bounds.Width - size.Width) \ 2
                Dim y As Integer = e.Bounds.Y + offset
                noMatchesFoundBounds = New System.Drawing.Rectangle(New System.Drawing.Point(x, y), size)
                e.Appearance.DrawString(e.Cache, noMatchesFoundText, noMatchesFoundBounds)
                'Draw the trySearchingAgain link
                e.Appearance.Font = If(trySearchingAgainBoundsContainCursor, trySearchingAgainTextFontBold, trySearchingAgainTextFont)
                size = e.Appearance.CalcTextSize(CType((e.Cache), DevExpress.Utils.Drawing.GraphicsCache), CStr((trySearchingAgainText)), CInt((e.Bounds.Width))).ToSize()
                x = noMatchesFoundBounds.X - (size.Width - noMatchesFoundBounds.Width) \ 2
                y = noMatchesFoundBounds.Bottom + offset
                size.Width += offset
                trySearchingAgainBounds = New System.Drawing.Rectangle(New System.Drawing.Point(x, y), size)
                e.Appearance.DrawString(e.Cache, trySearchingAgainText, trySearchingAgainBounds, linkBrush)
            End Sub
            AddHandler gridView.MouseMove, Sub(s, e)
                trySearchingAgainBoundsContainCursor = trySearchingAgainBounds.Contains(e.Location)
                gridControl.Cursor = If(trySearchingAgainBoundsContainCursor, System.Windows.Forms.Cursors.Hand, System.Windows.Forms.Cursors.[Default])
                gridView.InvalidateRect(trySearchingAgainBounds)
            End Sub
            AddHandler gridView.MouseDown, Sub(s, e)
                If trySearchingAgainBoundsContainCursor Then
                    searchName = DevExpress.XtraEditors.XtraInputBox.Show(String.Format("Enter {0}", "Name"), String.Format("Enter {0} dialog", "Name"), searchName)
                    gridView.ActiveFilterCriteria = New DevExpress.Data.Filtering.BinaryOperator("Name", searchName)
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("CustomDrawFilterPanel"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomDrawFilterPanel", "FilterCriteriaDisplayStyle")>
        Public Sub CustomDrawFilterPanel(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.ActiveFilterString = String.Format("[{0}] > 2", "ID")
            gridView.OptionsView.FilterCriteriaDisplayStyle = DevExpress.XtraEditors.FilterCriteriaDisplayStyle.Text
            ' Handle this event to paint the filter panel manually
            AddHandler gridView.CustomDrawFilterPanel, Sub(s, e)
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(s, DevExpress.XtraGrid.Views.Grid.GridView)
                Dim info As DevExpress.XtraGrid.Drawing.GridFilterPanelInfoArgs = TryCast(e.Info, DevExpress.XtraGrid.Drawing.GridFilterPanelInfoArgs)
                e.Cache.FillRectangle(System.Drawing.Color.BlanchedAlmond, e.Bounds)
                e.Appearance.ForeColor = System.Drawing.Color.DimGray
                e.Appearance.DrawString(e.Cache, info.DisplayText, info.TextBounds)
                Dim painter As DevExpress.XtraGrid.Drawing.SkinGridFilterPanelPainter = TryCast(e.Painter, DevExpress.XtraGrid.Drawing.SkinGridFilterPanelPainter)
                info.ActiveButtonInfo.CheckState = If(view.ActiveFilterEnabled, System.Windows.Forms.CheckState.Checked, System.Windows.Forms.CheckState.Unchecked)
                Call DevExpress.Utils.Drawing.ObjectPainter.DrawObject(e.Cache, painter.CheckPainter, info.ActiveButtonInfo)
                Call DevExpress.Utils.Drawing.ObjectPainter.DrawObject(e.Cache, painter.ButtonPainter, info.CustomizeButtonInfo)
                Call DevExpress.Utils.Drawing.ObjectPainter.DrawObject(e.Cache, painter.ButtonPainter, info.CloseButtonInfo)
                e.Handled = True
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("CustomDrawGroupPanel"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomDrawGroupPanel")>
        Public Sub CustomDrawGroupPanel(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel
            ' Handle this event to paint GroupPanel in a custom manner
            AddHandler gridView.CustomDrawGroupPanel, Sub(s, e)
                e.DefaultDraw()
                Dim text As String = "DevExpress"
                Dim textSize As System.Drawing.Size = e.Appearance.CalcTextSizeInt(e.Cache, text, e.Bounds.Width)
                Dim rect As System.Drawing.Rectangle = New System.Drawing.Rectangle(e.Bounds.Right - textSize.Width, e.Bounds.Y, textSize.Width, e.Bounds.Height - 1)
                e.Cache.FillRectangle(System.Drawing.Color.Maroon, rect)
                e.Appearance.DrawString(e.Cache, text, rect)
                e.Handled = True
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("CustomDrawGroupRow"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomDrawGroupRow")>
        Public Sub CustomDrawGroupRow(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.Columns(CStr(("ID"))).Group()
            ' Handle this event to paint group rows manually
            AddHandler gridView.CustomDrawGroupRow, Sub(s, e)
                If e.RowHandle Mod 2 = 0 Then
                    e.Appearance.BackColor = System.Drawing.Color.BlanchedAlmond
                    e.Appearance.ForeColor = System.Drawing.Color.DimGray
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("CustomDrawGroupRowCell"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomDrawGroupRowCell")>
        Public Sub CustomDrawGroupRowCell(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.[True]
            ' group summaries
            Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = New DevExpress.XtraGrid.GridGroupSummaryItem() With {.FieldName = "Length", .SummaryType = DevExpress.Data.SummaryItemType.Sum, .ShowInGroupColumnFooter = gridView.Columns("Length")}
            gridView.GroupSummary.Add(item)
            item = New DevExpress.XtraGrid.GridGroupSummaryItem() With {.FieldName = "Mark", .SummaryType = DevExpress.Data.SummaryItemType.Count, .ShowInGroupColumnFooter = gridView.Columns("Mark")}
            gridView.GroupSummary.Add(item)
            gridView.Columns(CStr(("ID"))).Group()
            ' Handle this event to paint group row cells manually
            AddHandler gridView.CustomDrawGroupRowCell, Sub(s, e)
                e.Appearance.BackColor = System.Drawing.Color.BlanchedAlmond
                e.Appearance.FillRectangle(e.Cache, e.Bounds)
                e.Appearance.ForeColor = System.Drawing.Color.DimGray
                e.Appearance.DrawString(e.Cache, e.DisplayText, e.Bounds)
                e.Handled = True
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("CustomDrawRowIndicator"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomDrawRowIndicator")>
        Public Sub CustomDrawRowIndicator(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.IndicatorWidth = 50
            ' Handle this event to paint RowIndicator manually
            AddHandler gridView.CustomDrawRowIndicator, Sub(s, e)
                If Not e.Info.IsRowIndicator Then Return
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(s, DevExpress.XtraGrid.Views.Grid.GridView)
                e.Handled = True
                e.Appearance.BackColor = If(view.FocusedRowHandle = e.RowHandle, System.Drawing.Color.Chocolate, System.Drawing.Color.MediumSpringGreen)
                e.Appearance.FillRectangle(e.Cache, New System.Drawing.Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Width - 4, e.Bounds.Y - 4))
                If e.Info.ImageIndex < 0 Then Return
                Dim ic As DevExpress.Utils.ImageCollection = TryCast(e.Info.ImageCollection, DevExpress.Utils.ImageCollection)
                Dim indicator As System.Drawing.Image = ic.Images(e.Info.ImageIndex)
                e.Cache.DrawImage(indicator, New System.Drawing.Rectangle(e.Bounds.X + 20, e.Bounds.Y + 6, indicator.Width, indicator.Height))
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("CustomDrawRowPreview  "), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomDrawRowPreview")>
        Public Sub CustomDrawRowPreview(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.Columns(CStr(("Notes"))).Visible = False
            gridView.PreviewFieldName = "Notes"
            gridView.PreviewLineCount = 2
            gridView.OptionsView.ShowPreview = True
            ' Handle this event to paint Preview row manually
            AddHandler gridView.CustomDrawRowPreview, Sub(s, e)
                If e.RowHandle = 2 Then
                    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(s, DevExpress.XtraGrid.Views.Grid.GridView)
                    Dim dx As Integer = 5
                    ' A rectangle for displaying text.
                    Dim r As System.Drawing.Rectangle = e.Bounds
                    r.X += e.Bounds.Height + dx * 2
                    r.Width -=(e.Bounds.Height + dx * 3)
                    e.Cache.FillRectangle(System.Drawing.Color.Coral, New System.Drawing.Rectangle(e.Bounds.X + dx, e.Bounds.Y, e.Bounds.Height, e.Bounds.Height))
                    e.Appearance.ForeColor = System.Drawing.Color.Green
                    e.Appearance.DrawString(e.Cache, view.GetRowPreviewDisplayText(e.RowHandle), r)
                    e.Handled = True
                End If
            End Sub
        End Sub
#End Region
    End Module
End Namespace
