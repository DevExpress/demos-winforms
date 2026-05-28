Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraGauges.Core.Printing
Imports DevExpress.XtraGauges.Win

Namespace DevExpress.XtraGauges.Demos

    Public Class TutorialControl
        Inherits TutorialControlBase

        Public Overridable ReadOnly Property ShowExportMenu As Boolean
            Get
                Return False
            End Get
        End Property

        Public Overridable ReadOnly Property ExportControl As GaugeControl
            Get
                Return Nothing
            End Get
        End Property

        Protected Overrides ReadOnly Property ModulesFolder As String
            Get
                Return "GaugesMainDemo\ModulesAnyControl"
            End Get
        End Property

        Protected Overrides ReadOnly Property CodeInfoFolder As String
            Get
                Return "DevExpress.XtraGauges.Demos.CodeInfo"
            End Get
        End Property

#Region "Print and Export"
        Protected Overrides Sub AllowExport()
            EnabledPrintExportActions(True, ExportFormats.PDF Or ExportFormats.HTML Or ExportFormats.MHT Or ExportFormats.Image Or ExportFormats.XLS, True)
        End Sub

        Public Overrides ReadOnly Property AllowPrintOptions As Boolean
            Get
                Return ExportControl IsNot Nothing
            End Get
        End Property

        Protected Overrides Sub ExportToImage()
            If ExportControl Is Nothing Then Return
            Dim fileName As String = MainFormHelper.GetFileName("", "BMP Image (*.bmp)|*.bmp|GIF Image (*.gif)|*.gif|PNG Image (*.png)|*.png|JPEG Image (*.jpeg)|*.jpeg")
            If Not String.IsNullOrEmpty(fileName) Then
                Dim extension As String = Path.GetExtension(fileName)
                Select Case extension.ToLowerInvariant()
                    Case ".bmp"
                        ExportControl.ExportToImage(fileName, Drawing.DXImageFormat.Bmp)
                    Case ".gif"
                        ExportControl.ExportToImage(fileName, Drawing.DXImageFormat.Gif)
                    Case ".png"
                        ExportControl.ExportToImage(fileName, Drawing.DXImageFormat.Png)
                    Case ".jpeg"
                        ExportControl.ExportToImage(fileName, Drawing.DXImageFormat.Jpeg)
                    Case Else
                        ExportControl.ExportToImage(fileName, Drawing.DXImageFormat.Png)
                End Select
            End If
        End Sub

        Protected Overrides Sub ExportToCore(ByVal filename As String, ByVal ext As String)
            If ExportControl Is Nothing Then Return
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            If Equals(ext, "pdf") Then ExportControl.ExportToPdf(filename)
            If Equals(ext, "mht") Then ExportControl.ExportToMht(filename)
            If Equals(ext, "html") Then ExportControl.ExportToHtml(filename)
            If Equals(ext, "xls") Then ExportControl.ExportToXls(filename)
            Cursor.Current = currentCursor
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

        Protected Overrides Sub PrintPreview()
            If ExportControl IsNot Nothing Then
                If RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm Then
                    ExportControl.ShowRibbonPrintPreview(PrintSizeMode.None)
                Else
                    ExportControl.ShowPrintPreview(PrintSizeMode.None)
                End If
            End If
        End Sub
#End Region
    End Class

    Public Class GaugesRibbonMenuManager
        Inherits RibbonMenuManager

        Public Sub New(ByVal parentForm As RibbonMainForm)
            MyBase.New(parentForm)
        End Sub
    End Class
End Namespace
