Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.Gallery
Imports System.Drawing.Printing
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.Drawing.Printing
Imports DevExpress.Drawing

Namespace DevExpress.ProductsDemo.Win.Controls
    Partial Public Class PrintControl
        Inherits RibbonApplicationUserControl

        Private memoStyle, tableStyle As GalleryItem
        Public Sub New()
            InitializeComponent()
            splitContainer1.Panel1MinSize = layoutControlGroup1.MinSize.Width + 6
            Me.ddbOrientation.DropDownControl = CreateOrientationGallery()
            Me.ddbMargins.DropDownControl = CreateMarginsGallery()
            Me.ddbPaperSize.DropDownControl = CreatePageSizeGallery()
            Me.ddbCollate.DropDownControl = CreateCollateGallery()
            Me.ddbPrinter.DropDownControl = CreatePrintersGallery()
            Me.ddbDuplex.DropDownControl = CreateDuplexGallery()
            Me.ddbPrintStyle.DropDownControl = CreatePrintStyleGallery()
            updatedZoom = True
            zoomTextEdit.EditValue = 70
            updatedZoom = False
        End Sub
        Private Function GetZoomValue() As Integer
            If zoomTrackBarControl1.Value <= 40 Then
                Return 10 + 90 * (zoomTrackBarControl1.Value - 0) \ 40
            Else
                Return 100 + 400 * (zoomTrackBarControl1.Value - 40) \ 40
            End If
        End Function
        Private Function ZoomValueToValue(ByVal zoomValue As Integer) As Integer
            If zoomValue < 100 Then
                Return Math.Min(80, Math.Max(0, (zoomValue - 10) * 40 \ 90))
            End If
            Return Math.Min(80, Math.Max(0, (zoomValue - 100) * 40 \ 400 + 40))
        End Function
        Private updatedZoom As Boolean = False
        Private Sub zoomTrackBarControl1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles zoomTrackBarControl1.EditValueChanged
            If updatedZoom Then
                Return
            End If
            updatedZoom = True
            Try
                zoomTextEdit.EditValue = GetZoomValue()
            Finally
                updatedZoom = False
            End Try
        End Sub
        Public Sub InitPrintingSystem()
            Dim frm As frmMain = TryCast(BackstageView.Ribbon.FindForm(), frmMain)
            Dim manager As BarManager = If(frm Is Nothing OrElse frm.Ribbon Is Nothing, Nothing, frm.Ribbon.Manager)
            DirectCast(Me.ddbOrientation.DropDownControl, GalleryDropDown).Manager = manager
            DirectCast(Me.ddbMargins.DropDownControl, GalleryDropDown).Manager = manager
            DirectCast(Me.ddbPaperSize.DropDownControl, GalleryDropDown).Manager = manager
            DirectCast(Me.ddbCollate.DropDownControl, GalleryDropDown).Manager = manager
            DirectCast(Me.ddbPrinter.DropDownControl, GalleryDropDown).Manager = manager
            DirectCast(Me.ddbDuplex.DropDownControl, GalleryDropDown).Manager = manager
            DirectCast(Me.ddbPrintStyle.DropDownControl, GalleryDropDown).Manager = manager
            lciPrintStyle.Visibility = If(frm.CurrentRichEdit Is Nothing, DevExpress.XtraLayout.Utils.LayoutVisibility.Never, DevExpress.XtraLayout.Utils.LayoutVisibility.Always)
            CreateDocument()
        End Sub
        Private Sub CreateDocument()
            Dim ps As New PrintingSystem()
            If True.Equals(printControl1.Tag) Then
                RemoveHandler ps.StartPrint, AddressOf OnStartPrint
            End If
            printControl1.PrintingSystem = ps
            AddHandler ps.StartPrint, AddressOf OnStartPrint
            printControl1.Tag = True
            CreateLink(ps)
            Me.pageButtonEdit.EditValue = 1
            UpdatePagesInfo()
        End Sub
        Private Sub CreateLink(ByVal ps As PrintingSystem)
            Dim frm As frmMain = TryCast(BackstageView.Ribbon.FindForm(), frmMain)
            Dim showMemo As Boolean = memoStyle.Checked AndAlso frm.CurrentRichEdit IsNot Nothing
            If showMemo Then
                Dim link As New Link(ps)
                link.RtfReportHeader = frm.CurrentRichEdit.RtfText
                link.PaperKind = GetPaperKind()
                link.Landscape = GetLandscape()
                link.Margins = GetMargins()
                link.CreateDocument()
            Else
                Dim link As New PrintableComponentLink(ps)
                link.Component = frm.CurrentPrintableComponent
                link.PaperKind = GetPaperKind()
                link.Landscape = GetLandscape()
                link.Margins = GetMargins()
                link.CreateDocument()
            End If
        End Sub
        Private Sub OnStartPrint(ByVal sender As Object, ByVal e As PrintDocumentEventArgs)
            e.PrintDocument.PrinterSettings.Copies = CShort(Math.Truncate(Me.copySpinEdit.Value))
            GetMargins()
            e.PrintDocument.PrinterSettings.Collate = DirectCast(Me.ddbCollate.Tag, Boolean)
            e.PrintDocument.PrinterSettings.Duplex = If(DirectCast(Me.ddbDuplex.Tag, Boolean), Duplex.Horizontal, Duplex.Simplex)
        End Sub
        Private Sub zoomTextEdit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles zoomTextEdit.EditValueChanged
            Try
                Dim zoomValue As Integer = Int32.Parse(CStr(zoomTextEdit.EditValue.ToString()))
                Me.zoomTrackBarControl1.Value = ZoomValueToValue(zoomValue)
                Me.printControl1.Zoom = 0.01F * CInt(zoomValue)
            Catch e1 As Exception
            End Try
        End Sub
        Private Function CreateListBoxGallery() As GalleryDropDown
            Dim res As New GalleryDropDown()
            res.Gallery.FixedImageSize = False
            res.Gallery.ShowItemText = True
            res.Gallery.ColumnCount = 1
            res.Gallery.CheckDrawMode = CheckDrawMode.OnlyImage
            res.Gallery.ShowGroupCaption = False
            res.Gallery.AutoSize = GallerySizeMode.Vertical
            res.Gallery.SizeMode = GallerySizeMode.None
            res.Gallery.ShowScrollBar = ShowScrollBar.Hide
            res.Gallery.ItemCheckMode = ItemCheckMode.SingleRadio
            res.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
            res.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            res.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            res.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
            res.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            res.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            res.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
            res.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            res.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center

            res.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            res.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            res.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = True
            res.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            res.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = True
            res.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            res.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = True
            res.Gallery.Groups.Add(New GalleryItemGroup())
            res.Gallery.StretchItems = True

            Return res
        End Function
        Private Function CreateOrientationGallery() As GalleryDropDown
            Dim res As GalleryDropDown = CreateListBoxGallery()
            Dim portraitItem As New GalleryItem()
            portraitItem.Image = My.Resources.PageOrientationPortrait
            portraitItem.ImageOptions.SvgImage = My.Resources.PageOrientationPortrait1
            portraitItem.Caption = My.Resources.PortraitOrientation
            Dim landscapeItem As New GalleryItem()
            landscapeItem.Image = My.Resources.PageOrientationLandscape
            landscapeItem.ImageOptions.SvgImage = My.Resources.PageOrientationLandscape1
            landscapeItem.Caption = My.Resources.LandscapeOrientation
            res.Gallery.Groups(0).Items.Add(portraitItem)
            res.Gallery.Groups(0).Items.Add(landscapeItem)
            AddHandler res.Gallery.ItemCheckedChanged, AddressOf OnOrientationGalleryItemCheckedChanged
            portraitItem.Checked = True
            Return res
        End Function
        Private Function CreateMarginsGallery() As GalleryDropDown
            Dim res As GalleryDropDown = CreateListBoxGallery()
            Dim normal As New GalleryItem()
            normal.Image = My.Resources.PageMarginsNormal
            normal.ImageOptions.SvgImage = My.Resources.PageMarginsNormal1
            normal.Caption = My.Resources.MarginsNormal
            normal.Description = My.Resources.MarginsNormalDescription
            normal.Tag = New Padding(25, 25, 25, 25)
            Dim narrow As New GalleryItem()
            narrow.Image = My.Resources.PageMarginsNarrow
            narrow.ImageOptions.SvgImage = My.Resources.PageMarginsNarrow1
            narrow.Caption = My.Resources.MarginsNarrow
            narrow.Description = My.Resources.MarginsNarrowDescription
            narrow.Tag = New Padding(12, 12, 12, 12)
            Dim moderate As New GalleryItem()
            moderate.Image = My.Resources.PageMarginsModerate
            moderate.ImageOptions.SvgImage = My.Resources.PageMarginsModerate1
            moderate.Caption = My.Resources.MarginsModerate
            moderate.Description = My.Resources.MarginsModerateDescription
            moderate.Tag = New Padding(19, 25, 19, 25)
            Dim wide As New GalleryItem()
            wide.Image = My.Resources.PageMarginsWide
            wide.ImageOptions.SvgImage = My.Resources.PageMarginsWide1
            wide.Caption = My.Resources.MarginsWide
            wide.Description = My.Resources.MarginsWideDescription
            wide.Tag = New Padding(50, 25, 50, 25)
            res.Gallery.Groups(0).Items.Add(normal)
            res.Gallery.Groups(0).Items.Add(narrow)
            res.Gallery.Groups(0).Items.Add(moderate)
            res.Gallery.Groups(0).Items.Add(wide)
            AddHandler res.Gallery.ItemCheckedChanged, AddressOf OnMarginsGalleryItemCheckedChanged
            normal.Checked = True
            Return res
        End Function
        Private Function CreatePageSizeGallery() As GalleryDropDown
            Dim res As GalleryDropDown = CreateListBoxGallery()
            Dim letter As New GalleryItem()
            letter.Image = My.Resources.PaperKind_Letter
            letter.ImageOptions.SvgImage = My.Resources.PaperKind_Letter1
            letter.Caption = My.Resources.PaperKindLetter
            letter.Description = My.Resources.PaperKindLetterDescription
            letter.Tag = PaperKind.Letter
            Dim tabloid As New GalleryItem()
            tabloid.Image = My.Resources.PaperKind_Tabloid
            tabloid.ImageOptions.SvgImage = My.Resources.PaperKind_Tabloid1
            tabloid.Caption = My.Resources.PaperKindTabloid
            tabloid.Description = My.Resources.PaperKindTabloidDescription
            tabloid.Tag = PaperKind.Tabloid
            Dim legal As New GalleryItem()
            legal.Image = My.Resources.PaperKind_Legal
            legal.ImageOptions.SvgImage = My.Resources.PaperKind_Legal1
            legal.Caption = My.Resources.PaperKindLegal
            legal.Description = My.Resources.PaperKindLegalDescription
            legal.Tag = PaperKind.Legal
            Dim executive As New GalleryItem()
            executive.Image = My.Resources.PaperKind_Executive
            executive.ImageOptions.SvgImage = My.Resources.PaperKind_Executive1
            executive.Caption = My.Resources.PaperKindExecutive
            executive.Description = My.Resources.PaperKindExecutiveDescription
            executive.Tag = PaperKind.Executive
            Dim a3 As New GalleryItem()
            a3.Image = My.Resources.PaperKind_A3
            a3.ImageOptions.SvgImage = My.Resources.PaperKind_A31
            a3.Caption = My.Resources.PaperKindA3
            a3.Description = My.Resources.PaperKindA3Description
            a3.Tag = PaperKind.A3
            Dim a4 As New GalleryItem()
            a4.Image = My.Resources.PaperKind_A4
            a4.ImageOptions.SvgImage = My.Resources.PaperKind_A41
            a4.Caption = My.Resources.PaperKindA4
            a4.Description = My.Resources.PaperKindA4Description
            a4.Tag = PaperKind.A4
            Dim a5 As New GalleryItem()
            a5.Image = My.Resources.PaperKind_A5
            a5.ImageOptions.SvgImage = My.Resources.PaperKind_A51
            a5.Caption = My.Resources.PaperKindA5
            a5.Description = My.Resources.PaperKindA5Description
            a5.Tag = PaperKind.A5
            Dim a6 As New GalleryItem()
            a6.Image = My.Resources.PaperKind_A6
            a6.ImageOptions.SvgImage = My.Resources.PaperKind_A61
            a6.Caption = My.Resources.PaperKindA6
            a6.Description = My.Resources.PaperKindA6Description
            a6.Tag = PaperKind.A6
            res.Gallery.Groups(0).Items.Add(letter)
            res.Gallery.Groups(0).Items.Add(tabloid)
            res.Gallery.Groups(0).Items.Add(legal)
            res.Gallery.Groups(0).Items.Add(executive)
            res.Gallery.Groups(0).Items.Add(a3)
            res.Gallery.Groups(0).Items.Add(a4)
            res.Gallery.Groups(0).Items.Add(a5)
            res.Gallery.Groups(0).Items.Add(a6)
            AddHandler res.Gallery.ItemCheckedChanged, AddressOf OnPaperSizeGalleryItemCheckedChanged
            a4.Checked = True
            Return res
        End Function
        Private Function CreateCollateGallery() As GalleryDropDown
            Dim res As GalleryDropDown = CreateListBoxGallery()
            Dim collated As New GalleryItem()
            collated.Image = My.Resources.MultiplePagesLarge
            collated.ImageOptions.SvgImage = My.Resources.MultiplePagesLarge1
            collated.Caption = My.Resources.Collated
            collated.Description = My.Resources.CollatedDescription
            collated.Tag = True
            Dim uncollated As New GalleryItem()
            uncollated.Image = My.Resources.MultiplePagesLarge
            uncollated.ImageOptions.SvgImage = My.Resources.MultiplePagesLarge1
            uncollated.Caption = My.Resources.Uncollated
            uncollated.Description = My.Resources.UncollatedDescription
            uncollated.Tag = False
            res.Gallery.Groups(0).Items.Add(collated)
            res.Gallery.Groups(0).Items.Add(uncollated)
            AddHandler res.Gallery.ItemCheckedChanged, AddressOf OnCollateGalleryItemCheckedChanged
            collated.Checked = True
            Return res
        End Function
        Private Function CreateDuplexGallery() As GalleryDropDown
            Dim res As GalleryDropDown = CreateListBoxGallery()
            Dim oneSided As New GalleryItem()
            oneSided.Image = My.Resources.MultiplePagesLarge
            oneSided.ImageOptions.SvgImage = My.Resources.MultiplePagesLarge1
            oneSided.Caption = My.Resources.OneSide
            oneSided.Description = My.Resources.OneSideDescription
            oneSided.Tag = False
            Dim twoSided As New GalleryItem()
            twoSided.Image = My.Resources.MultiplePagesLarge
            twoSided.ImageOptions.SvgImage = My.Resources.MultiplePagesLarge1
            twoSided.Caption = My.Resources.TwoSide
            twoSided.Description = My.Resources.TwoSideDescription
            twoSided.Tag = False
            res.Gallery.Groups(0).Items.Add(oneSided)
            res.Gallery.Groups(0).Items.Add(twoSided)
            AddHandler res.Gallery.ItemCheckedChanged, AddressOf OnDuplexGalleryItemCheckedChanged
            oneSided.Checked = True
            Return res
        End Function
        Private Function CreatePrintStyleGallery() As GalleryDropDown
            Dim res As GalleryDropDown = CreateListBoxGallery()
            res.Gallery.ItemCheckMode = ItemCheckMode.SingleRadio
            memoStyle = New GalleryItem()
            memoStyle.Image = My.Resources.MemoStyle
            memoStyle.ImageOptions.SvgImage = My.Resources.MemoStyle1
            memoStyle.Caption = My.Resources.MemoStyleString
            tableStyle = New GalleryItem()
            tableStyle.Image = My.Resources.TableStyle
            tableStyle.ImageOptions.SvgImage = My.Resources.TableStyle1
            tableStyle.Caption = My.Resources.TableStyleString
            res.Gallery.Groups(0).Items.Add(memoStyle)
            res.Gallery.Groups(0).Items.Add(tableStyle)
            AddHandler res.Gallery.ItemCheckedChanged, AddressOf OnPrintStyleGalleryItemCheckedChanged
            memoStyle.Checked = True
            Return res
        End Function
        Private Sub OnPrintStyleGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            Me.ddbPrintStyle.Text = e.Item.Caption
            Me.ddbPrintStyle.Image = e.Item.Image
            Me.ddbPrintStyle.ImageOptions.SvgImage = e.Item.ImageOptions.SvgImage
            If printControl1.PrintingSystem IsNot Nothing Then
                CreateDocument()
            End If
        End Sub
        Private Sub OnDuplexGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            Me.ddbDuplex.Text = e.Item.Caption
            Me.ddbDuplex.Image = e.Item.Image
            Me.ddbDuplex.ImageOptions.SvgImage = e.Item.ImageOptions.SvgImage
            Me.ddbDuplex.Tag = e.Item.Tag
        End Sub
        Private Function CreatePrintersGallery() As GalleryDropDown
            Dim res As GalleryDropDown = CreateListBoxGallery()
            Dim ps As New PrinterSettings()
            Dim defaultPrinter As GalleryItem = Nothing
            Try
                For Each str As String In PrinterSettings.InstalledPrinters
                    Dim item As New GalleryItem()
                    item.Image = My.Resources.PrintDirectLarge
                    item.ImageOptions.SvgImage = My.Resources.Print1
                    item.Caption = str
                    res.Gallery.Groups(0).Items.Add(item)
                    ps.PrinterName = str
                    If ps.IsDefaultPrinter Then
                        defaultPrinter = item
                    End If
                Next str
            Catch
            End Try
            AddHandler res.Gallery.ItemCheckedChanged, AddressOf OnPrinterGalleryItemCheckedChanged
            If defaultPrinter IsNot Nothing Then
                defaultPrinter.Checked = True
            End If
            Return res
        End Function
        Private Sub OnMarginsGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            Me.ddbMargins.Image = e.Item.Image
            Me.ddbMargins.ImageOptions.SvgImage = e.Item.ImageOptions.SvgImage
            Me.ddbMargins.Text = e.Item.Caption
            Me.ddbMargins.Tag = e.Item.Tag
            If Me.printControl1.PrintingSystem IsNot Nothing Then
                Dim margins As DXMargins = GetMargins()
                Me.printControl1.PrintingSystem.PageSettings.LeftMargin = CInt(Math.Truncate(margins.Left))
                Me.printControl1.PrintingSystem.PageSettings.RightMargin = CInt(Math.Truncate(margins.Right))
                Me.printControl1.PrintingSystem.PageSettings.TopMargin = CInt(Math.Truncate(margins.Top))
                Me.printControl1.PrintingSystem.PageSettings.BottomMargin = CInt(Math.Truncate(margins.Bottom))
            End If
            UpdatePageButtonsEnabledState()
        End Sub
        Private Function GetMargins() As DXMargins
            Dim p As Padding = DirectCast(Me.ddbMargins.Tag, Padding)
            Return New DXMargins(CSng(p.Left * 3.9), CSng(p.Right * 3.9), CSng(p.Top * 3.9), CSng(p.Bottom * 3.9))
        End Function
        Private Sub OnPrinterGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            Me.ddbPrinter.Text = e.Item.Caption
            Me.ddbPrinter.Image = e.Item.Image
            Me.ddbPrinter.ImageOptions.SvgImage = e.Item.ImageOptions.SvgImage
        End Sub
        Private Sub OnCollateGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            Me.ddbCollate.Image = e.Item.Image
            Me.ddbCollate.ImageOptions.SvgImage = e.Item.ImageOptions.SvgImage
            Me.ddbCollate.Text = e.Item.Caption
            Me.ddbCollate.Tag = e.Item.Tag
        End Sub
        Private Sub OnPaperSizeGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            Me.ddbPaperSize.Image = e.Item.Image
            Me.ddbPaperSize.ImageOptions.SvgImage = e.Item.ImageOptions.SvgImage
            Me.ddbPaperSize.Text = e.Item.Caption
            Me.ddbPaperSize.Tag = e.Item.Tag
            If Me.printControl1.PrintingSystem IsNot Nothing Then
                Me.printControl1.PrintingSystem.PageSettings.PaperKind = GetPaperKind()
            End If
            UpdatePageButtonsEnabledState()
        End Sub
        Private Function GetPaperKind() As DXPaperKind
            Return DirectCast(Me.ddbPaperSize.Tag, DXPaperKind)
        End Function
        Private Sub OnOrientationGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            ddbOrientation.Text = e.Item.Caption
            ddbOrientation.Image = e.Item.Image
            ddbOrientation.ImageOptions.SvgImage = e.Item.ImageOptions.SvgImage
            If printControl1.PrintingSystem IsNot Nothing Then
                Me.printControl1.PrintingSystem.PageSettings.Landscape = GetLandscape()
            End If
            UpdatePageButtonsEnabledState()
        End Sub
        Private Function GetLandscape() As Boolean
            If ddbOrientation.DropDownControl IsNot Nothing Then
                Return DirectCast(ddbOrientation.DropDownControl, GalleryDropDown).Gallery.Groups(0).Items(1).Checked
            End If
            Return False
        End Function
        Private Sub printButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles printButton.Click
            CType(Me.printControl1.PrintingSystem, PrintingSystem).Print(Me.ddbPrinter.Text)
        End Sub

        Private Sub pageButtonEdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles pageButtonEdit.ButtonClick
            Dim pageIndex As Integer = DirectCast(Me.pageButtonEdit.EditValue, Integer)
            If e.Button.Kind = ButtonPredefines.Left Then
                If pageIndex > 1 Then
                    pageIndex -= 1
                End If
            ElseIf e.Button.Kind = ButtonPredefines.Right Then
                If pageIndex < Me.printControl1.PrintingSystem.Pages.Count Then
                    pageIndex += 1
                End If
            End If
            Me.pageButtonEdit.EditValue = pageIndex
        End Sub

        Private Sub pageButtonEdit_EditValueChanging(ByVal sender As Object, ByVal e As ChangingEventArgs) Handles pageButtonEdit.EditValueChanging
            Try
                Dim pageIndex As Integer = Int32.Parse(e.NewValue.ToString())
                If pageIndex < 1 Then
                    pageIndex = 1
                ElseIf pageIndex > Me.printControl1.PrintingSystem.Pages.Count Then
                    pageIndex = Me.printControl1.PrintingSystem.Pages.Count
                End If
                e.NewValue = pageIndex
            Catch e1 As Exception
                e.NewValue = 1
            End Try
        End Sub
        Private Sub UpdatePagesInfo()
            If printControl1.PrintingSystem IsNot Nothing Then
                Me.pageButtonEdit.Properties.DisplayFormat.FormatString = String.Format("{0}{1}", My.Resources.PageInfo, printControl1.PrintingSystem.Pages.Count)
                Me.printButton.Enabled = printControl1.PrintingSystem.Pages.Count > 0
                Me.pageButtonEdit.Enabled = printControl1.PrintingSystem.Pages.Count > 0
            End If
        End Sub
        Private Sub UpdatePageButtonsEnabledState(ByVal pageIndex As Integer)
            If printControl1.PrintingSystem Is Nothing Then
                Return
            End If
            Me.pageButtonEdit.Properties.Buttons(0).Enabled = pageIndex <> 1
            Me.pageButtonEdit.Properties.Buttons(1).Enabled = pageIndex <> printControl1.PrintingSystem.Pages.Count
            UpdatePagesInfo()
        End Sub
        Private Sub UpdatePageButtonsEnabledState()
            UpdatePageButtonsEnabledState(Me.printControl1.SelectedPageIndex + 1)
        End Sub
        Private Sub pageButtonEdit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles pageButtonEdit.EditValueChanged
            Dim pageIndex As Integer = Convert.ToInt32(Me.pageButtonEdit.EditValue)
            Me.printControl1.SelectedPageIndex = pageIndex - 1
            UpdatePageButtonsEnabledState(pageIndex)
        End Sub

        Private Sub printControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As EventArgs) Handles printControl1.SelectedPageChanged
            Me.pageButtonEdit.EditValue = Me.printControl1.SelectedPageIndex + 1
        End Sub
    End Class
End Namespace
