Imports DevExpress.XtraPrinting
Imports System.Drawing.Imaging
Imports DevExpress.XtraEditors
Imports DevExpress.Drawing

Namespace DevExpress.MailClient.Win.Controls
    Partial Public Class ExportControl
        Inherits RibbonApplicationUserControl

        Public Sub New()
            InitializeComponent()
        End Sub
        Private formats As New List(Of DXImageFormat)() From {DXImageFormat.Bmp, DXImageFormat.Gif, DXImageFormat.Jpeg, DXImageFormat.Png, DXImageFormat.Tiff, DXImageFormat.Emf, DXImageFormat.Wmf, DXImageFormat.Png}
        Private Sub galleryControlGallery1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs) Handles exportGallery.Gallery.ItemClick
            Dim index As String = String.Format("{0}", e.Item.Tag)
            Dim frm As frmMain = TryCast(BackstageView.Ribbon.FindForm(), frmMain)
            If frm Is Nothing Then
                Return
            End If
            If index.Contains("PDF") Then
                saveFileDialog1.Filter = My.Resources.PDFFilter
            ElseIf index.Contains("HTML") Then
                saveFileDialog1.Filter = My.Resources.HTMLFilter
            ElseIf index.Contains("MHT") Then
                saveFileDialog1.Filter = My.Resources.MHTFilter
            ElseIf index.Contains("RTF") Then
                saveFileDialog1.Filter = My.Resources.RTFFilter
            ElseIf index.Contains("XLS") Then
                saveFileDialog1.Filter = My.Resources.XLSFilter
            ElseIf index.Contains("XLSX") Then
                saveFileDialog1.Filter = My.Resources.XLSXFilter
            ElseIf index.Contains("CSV") Then
                saveFileDialog1.Filter = My.Resources.CSVFilter
            ElseIf index.Contains("Text") Then
                saveFileDialog1.Filter = My.Resources.TextFilter
            ElseIf index.Contains("Image") Then
                saveFileDialog1.Filter = My.Resources.ImageFilter
            End If
            saveFileDialog1.Filter &= "|" & My.Resources.AllFilesFilter
            saveFileDialog1.FilterIndex = 0
            saveFileDialog1.FileName = frm.CurrentModuleName
            If saveFileDialog1.ShowDialog() <> DialogResult.OK Then
                Return
            End If
            Cursor.Current = Cursors.WaitCursor
            Dim ps As New PrintingSystem()
            Dim link As New PrintableComponentLink(ps)
            link.Component = frm.CurrentExportComponent
            link.CreateDocument()
            ExportTo(index, saveFileDialog1.FileName, ps)
        End Sub
        Private Shared Sub ShowExportErrorMessage()
            XtraMessageBox.Show(My.Resources.ExportErrorText, My.Resources.Export, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub
        Private Sub ExportTo(ByVal index As String, ByVal fileName As String, ByVal ps As PrintingSystem)
            If Not String.IsNullOrEmpty(fileName) Then
                Try
                    Cursor.Current = Cursors.WaitCursor
                    If index.Contains("PDF") Then
                        ps.ExportToPdf(fileName)
                    ElseIf index.Contains("HTML") Then
                        ps.ExportToHtml(fileName)
                    ElseIf index.Contains("MHT") Then
                        ps.ExportToMht(fileName)
                    ElseIf index.Contains("RTF") Then
                        ps.ExportToRtf(fileName)
                    ElseIf index.Contains("XLS") Then
                        ps.ExportToXls(fileName)
                    ElseIf index.Contains("XLSX") Then
                        ps.ExportToXlsx(fileName)
                    ElseIf index.Contains("CSV") Then
                        ps.ExportToCsv(fileName)
                    ElseIf index.Contains("Text") Then
                        ps.ExportToText(fileName)
                    ElseIf index.Contains("Image") Then
                        ps.ExportToImage(fileName, formats(saveFileDialog1.FilterIndex))
                    End If
                    Cursor.Current = Cursors.Default
                    If XtraMessageBox.Show(My.Resources.OpentFileQuestion, My.Resources.Export, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Data.Utils.SafeProcess.Start(saveFileDialog1.FileName)
                    End If
                Catch
                    ShowExportErrorMessage()
                Finally
                    Cursor.Current = Cursors.Default
                End Try
            End If
        End Sub

    End Class
End Namespace
