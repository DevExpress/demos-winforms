Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.Drawing
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout
Imports DevExpress.XtraPrinting.Native

Namespace DevExpress.XtraTreeMap.Demos

    Public Partial Class TreeMapTutorialControl
        Inherits TutorialControlBase
        Implements IDXMenuManager

        Private ReadOnly imageFormats As Dictionary(Of String, DXImageFormat) = New Dictionary(Of String, DXImageFormat)() From {{"bmp", DXImageFormat.Bmp}, {"jpeg", DXImageFormat.Jpeg}, {"gif", DXImageFormat.Gif}, {"tiff", DXImageFormat.Tiff}, {"png", DXImageFormat.Png}}

        Public Sub New()
            AutoMergeRibbon = True
            SuspendLayout()
            Name = "TreeTreeMapTutorialControl"
            Size = New Size(500, 500)
            ResumeLayout(False)
        End Sub

        Public Overrides Property AutoMergeRibbon As Boolean
            Get
                Return True
            End Get

            Set(ByVal value As Boolean)
            End Set
        End Property

        Public Property MenuManager As IDXMenuManager

        Public Overridable ReadOnly Property ActiveDemoModule As Control
            Get
                Return Nothing
            End Get
        End Property

        Private ReadOnly Property ComponentExportable As IComponentExportable
            Get
                Return TryCast(ActiveDemoModule, IComponentExportable)
            End Get
        End Property

        Private ReadOnly Property ComponentPrintable As IComponentPrintable
            Get
                Return TryCast(ActiveDemoModule, IComponentPrintable)
            End Get
        End Property

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

        Protected Sub InitializeControls(ByVal sunburstControl As SunburstControl, ByVal colorizerComboBoxEdit As ComboBoxEdit, ByVal varyColorInGroupLCI As LayoutControlItem, ByVal modeLCI As LayoutControlItem)
            Call DemoHelpersContainer.AddControl(sunburstControl, colorizerComboBoxEdit, varyColorInGroupLCI, modeLCI)
        End Sub

        Protected Sub InitializeControls(ByVal sunburstControl As SunburstControl)
            Call DemoHelpersContainer.AddControl(sunburstControl)
        End Sub

        Protected Overrides Sub AllowExport()
            EnabledPrintExportActions(True, True, ExportFormats.PDF Or ExportFormats.MHT Or ExportFormats.RTF Or ExportFormats.XLS Or ExportFormats.XLSX Or ExportFormats.Image, False)
        End Sub

        Protected Overrides Sub ExportToCore(ByVal filename As String, ByVal ext As String)
            If ComponentExportable IsNot Nothing Then
                Dim currentCursor As Cursor = Cursor.Current
                Cursor.Current = Cursors.WaitCursor
                If Equals(ext, "rtf") Then
                    ComponentExportable.ExportToRtf(filename)
                ElseIf Equals(ext, "pdf") Then
                    ComponentExportable.ExportToPdf(filename)
                ElseIf Equals(ext, "mht") Then
                    ComponentExportable.ExportToMht(filename)
                ElseIf Equals(ext, "xls") Then
                    ComponentExportable.ExportToXls(filename)
                ElseIf Equals(ext, "xlsx") Then
                    ComponentExportable.ExportToXlsx(filename)
                End If

                Cursor.Current = currentCursor
            End If
        End Sub

        Protected Overrides Sub ExportToImage()
            If ComponentExportable Is Nothing Then Return
            Dim fileName As String = MainFormHelper.GetFileName("", GetImageFormatsFilter())
            If Not String.IsNullOrEmpty(fileName) Then
                If ComponentExportable IsNot Nothing Then ComponentExportable.ExportToImage(fileName, imageFormats(Path.GetExtension(fileName).TrimStart("."c).ToLower()))
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

        Protected Overrides Sub ExportToText()
            ExportTo("txt", "Text document (*.txt)|*.txt")
        End Sub

        Protected Overrides Sub PrintPreview()
            If ComponentPrintable IsNot Nothing Then ComponentPrintable.ShowPrintPreview()
        End Sub

        Protected Overrides Sub Print()
            If ComponentPrintable IsNot Nothing Then ComponentPrintable.Print()
        End Sub
    End Class
End Namespace
