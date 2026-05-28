Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.ActiveDemos
Imports DevExpress.Data.Utils
Imports DevExpress.Export
Imports DevExpress.Spreadsheet
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraVerticalGrid.ViewInfo

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class ClipboardTutorial
        Inherits TutorialControl

#Region "Active Demo"
        Public Overrides ReadOnly Property HasActiveDemo As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides Function CreateActiveDemo() As ActiveDemo
            Return New ActiveGridDemo(gridControl1)
        End Function

        Private activeDemoSelectCellsWithMouse As Boolean = False

        Protected Overrides Sub RunGridActiveDemo(ByVal activeDemo As ActiveGridDemo)
            Try
                InitActiveDemo()
                Greeting(activeDemo)
                If activeDemo.Actions.Canceled Then Return
                ExpandOptionsBtnClick(activeDemo)
                SelectPropertyGridOption(activeDemo, "AllowHtmlFormat", Utils.DefaultBoolean.True)
                If activeDemo.Actions.Canceled Then Return
                SelectPropertyGridOption(activeDemo, "ClipboardMode", ClipboardMode.Formatted)
                If activeDemo.Actions.Canceled Then Return
                SelectPropertyGridOption(activeDemo, "CopyCollapsedData", Utils.DefaultBoolean.True)
                If activeDemo.Actions.Canceled Then Return
                ExpandOptionsBtnClick(activeDemo)
                ModifyGrid(activeDemo)
                If activeDemo.Actions.Canceled Then Return
                SelectCells(activeDemo)
                If activeDemo.Actions.Canceled Then Return
                PressCopyBtn(activeDemo)
            Catch
                propertyGridControl.ExpandAllRows()
                gridViewPropertiesLayoutGroup.Expanded = False
                gridView1.ClearSelection()
                gridView1.ClearGrouping()
                gridView1.Appearance.SelectedRow.BackColor = Color.FromArgb(60, 0, 0, 240)
                gridView1.OptionsSelection.EnableAppearanceHideSelection = False
                gridView1.BestFitColumns()
                gridView1.SelectCellAnchorRange(2, colState, 20, colMarketShare)
                ActiveDemoResults.Clear()
                ActiveDemoResults.Hide()
                XtraEditors.XtraMessageBox.Show(gridControl1, "The Active Demo has encountered a problem and needs to close. Try running the DevExpress Components installation in 'Repair' mode to fix the Demo Center.")
            End Try
        End Sub

        Private Sub InitActiveDemo()
            gridView1.OptionsClipboard.AllowHtmlFormat = Utils.DefaultBoolean.Default
            gridView1.OptionsClipboard.ClipboardMode = ClipboardMode.Default
            gridView1.OptionsClipboard.CopyCollapsedData = Utils.DefaultBoolean.Default
            propertyGridControl.UpdateData()
            gridViewPropertiesLayoutGroup.Expanded = False
            gridView1.ClearSelection()
            gridView1.ClearGrouping()
            richEditControl.Document.RtfText = String.Empty
            spreadsheetControl1.ActiveWorksheet.Clear(spreadsheetControl1.ActiveWorksheet.GetDataRange())
            webBrowser1.DocumentText = String.Empty
            AddHandler gridView1.MouseMove, AddressOf SelectCellsWithMouse
        End Sub

        Private Sub Greeting(ByVal activeDemo As ActiveGridDemo)
            Dim mouseTo As Point = New Point(gridControl1.Width \ 2, gridControl1.Height \ 4)
            activeDemo.Actions.MoveMousePointTo(gridControl1, mouseTo)
            activeDemo.ShowMessage(Properties.Resources.ClipboardActiveDemoGridDataToCopy)
            mouseTo = New Point(7 * gridControl1.Width \ 8, gridControl1.Height \ 8)
            activeDemo.Actions.MoveMousePointTo(gridControl1, mouseTo)
            activeDemo.ShowMessage(Properties.Resources.ClipboardActiveDemoCustomizeOptions)
        End Sub

        Private Sub ExpandOptionsBtnClick(ByVal activeDemo As ActiveGridDemo)
            Dim mouseTo As Point = New Point(gridViewPropertiesLayoutGroup.ViewInfo.BorderInfo.ButtonBounds.X - gridViewPropertiesLayoutGroup.Bounds.X + gridViewPropertiesLayoutGroup.ViewInfo.BorderInfo.ButtonBounds.Width \ 2, gridViewPropertiesLayoutGroup.ViewInfo.BorderInfo.ButtonBounds.Y - gridViewPropertiesLayoutGroup.Bounds.Y + gridViewPropertiesLayoutGroup.ViewInfo.BorderInfo.ButtonBounds.Height \ 2)
            activeDemo.Actions.MouseClick(propertyGridControl, mouseTo)
        End Sub

        Private Sub SelectPropertyGridOption(ByVal activeDemo As ActiveGridDemo, ByVal optionName As String, ByVal optionValue As Object)
            Dim dropDownBtnWidth As Integer = SystemInformation.VerticalScrollBarWidth
            Dim dropDownBtnHeight As Integer = SystemInformation.VerticalScrollBarThumbHeight
            Dim allowHtml As BaseRowViewInfo = propertyGridControl.ViewInfo.GetRowValueInfo(propertyGridControl.GetRowByFieldName(optionName), 0, 0).RowViewInfo
            Dim mouseTo As Point = New Point(allowHtml.ValuesRect.X + allowHtml.ValuesRect.Width - dropDownBtnWidth \ 2, allowHtml.ValuesRect.Y + dropDownBtnWidth \ 2)
            activeDemo.Actions.MouseClick(propertyGridControl, mouseTo)
            ActiveActions.Delay(1000)
            Dim items As XtraEditors.Controls.ImageComboBoxItemCollection = TryCast(propertyGridControl.ActiveEditor.Properties, XtraEditors.Repository.RepositoryItemImageComboBox).Items
            Dim index As Integer = items.IndexOf(items.FirstOrDefault(Function(x) x.Value.Equals(optionValue.ToString())))
            Dim cache = GraphicsInfo.Default.AddCache(Nothing)
            mouseTo = New Point(allowHtml.ValuesRect.X + allowHtml.ValuesRect.Width \ 2, allowHtml.ValuesRect.Y + allowHtml.ValuesRect.Height + CInt(((index + 0.5) * allowHtml.ValuesInfo(0).Item.Appearance.GetFontHeight(cache))))
            Call GraphicsInfo.Default.ReleaseGraphics()
            activeDemo.Actions.MoveMousePointTo(propertyGridControl, mouseTo)
            ActiveActions.Delay(500)
            activeDemo.Actions.MouseClick()
            ActiveDemoResults.Add(String.Format("{0} : {1}", optionName, optionValue.ToString()))
        End Sub

        Private Sub ModifyGrid(ByVal activeDemo As ActiveGridDemo)
            Dim mouseTo As Point = New Point(gridControl1.Width \ 2, gridControl1.Height \ 4)
            activeDemo.Actions.MoveMousePointTo(gridControl1, mouseTo)
            activeDemo.ShowMessage(Properties.Resources.ClipboardActiveDemoModifyLayout)
            activeDemo.GroupByColumn(colSalesVsTarget)
            ActiveDemoResults.Add(String.Format(Properties.Resources.ClipboardActiveDemoGroupBy, colSalesVsTarget.ToString()))
            activeDemo.ExpandCollapseRow(gridView1, 0)
            activeDemo.ExpandCollapseRow(gridView1, 1)
            activeDemo.ExpandCollapseRow(gridView1, 2)
            ActiveDemoResults.Add(String.Format(Properties.Resources.ClipboardActiveDemoExpandedRows, 0, 1, 2))
            gridView1.FocusedRowHandle = -7
        End Sub

        Private Sub SelectCells(ByVal activeDemo As ActiveGridDemo)
            Dim mouseTo As Point = New Point(gridControl1.Width \ 2, gridControl1.Height \ 4)
            activeDemo.Actions.MoveMousePointTo(gridControl1, mouseTo)
            activeDemo.ShowMessage(Properties.Resources.ClipboardActiveDemoSelectCells)
            Dim r1 As Rectangle = TryCast(gridView1.GetViewInfo(), GridViewInfo).GetGridRowInfo(-1).Bounds
            Dim r2 As Rectangle = TryCast(gridView1.GetViewInfo(), GridViewInfo).GetGridRowInfo(-6).Bounds
            mouseTo = New Point(r1.Left + r1.Width \ 6, r1.Top + r1.Height \ 2)
            activeDemo.Actions.MoveMousePointTo(gridControl1, mouseTo)
            activeDemoSelectCellsWithMouse = True
            mouseTo = New Point(r1.Right - r1.Width \ 6, r1.Bottom + r1.Height \ 2)
            activeDemo.Actions.MoveMousePointTo(gridControl1, mouseTo)
            mouseTo = New Point(r2.Right - r2.Width \ 6, r2.Top + r2.Height \ 2)
            activeDemo.Actions.MoveMousePointTo(gridControl1, mouseTo)
            activeDemoSelectCellsWithMouse = False
            activeDemo.ShowMessage(Properties.Resources.ClipboardActiveDemoCopyWithShortcut)
        End Sub

        Private Sub PressCopyBtn(ByVal activeDemo As ActiveGridDemo)
            Dim mouseTo As Point = New Point(copyPasteButtonLCI.Width \ 2, copyPasteButtonLCI.Height \ 2)
            activeDemo.Actions.MoveMousePointTo(copyPasteButtonLCI.Control, mouseTo)
            activeDemo.ShowMessage(Properties.Resources.ClipboardActiveDemoCopyWithButton)
            activeDemo.Actions.MouseClick(copyPasteButtonLCI.Control, mouseTo)
            mouseTo = New Point(0, 0)
            activeDemo.Actions.MoveMousePointTo(spreadsheetControl1, mouseTo)
            activeDemo.ShowMessage(Properties.Resources.ClipboardActiveDemoSelectionPasted)
        End Sub

        Private Sub SelectCellsWithMouse(ByVal sender As Object, ByVal e As MouseEventArgs)
            If Not activeDemoSelectCellsWithMouse Then Return
            Dim info As GridHitInfo = gridView1.CalcHitInfo(e.X, e.Y)
            If info.InGroupRow Then
                gridView1.SelectCells(-1, gridView1.VisibleColumns.First(), info.RowHandle, gridView1.VisibleColumns.Last())
            Else
                gridView1.SelectCells(-1, colState, info.RowHandle, info.Column)
            End If
        End Sub

