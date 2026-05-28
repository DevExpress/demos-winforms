Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.Drawing
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraCharts.Printing
Imports DevExpress.XtraPrinting

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class ChartDemoModule
        Inherits TutorialControlBase

        Private ReadOnly imageFormats As Dictionary(Of String, DXImageFormat) = New Dictionary(Of String, DXImageFormat)() From {{"bmp", DXImageFormat.Bmp}, {"jpeg", DXImageFormat.Jpeg}, {"gif", DXImageFormat.Gif}, {"tiff", DXImageFormat.Tiff}, {"png", DXImageFormat.Png}}

        Private paletteNameField As String = "Default"

        Friend Overridable ReadOnly Property ChartControls As List(Of ChartControl)
            Get
                Return Nothing
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property PaletteName As String
            Get
                Return paletteNameField
            End Get

            Set(ByVal value As String)
                Dim chartControlsCache As List(Of ChartControl) = ChartControls
                If chartControlsCache Is Nothing AndAlso ChartControl IsNot Nothing Then chartControlsCache = New List(Of ChartControl)() From {ChartControl}
                If chartControlsCache IsNot Nothing Then
                    For Each chart As ChartControl In chartControlsCache
                        Try
                            chart.PaletteName = value
                            paletteNameField = value
                        Catch exception As ArgumentException
                            Call Debug.WriteLine(String.Format("Warning: impossible to set the '{0}' palette." & Microsoft.VisualBasic.Constants.vbLf & "{1}", value, exception.Message))
                        End Try
                    Next
                End If

                OnPaletteChanged()
            End Set
        End Property

        Friend ReadOnly Property ChartRibbonMenuManager As ChartRibbonMenuManager
            Get
                Return TryCast(RibbonMenuManager, ChartRibbonMenuManager)
            End Get
        End Property

        Friend Overridable ReadOnly Property ChartControl As ChartControl
            Get
                Return Nothing
            End Get
        End Property

        Friend Overridable ReadOnly Property ExportedObject As Object
            Get
                Return ChartControl
            End Get
        End Property

        Friend Overridable ReadOnly Property ChartDesignerEnabled As Boolean
            Get
                Return True
            End Get
        End Property

        Friend Overridable ReadOnly Property PaletteButtonEnabled As Boolean
            Get
                Return True
            End Get
        End Property

        Public Overrides ReadOnly Property AllowPrintOptions As Boolean
            Get
                Return ChartControl IsNot Nothing
            End Get
        End Property

        Friend Sub New()
            InitializeComponent()
        End Sub

        Protected Overridable Sub OnPaletteChanged()
        End Sub

        Protected Friend Overridable Sub BeforeChartDesignerShown()
        End Sub

        Protected Friend Overridable Sub OnChartDesignerClosed()
        End Sub

        Protected Overrides Sub OnFirstLoad()
            MyBase.OnFirstLoad()
            AllowExport()
        End Sub

        Protected Overrides Sub OnLookAndFeelChanged()
            MyBase.OnLookAndFeelChanged()
            OnPaletteChanged()
        End Sub

        Protected Overrides Sub AllowExport()
            EnabledPrintExportActions(True, ExportFormats.Image Or ExportFormats.SVG Or ExportFormats.PDF Or ExportFormats.HTML Or ExportFormats.MHT Or ExportFormats.XLS Or ExportFormats.RTF Or ExportFormats.XLSX Or ExportFormats.DOCX, False)
        End Sub

        Protected Overrides Sub ExportToCore(ByVal filename As String, ByVal ext As String)
            Dim chart As ChartControl = ChartControl
            If chart IsNot Nothing Then
                Dim currentCursor As Cursor = Cursor.Current
                Cursor.Current = Cursors.WaitCursor
                chart.OptionsPrint.SizeMode = PrintSizeMode.Zoom
                If Equals(ext, "rtf") Then
                    chart.ExportToRtf(filename)
                ElseIf Equals(ext, "pdf") Then
                    chart.OptionsPrint.ImageFormat = PrintImageFormat.Metafile
                    Dim options As PdfExportOptions = New PdfExportOptions()
                    options.ConvertImagesToJpeg = False
                    chart.ExportToPdf(filename, options)
                ElseIf Equals(ext, "mht") Then
                    chart.ExportToMht(filename)
                ElseIf Equals(ext, "html") Then
                    chart.ExportToHtml(filename)
                ElseIf Equals(ext, "xls") Then
                    chart.ExportToXls(filename)
                ElseIf Equals(ext, "xlsx") Then
                    chart.ExportToXlsx(filename)
                ElseIf Equals(ext, "svg") Then
                    chart.ExportToSvg(filename)
                ElseIf Equals(ext, "docx") Then
                    chart.ExportToDocx(filename)
                End If

                Cursor.Current = currentCursor
            End If
        End Sub

        Protected Overrides Sub ExportToImage()
            Dim chart As ChartControl = ChartControl
            If chart IsNot Nothing Then
                chart.OptionsPrint.SizeMode = PrintSizeMode.None
                Dim formats As IEnumerable(Of String) = imageFormats.Keys
                Dim fileFormat As String = String.Empty
                For Each format As String In formats
                    fileFormat += String.Format("{0} Image (*.{1})|*.{1}|", format.ToUpper(), format.ToLower())
                Next

                fileFormat = fileFormat.TrimEnd("|"c)
                Dim filePath As String = MainFormHelper.GetFileName("", fileFormat)
                If Not String.IsNullOrEmpty(filePath) Then
                    Dim extension As String = Path.GetExtension(filePath).TrimStart("."c).ToLower()
                    If Not String.IsNullOrEmpty(extension) Then chart.ExportToImage(filePath, imageFormats(extension))
                End If
            End If
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

        Protected Overrides Sub ExportToSVG()
            ExportTo("svg", "SVG document (*.svg)|*.svg")
        End Sub

        Protected Overrides Sub ExportToText()
            ExportTo("txt", "Text document (*.txt)|*.txt")
        End Sub

        Protected Overrides Sub ExportToDOCX()
            ExportTo("docx", "DOCX document (*.docx)|*.docx")
        End Sub

        Protected Overrides Sub PrintPreview()
            Dim chart As ChartControl = ChartControl
            If chart IsNot Nothing Then
                chart.OptionsPrint.SizeMode = PrintSizeMode.Zoom
                chart.OptionsPrint.ImageFormat = PrintImageFormat.Metafile
                If RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm Then
                    chart.ShowRibbonPrintPreview()
                Else
                    chart.ShowPrintPreview()
                End If
            End If
        End Sub
    End Class
End Namespace
