Imports DevExpress.Drawing
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraCharts.Printing
Imports DevExpress.XtraCharts.Sankey
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms

Namespace DevExpress.XtraSankey.Demos

    Public Partial Class SankeyTutorialControl
        Inherits TutorialControlBase
        Implements IDXMenuManager

        Private ReadOnly imageFormats As Dictionary(Of String, DXImageFormat) = New Dictionary(Of String, DXImageFormat)() From {{"bmp", DXImageFormat.Bmp}, {"jpeg", DXImageFormat.Jpeg}, {"gif", DXImageFormat.Gif}, {"tiff", DXImageFormat.Tiff}, {"png", DXImageFormat.Png}}

        Public Sub New()
            AutoMergeRibbon = True
            Me.SuspendLayout()
            Name = "SankeyTutorialControl"
            Size = New Size(500, 500)
            Me.ResumeLayout(False)
        End Sub

        <DefaultValue(True)>
        Public Overrides Property AutoMergeRibbon As Boolean
            Get
                Return True
            End Get

            Set(ByVal value As Boolean)
            End Set
        End Property

        Public Overridable ReadOnly Property SankeyDiagramControl As SankeyDiagramControl
            Get
                Return Nothing
            End Get
        End Property

        Public Property MenuManager As IDXMenuManager

        Public Function ShouldSerializeMenuManager() As Boolean
            Return MenuManager IsNot Nothing
        End Function

        Public Sub ResetMenuManager()
            MenuManager = Nothing
        End Sub

        Private Function Clone(ByVal newForm As Form) As IDXMenuManager Implements IDXMenuManager.Clone
            Return Me
        End Function

        Private Sub DisposeManager() Implements IDXMenuManager.DisposeManager
        End Sub

        Private Sub ShowPopupMenu(ByVal menu As DXPopupMenu, ByVal control As Control, ByVal pos As Point) Implements IDXMenuManager.ShowPopupMenu
            MenuManagerHelper.ShowMenu(menu, LookAndFeel, MenuManager, control, pos)
        End Sub

        Private Function GetImageFormatsFilter() As String
            Dim result As String = String.Empty
            For Each format As String In imageFormats.Keys
                result += String.Format("{0} Image (*.{1})|*.{1}|", format.ToUpper(), format.ToLower())
            Next

            Return result.TrimEnd("|"c)
        End Function

        Protected Overrides Sub AllowExport()
            EnabledPrintExportActions(True, True, ExportFormats.PDF Or ExportFormats.MHT Or ExportFormats.RTF Or ExportFormats.XLS Or ExportFormats.XLSX Or ExportFormats.Image, False)
        End Sub

        Protected Overrides Sub ExportToCore(ByVal filename As String, ByVal ext As String)
            Dim sankey As SankeyDiagramControl = SankeyDiagramControl
            If sankey IsNot Nothing Then
                Dim currentCursor As Cursor = Cursor.Current
                Cursor.Current = Cursors.WaitCursor
                sankey.OptionsPrint.SizeMode = PrintSizeMode.Zoom
                If Equals(ext, "rtf") Then
                    sankey.ExportToRtf(filename)
                ElseIf Equals(ext, "pdf") Then
                    sankey.ExportToPdf(filename)
                ElseIf Equals(ext, "mht") Then
                    sankey.ExportToMht(filename)
                ElseIf Equals(ext, "xls") Then
                    sankey.ExportToXls(filename)
                ElseIf Equals(ext, "xlsx") Then
                    sankey.ExportToXlsx(filename)
                End If

                Cursor.Current = currentCursor
            End If
        End Sub

        Protected Overrides Sub ExportToImage()
            If SankeyDiagramControl Is Nothing Then Return
            Dim fileName As String = MainFormHelper.GetFileName("", GetImageFormatsFilter())
            If Not String.IsNullOrEmpty(fileName) Then SankeyDiagramControl.ExportToImage(fileName, imageFormats(Path.GetExtension(fileName).TrimStart("."c).ToLower()))
        End Sub

        Protected Overrides Sub ExportToPDF()
            ExportTo("pdf", "PDF document (*.pdf)|*.pdf")
        End Sub

        Protected Overrides Sub ExportToHTML()
            ExportTo("html", "HTML document (*.html)|*.html")
        End Sub

        Protected Overrides Sub ExportToMHT()
            ExportTo("mht", "MHT document (*.mht)|*.mht")
        End Sub

        Protected Overrides Sub ExportToXLS()
            ExportTo("xls", "XLS document (*.xls)|*.xls")
        End Sub

        Protected Overrides Sub ExportToXLSX()
            ExportTo("xlsx", "XLSX document (*.xlsx)|*.xlsx")
        End Sub

        Protected Overrides Sub ExportToRTF()
            ExportTo("rtf", "RTF document (*.rtf)|*.rtf")
        End Sub

        Protected Overrides Sub ExportToText()
            ExportTo("txt", "Text document (*.txt)|*.txt")
        End Sub

        Protected Overrides Sub PrintPreview()
            If SankeyDiagramControl IsNot Nothing Then SankeyDiagramControl.ShowPrintPreview()
        End Sub

        Protected Overrides Sub Print()
            If SankeyDiagramControl IsNot Nothing Then SankeyDiagramControl.Print()
        End Sub
    End Class
End Namespace