#End Region
        Public Sub New()
            InitializeComponent()
            Init()
        End Sub

        Private Sub Init()
            gridControl1.DataSource = New BindingList(Of SaleOverviewData)(GenerateSales().ToList())
            propertyGridControl.SelectedObject = gridView1.OptionsClipboard
            propertyGridControl.ExpandAllRows()
            gridViewPropertiesLayoutGroup.Expanded = False
            gridView1.Appearance.SelectedRow.BackColor = Color.FromArgb(60, 0, 0, 240)
            gridView1.OptionsSelection.EnableAppearanceHideSelection = False
        End Sub

        Friend Sub PasteClipboardData()
            PasteHTMLFormat()
            PasteXLSFormat()
            PasteRTFFormat()
        End Sub

        Private Sub PasteRTFFormat()
            richEditControl.Document.RtfText = String.Empty
            richEditControl.Document.Text = String.Empty
            Try
                If gridView1.OptionsClipboard.ClipboardMode = ClipboardMode.Formatted Then
                    Dim rtfText As String = TryCast(SafeClipboardWin.Instance.GetData(DataFormats.Rtf), String)
                    richEditControl.Document.AppendRtfText(rtfText)
                Else
                    Dim text As String = TryCast(SafeClipboardWin.Instance.GetData(DataFormats.UnicodeText), String)
                    richEditControl.Document.AppendText(text)
                End If
            Catch
            End Try
        End Sub

        Private Sub PasteXLSFormat()
            spreadsheetControl1.BeginUpdate()
            spreadsheetControl1.ActiveWorksheet.Clear(spreadsheetControl1.ActiveWorksheet.GetDataRange())
            Try
                If gridView1.OptionsClipboard.ClipboardMode = ClipboardMode.Formatted Then
                    Dim stream As Stream = TryCast(SafeClipboardWin.Instance.GetData("Biff8"), Stream)
                    If stream IsNot Nothing Then spreadsheetControl1.LoadDocument(stream, DocumentFormat.Xls)
                Else
                    Dim nextRow As Integer = 0
                    Dim text As String = TryCast(SafeClipboardWin.Instance.GetData(DataFormats.UnicodeText), String)
                    For Each line In text.Split(Microsoft.VisualBasic.Strings.ChrW(10))
                        spreadsheetControl1.ActiveWorksheet.Import(line.Split(Microsoft.VisualBasic.Strings.ChrW(9)), nextRow, 0, False)
                        nextRow += 1
                    Next
                End If
            Catch
            End Try

            spreadsheetControl1.ActiveWorksheet.DefaultColumnWidthInPixels = spreadsheetControl1.Width \ gridView1.Columns.Count
            spreadsheetControl1.EndUpdate()
        End Sub

        Private Sub PasteHTMLFormat()
            If gridView1.OptionsClipboard.ClipboardMode = ClipboardMode.Formatted Then
                Dim html As String = ""
                Try
                    html = TryCast(SafeClipboardWin.Instance.GetData(DataFormats.Html), String)
                Catch
                End Try

                If String.IsNullOrEmpty(html) Then
                    webBrowser1.DocumentText = String.Empty
                    Return
                End If

                Dim htmlTagPos As Integer = html.IndexOf("<html", StringComparison.OrdinalIgnoreCase)
                If htmlTagPos < 0 Then Return
                html = html.Substring(htmlTagPos)
                webBrowser1.DocumentText = html
            Else
                webBrowser1.DocumentText = "<html><body><p align=""center"">Copying data in HTML format is not supported in this Clipboard Mode</p></body></html>"
            End If
        End Sub

        Private Sub ClipboardTutorial_Load(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.BestFitColumns()
            gridView1.SelectCellAnchorRange(2, colState, 20, colMarketShare)
        End Sub

        Private Sub simpleButtonCopyPaste_Click(ByVal sender As Object, ByVal e As EventArgs)
            gridControl1.CopyAndPaste()
        End Sub

        Private Sub layoutControl1_GroupExpandChanged(ByVal sender As Object, ByVal e As XtraLayout.Utils.LayoutGroupEventArgs)
            If gridViewPropertiesLayoutGroup.Expanded Then
                splitterItem1.Visibility = XtraLayout.Utils.LayoutVisibility.Always
            Else
                splitterItem1.Visibility = XtraLayout.Utils.LayoutVisibility.Never
            End If
        End Sub

        Private Sub gridView1_ShowingEditor(ByVal sender As Object, ByVal e As CancelEventArgs)
            e.Cancel = True
        End Sub
    End Class

    Public Class ClipboardGridControl
        Inherits GridControl

        Private userControlCore As ClipboardTutorial

        Friend ReadOnly Property ClipboardTutorial As ClipboardTutorial
            Get
                If userControlCore Is Nothing Then userControlCore = TryCast(Parent.Parent, ClipboardTutorial)
                Return userControlCore
            End Get
        End Property

        Public Sub CopyAndPaste()
            OnKeyDown(New KeyEventArgs(Keys.Control Or Keys.C))
        End Sub

        Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
            MyBase.OnKeyDown(e)
            If e.Control AndAlso e.KeyCode = Keys.C Then
                ClipboardTutorial.PasteClipboardData()
            End If
        End Sub
    End Class
End Namespace
