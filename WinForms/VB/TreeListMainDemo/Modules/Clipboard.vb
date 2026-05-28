Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.Export
Imports DevExpress.Spreadsheet

Namespace DevExpress.XtraTreeList.Demos

    Public Partial Class ClipboardFormats
        Inherits TutorialControl

        Public Overrides ReadOnly Property MainControl As TreeList
            Get
                Return treeList1
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"TreeListMainDemo\Modules\Clipboard"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "Clipboard"
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            Init()
        End Sub

        Private Sub Init()
            propertyGridControl.SelectedObject = treeList1.OptionsClipboard
            propertyGridControl.ExpandAllRows()
            gridViewPropertiesLayoutGroup.Expanded = False
        End Sub

        Friend Sub PasteClipboardData()
            PasteHTMLFormat()
            PasteXLSFormat()
            PasteRTFFormat()
        End Sub

        '<richEditControl>
        Private Sub PasteRTFFormat()
            richEditControl.Document.RtfText = String.Empty
            richEditControl.Document.Text = String.Empty
            Try
                If treeList1.OptionsClipboard.ClipboardMode = ClipboardMode.Formatted Then
                    Dim rtfText As String = TryCast(DevExpress.Data.Utils.SafeClipboardWin.Instance.GetData(DataFormats.Rtf), String)
                    richEditControl.Document.AppendRtfText(rtfText)
                Else
                    Dim text As String = TryCast(DevExpress.Data.Utils.SafeClipboardWin.Instance.GetData(DataFormats.UnicodeText), String)
                    richEditControl.Document.AppendText(text)
                End If
            Catch
            End Try
        End Sub

        '</richEditControl>
        Protected Overrides Sub OnUseEmptyRootPadding()
        End Sub

        '<spreadsheetControl1>
        Private Sub PasteXLSFormat()
            spreadsheetControl1.ActiveWorksheet.Clear(spreadsheetControl1.ActiveWorksheet.GetDataRange())
            Try
                If treeList1.OptionsClipboard.ClipboardMode = ClipboardMode.Formatted Then
                    Dim stream = TryCast(DevExpress.Data.Utils.SafeClipboardWin.Instance.GetData("Biff8"), Stream)
                    If stream IsNot Nothing Then spreadsheetControl1.LoadDocument(stream, DocumentFormat.Xls)
                Else
                    Dim nextRow As Integer = 0
                    Dim text As String = TryCast(DevExpress.Data.Utils.SafeClipboardWin.Instance.GetData(DataFormats.UnicodeText), String)
                    For Each line In text.Split(Microsoft.VisualBasic.Strings.ChrW(10))
                        spreadsheetControl1.ActiveWorksheet.Import(line.Split(Microsoft.VisualBasic.Strings.ChrW(9)), nextRow, 0, False)
                        nextRow += 1
                    Next
                End If
            Catch
            End Try

            spreadsheetControl1.ActiveWorksheet.DefaultColumnWidthInPixels = spreadsheetControl1.Width \ treeList1.Columns.Count
        End Sub

        '</spreadsheetControl1>
        '<webBrowser1>
        Private Sub PasteHTMLFormat()
            If treeList1.OptionsClipboard.ClipboardMode = ClipboardMode.Formatted Then
                Try
                    Dim html As String = TryCast(DevExpress.Data.Utils.SafeClipboardWin.Instance.GetData(DataFormats.Html), String)
                    If String.IsNullOrEmpty(html) Then
                        webBrowser1.DocumentText = String.Empty
                        Return
                    End If

                    html = html.Remove(0, html.Substring(0, html.IndexOf("<html", StringComparison.OrdinalIgnoreCase)).Length)
                    webBrowser1.DocumentText = html
                Catch
                End Try
            Else
                webBrowser1.DocumentText = "<html><body><p align=""center"">Copying data in HTML format is not supported in this Clipboard Mode</p></body></html>"
            End If
        End Sub

        '</webBrowser1>
        '<treeList1>
        Private Sub simpleButtonCopyPaste_Click(ByVal sender As Object, ByVal e As EventArgs)
            treeList1.CopyAndPaste()
        End Sub

        '</treeList1>
        Private Sub layoutControl1_GroupExpandChanged(ByVal sender As Object, ByVal e As XtraLayout.Utils.LayoutGroupEventArgs)
            If gridViewPropertiesLayoutGroup.Expanded Then
                splitterItem1.Visibility = XtraLayout.Utils.LayoutVisibility.Always
            Else
                splitterItem1.Visibility = XtraLayout.Utils.LayoutVisibility.Never
            End If
        End Sub

        Private Sub ClipboardFormats_Load(ByVal sender As Object, ByVal e As EventArgs)
            treeList1.DataSource = SalesDataGenerator.CreateData()
            treeList1.ExpandAll()
            treeList1.ForceInitialize()
            treeList1.BestFitColumns()
            treeList1.SelectCells(treeList1.Nodes(0), colRegion, treeList1.Nodes(0).LastNode, colMarketShare)
        End Sub

        Private Sub treeList_ShowingEditor(ByVal sender As Object, ByVal e As CancelEventArgs)
            e.Cancel = True
        End Sub
    End Class

    Public Class ClipboardTreeListControl
        Inherits TreeList

        Private userControlCore As ClipboardFormats

        Friend ReadOnly Property ClipboardFormats As ClipboardFormats
            Get
                If userControlCore Is Nothing Then userControlCore = TryCast(Parent.Parent, ClipboardFormats)
                Return userControlCore
            End Get
        End Property

        Public Sub CopyAndPaste()
            OnKeyDown(New KeyEventArgs(Keys.Control Or Keys.C))
        End Sub

        Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
            MyBase.OnKeyDown(e)
            If e.Control AndAlso e.KeyCode = Keys.C Then
                ClipboardFormats.PasteClipboardData()
            End If
        End Sub
    End Class
End Namespace
