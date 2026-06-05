Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.Data.Utils
Imports DevExpress.Drawing
Imports DevExpress.Drawing.Printing
Imports DevExpress.LookAndFeel
Imports DevExpress.Printing
Imports DevExpress.Tutorials.Controls
Imports DevExpress.Utils
Imports DevExpress.Utils.Taskbar
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.Gallery
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ColorWheel
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen

Namespace DevExpress.XtraBars.Demos.RibbonSimplePad

    Public Partial Class frmMain
        Inherits RibbonForm

        Public Shared FileNames As String = "RibbonMRUFiles.ini"

        Public Shared FolderNames As String = "RibbonMRUFolders.ini"

        Public Sub New()
            InitializeComponent()
            CreateColorPopup(popupControlContainer1)
            InitSkinGallery()
            InitFontGallery()
            InitColorGallery()
            InitEditors()
            InitSchemeCombo()
            InitPrint()
            UserLookAndFeel.Default.SetSkinStyle("WXI")
            Icon = ResourceImageHelperCore.CreateIconFromResourcesEx("DevExpress.XtraBars.Demos.RibbonSimplePad.AppIcon.ico", GetType(frmMain).Assembly)
            recentLabelItem2.Caption = AssemblyInfo.AssemblyCopyright
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            SplashScreenManager.CloseForm(False)
        End Sub

        Protected Overrides Sub OnShown(ByVal e As EventArgs)
            MyBase.OnShown(e)
            AddHandler Ribbon.MessageClosed, AddressOf OnRibbonMessageClosed
            ShowMessage(WhatsNewMessage, 0)
            ShowMessage(DocumentationMessage, 5000)
        End Sub

        Private Sub OnRibbonMessageClosed(ByVal sender As Object, ByVal e As RibbonMessageClosedArgs)
            If e.Message Is WhatsNewMessage AndAlso e.Result = DialogResult.OK Then SafeProcess.TryOpenHyperlink("https://www.devexpress.com/new#winforms")
            If e.Message Is DocumentationMessage AndAlso e.Result = DialogResult.Yes Then SafeProcess.TryOpenHyperlink("https://docs.devexpress.com/WindowsForms/DevExpress.XtraBars.Ribbon.RibbonControl.ShowMessage(DevExpress.XtraBars.Ribbon.RibbonMessageArgs)")
        End Sub

        Private Sub ShowMessage(ByVal message As RibbonMessageArgs, ByVal delay As Integer)
            If delay = 0 Then
                Ribbon.ShowMessage(message)
                Return
            End If

            Dim timer = New Timer()
            timer.Interval = delay
            AddHandler timer.Tick, Sub()
                Ribbon.ShowMessage(message)
                timer.Stop()
                timer.Dispose()
            End Sub
            timer.Start()
        End Sub

        Private wnMessage As RibbonMessageArgs

        Private ReadOnly Property WhatsNewMessage As RibbonMessageArgs
            Get
                If wnMessage Is Nothing Then
                    wnMessage = New RibbonMessageArgs()
                    wnMessage.Caption = "What's New"
                    wnMessage.Text = "Explore new WinForms-related features that we introduced in our recent major update."
                    wnMessage.ImageOptions.SvgImage = siModified.ImageOptions.SvgImage
                    wnMessage.Buttons = New DialogResult() {DialogResult.OK}
                    AddHandler wnMessage.Showing, Sub(ByVal sender, ByVal e)
                        Dim button As BarButtonItem = e?.Buttons(DialogResult.OK)
                        If button Is Nothing Then Return
                        button.Caption = "Explore Roadmap"
                    End Sub
                End If

                Return wnMessage
            End Get
        End Property

        Private docMessage As RibbonMessageArgs

        Private ReadOnly Property DocumentationMessage As RibbonMessageArgs
            Get
                If docMessage Is Nothing Then
                    docMessage = New RibbonMessageArgs()
                    docMessage.Text = "Want to know how to display alerts within the Ribbon Message Bar?"
                    docMessage.Icon = MessageBoxIcon.Question
                    docMessage.ImageOptions.SvgImage = recentPinItem2.ImageOptions.ItemNormal.SvgImage
                    docMessage.Buttons = New DialogResult() {DialogResult.Yes, DialogResult.No}
                    AddHandler docMessage.Showing, Sub(ByVal sender, ByVal e) Ribbon.Messages(docMessage).ShowCloseItem = False
                End If

                Return docMessage
            End Get
        End Property

        Private Sub InitSchemeCombo()
            For Each value As RibbonControlColorScheme In [Enum].GetValues(GetType(RibbonControlColorScheme))
                If value = RibbonControlColorScheme.Yellow Then Continue For
                Dim bmp As Bitmap = New Bitmap(ScaleUtils.ScaleValue(32), ScaleUtils.ScaleValue(32))
                Using g As Graphics = Graphics.FromImage(bmp)
                    Dim rect As Rectangle = New Rectangle(Point.Empty, bmp.Size)
                    rect.Inflate(-1, -1)
                    Using b As SolidBrush = New SolidBrush(rgbiColorScheme.Gallery.Groups(0).Items(CInt(value)).AppearanceCaption.Normal.ForeColor)
                        g.FillRectangle(b, rect)
                    End Using
                End Using

                rgbiColorScheme.Gallery.Groups(0).Items(CInt(value)).Value = value
                rgbiColorScheme.Gallery.Groups(0).Items(CInt(value)).ImageOptions.Image = bmp
            Next

            rgbiColorScheme.Gallery.SetItemCheck(rgbiColorScheme.Gallery.Groups(0).Items(CInt(RibbonControlColorScheme.Default)), True)
            AddHandler ribbonControl1.GetController().Changed, AddressOf OnRibbonControllerChanged
        End Sub

        Private Sub OnRibbonControllerChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not Equals(ribbonControl1.GetController().LookAndFeel.ActiveSkinName, "Office 2016 Colorful") Then
                rgbiColorScheme.Visibility = BarItemVisibility.Never
            Else
                rgbiColorScheme.Visibility = BarItemVisibility.Always
            End If
        End Sub

        Private documentIndex As Integer = 0

        Private pc As PopupColor

        Private dlgFind As frmFind = Nothing

        Private dlgReplace As frmReplace = Nothing

        Private fCurrentFontItem, fCurrentColorItem As GalleryItem

        Private ReadOnly Property DocumentName As String
            Get
                Return String.Format("New Document {0}", documentIndex)
            End Get
        End Property

        Private Sub CreateNewDocument()
            CreateNewDocument(Nothing)
        End Sub

        Private Sub InitEditors()
            riicStyle.Items.Add(New ImageComboBoxItem("Default", RibbonControlStyle.Default, -1))
            riicStyle.Items.Add(New ImageComboBoxItem("Office 2007", RibbonControlStyle.Office2007, -1))
            riicStyle.Items.Add(New ImageComboBoxItem("Office 2010", RibbonControlStyle.Office2010, -1))
            riicStyle.Items.Add(New ImageComboBoxItem("Office 2013", RibbonControlStyle.Office2013, -1))
            riicStyle.Items.Add(New ImageComboBoxItem("Office 2019", RibbonControlStyle.Office2019, -1))
            riicStyle.Items.Add(New ImageComboBoxItem("Office 365", RibbonControlStyle.Office365, -1))
            riicStyle.Items.Add(New ImageComboBoxItem("MacOffice", RibbonControlStyle.MacOffice, -1))
            riicStyle.Items.Add(New ImageComboBoxItem("TabletOffice", RibbonControlStyle.TabletOffice, -1))
            riicStyle.Items.Add(New ImageComboBoxItem("OfficeUniversal", RibbonControlStyle.OfficeUniversal, -1))
            biStyle.EditValue = ribbonControl1.RibbonStyle
        End Sub

        Public Sub ShowHideFormatCategory()
            Dim selectionCategory As RibbonPageCategory = TryCast(Ribbon.PageCategories(0), RibbonPageCategory)
            If selectionCategory Is Nothing Then Return
            If CurrentRichTextBox Is Nothing Then
                selectionCategory.Visible = False
            Else
                selectionCategory.Visible = CurrentRichTextBox.SelectionLength <> 0
            End If

            If selectionCategory.Visible Then Ribbon.SelectedPage = selectionCategory.Pages(0)
        End Sub

        Private Sub CreateNewDocument(ByVal fileName As String)
            documentIndex += 1
            Dim pad As frmPad = New frmPad()
            If Not Equals(fileName, Nothing) Then
                pad.LoadDocument(fileName)
            Else
                pad.DocName = DocumentName
            End If

            pad.MdiParent = Me
            AddHandler pad.Closed, New EventHandler(AddressOf Pad_Closed)
            AddHandler pad.ShowPopupMenu, New EventHandler(AddressOf Pad_ShowPopupMenu)
            AddHandler pad.ShowMiniToolbar, New EventHandler(AddressOf pad_ShowMiniToolbar)
            pad.Show()
            InitNewDocument(pad.RTBMain)
        End Sub

        Private Sub pad_ShowMiniToolbar(ByVal sender As Object, ByVal e As EventArgs)
            If String.IsNullOrEmpty(CType(sender, RichTextBox).SelectedText) Then Return
            ShowSelectionMiniToolbar()
        End Sub

        Private Sub Pad_Closed(ByVal sender As Object, ByVal e As EventArgs)
            CloseFind()
        End Sub

        Private Sub Pad_ShowPopupMenu(ByVal sender As Object, ByVal e As EventArgs)
            pmMain.RibbonToolbar = selectionMiniToolbar
            pmMain.ShowPopup(MousePosition)
        End Sub

        Private Sub CloseFind()
            If dlgFind IsNot Nothing AndAlso dlgFind.RichText IsNot CurrentRichTextBox Then
                dlgFind.Close()
                dlgFind = Nothing
            End If

            If dlgReplace IsNot Nothing AndAlso dlgReplace.RichText IsNot CurrentRichTextBox Then
                dlgReplace.Close()
                dlgReplace = Nothing
            End If
        End Sub

        Private Sub CreateColorPopup(ByVal container As PopupControlContainer)
            pc = New PopupColor(container, Me)
        End Sub

#Region "Init"
        Private Sub frmMain_Activated(ByVal sender As Object, ByVal e As EventArgs)
            InitPaste()
        End Sub

        Public Sub UpdateText()
            ribbonControl1.ApplicationCaption = "Ribbon Simple Pad"
            ribbonControl1.ApplicationDocumentCaption = CurrentDocName & If(CurrentModified, "*", "")
            'Text = string.Format("Ribbon Simple Pad ({0})", CurrentDocName);
            siDocName.Caption = String.Format("  {0}", CurrentDocName)
        End Sub

        Private Sub ChangeActiveForm()
            UpdateText()
            InitCurrentDocument(CurrentRichTextBox)
            rtPad_SelectionChanged(CurrentRichTextBox, EventArgs.Empty)
            CloseFind()
        End Sub

        Private Sub xtraTabbedMdiManager1_FloatMDIChildActivated(ByVal sender As Object, ByVal e As EventArgs)
            ChangeActiveForm()
        End Sub

        Private Sub xtraTabbedMdiManager1_FloatMDIChildDeactivated(ByVal sender As Object, ByVal e As EventArgs)
            BeginInvoke(New MethodInvoker(AddressOf ChangeActiveForm))
        End Sub

        Private Sub frmMain_MdiChildActivate(ByVal sender As Object, ByVal e As EventArgs)
            ChangeActiveForm()
        End Sub

        Private Sub rtPad_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            ShowHideFormatCategory()
            Dim rtPad As RichTextBox = TryCast(sender, RichTextBox)
            InitFormat()
            Dim line As Integer = 0, col As Integer = 0
            If rtPad IsNot Nothing Then
                InitEdit(rtPad.SelectionLength > 0)
                line = rtPad.GetLineFromCharIndex(rtPad.SelectionStart) + 1
                col = rtPad.SelectionStart + 1
            Else
                InitEdit(False)
            End If

            siPosition.Caption = String.Format("   Line: {0}  Position: {1}   ", line, col)
            CurrentFontChanged()
        End Sub

        Protected Overridable Sub ShowSelectionMiniToolbar()
            Dim pt As Point = MousePosition
            pt.Offset(0, -11)
            selectionMiniToolbar.Alignment = ContentAlignment.TopRight
            selectionMiniToolbar.PopupMenu = Nothing
            selectionMiniToolbar.Show(pt)
        End Sub

        Private Sub rtPad_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            If CurrentForm Is Nothing Then Return
            CurrentForm.Modified = True
            InitCurrentDocument(CurrentRichTextBox)
        End Sub

        Protected Sub InitFormat()
            iBold.Enabled = SelectFont IsNot Nothing
            iItalic.Enabled = SelectFont IsNot Nothing
            iUnderline.Enabled = SelectFont IsNot Nothing
            iFont.Enabled = SelectFont IsNot Nothing
            iFontColor.Enabled = SelectFont IsNot Nothing
            If SelectFont IsNot Nothing Then
                iBold.Down = SelectFont.Bold
                iItalic.Down = SelectFont.Italic
                iUnderline.Down = SelectFont.Underline
            End If

            Dim _enabled As Boolean = CurrentRichTextBox IsNot Nothing
            iProtected.Enabled = _enabled
            iBullets.Enabled = _enabled
            iAlignLeft.Enabled = _enabled
            iAlignRight.Enabled = _enabled
            iCenter.Enabled = _enabled
            rgbiFont.Enabled = _enabled
            rgbiFontColor.Enabled = _enabled
            ribbonPageGroup9.ShowCaptionButton = _enabled
            rpgFont.ShowCaptionButton = _enabled
            rpgFontColor.ShowCaptionButton = _enabled
            If Not _enabled Then ClearFormats()
            If CurrentRichTextBox IsNot Nothing Then
                iProtected.Down = CurrentRichTextBox.SelectionProtected
                iBullets.Down = CurrentRichTextBox.SelectionBullet
                Select Case CurrentRichTextBox.SelectionAlignment
                    Case HorizontalAlignment.Left
                        iAlignLeft.Down = True
                    Case HorizontalAlignment.Center
                        iCenter.Down = True
                    Case HorizontalAlignment.Right
                        iAlignRight.Down = True
                End Select
            End If
        End Sub

        Private Sub ClearFormats()
            iBold.Down = False
            iItalic.Down = False
            iUnderline.Down = False
            iProtected.Down = False
            iBullets.Down = False
            iAlignLeft.Down = False
            iAlignRight.Down = False
            iCenter.Down = False
        End Sub

        Protected Sub InitPaste()
            Dim enabledPase As Boolean = CurrentRichTextBox IsNot Nothing AndAlso CurrentRichTextBox.CanPaste(DataFormats.GetFormat(0))
            iPaste.Enabled = enabledPase
            sbiPaste.Enabled = enabledPase
        End Sub

        Private Sub InitUndo()
            iUndo.Enabled = If(CurrentRichTextBox IsNot Nothing, CurrentRichTextBox.CanUndo, False)
            iLargeUndo.Enabled = iUndo.Enabled
        End Sub

        Protected Sub InitEdit(ByVal enabled As Boolean)
            iCut.Enabled = enabled
            iCopy.Enabled = enabled
            iClear.Enabled = enabled
            iSelectAll.Enabled = If(CurrentRichTextBox IsNot Nothing, CurrentRichTextBox.CanSelect, False)
            InitUndo()
        End Sub

        Private Sub InitNewDocument(ByVal rtbControl As RichTextBox)
            AddHandler rtbControl.SelectionChanged, New EventHandler(AddressOf rtPad_SelectionChanged)
            AddHandler rtbControl.TextChanged, New EventHandler(AddressOf rtPad_TextChanged)
        End Sub

        Private Sub InitCurrentDocument(ByVal rtbControl As RichTextBox)
            Dim _enabled As Boolean = rtbControl IsNot Nothing
            iSaveAs.Enabled = _enabled
            iClose.Enabled = _enabled
            iPrint.Enabled = _enabled
            sbiSave.Enabled = _enabled
            sbiFind.Enabled = _enabled
            iFind.Enabled = _enabled
            iReplace.Enabled = _enabled
            iSave.Enabled = CurrentModified
            SetModifiedCaption()
            InitPaste()
            InitFormat()
        End Sub

        Private Sub SetModifiedCaption()
            If CurrentForm Is Nothing Then
                siModified.Caption = ""
                Return
            End If

            siModified.Caption = If(CurrentModified, "   Modified   ", "")
        End Sub

#End Region
#Region "Properties"
        Private ReadOnly Property CurrentForm As frmPad
            Get
                If ActiveMdiChild Is Nothing Then Return Nothing
                If xtraTabbedMdiManager1.ActiveFloatForm IsNot Nothing Then Return TryCast(xtraTabbedMdiManager1.ActiveFloatForm, frmPad)
                Return TryCast(ActiveMdiChild, frmPad)
            End Get
        End Property

        Public ReadOnly Property CurrentRichTextBox As RichTextBox
            Get
                If CurrentForm Is Nothing Then Return Nothing
                Return CurrentForm.RTBMain
            End Get
        End Property

        Private ReadOnly Property CurrentDocName As String
            Get
                If CurrentForm Is Nothing Then Return ""
                Return CurrentForm.DocName
            End Get
        End Property

        Private ReadOnly Property CurrentModified As Boolean
            Get
                If CurrentForm Is Nothing Then Return False
                Return CurrentForm.Modified
            End Get
        End Property

#End Region
#Region "File"
        Private Sub idNew_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CreateNewDocument()
        End Sub

        Private Sub iClose_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If CurrentForm IsNot Nothing Then CurrentForm.Close()
        End Sub

        Private Sub OpenFile()
            OpenFileFolder(String.Empty)
        End Sub

        Public Sub OpenFile(ByVal name As String)
            CreateNewDocument(name)
            AddToMostRecentFiles(name, arMRUList)
            AddToMostRecentFiles(name, Nothing)
            AddToMostRecentFolders(name, Nothing)
        End Sub

        Private Sub AddToMostRecentFiles(ByVal name As String, ByVal arMRUList As MRUArrayList)
            If arMRUList IsNot Nothing Then arMRUList.InsertElement(name)
            Dim pinItem As RecentPinItem = New RecentPinItem() With {.Caption = GetFileName(name), .Description = name, .PinButtonChecked = False}
            If CheckForOverlap(pinItem, recentTabItem1.TabPanel.Items) Then Return
            recentTabItem1.TabPanel.Items.Insert(FindFirstUnCheckedIntemIndex(recentTabItem1.TabPanel), pinItem)
        End Sub

        Private Function CheckForOverlap(ByVal pinItem As RecentPinItem, ByVal recentItemCollection As RecentItemCollection) As Boolean
            For Each item As RecentItemBase In recentItemCollection
                Dim pItem As RecentPinItem = TryCast(item, RecentPinItem)
                If pItem IsNot Nothing AndAlso Equals(pinItem.Caption, pItem.Caption) AndAlso Equals(pinItem.Description, pItem.Description) Then Return True
            Next

            Return False
        End Function

        Private Sub AddToMostRecentFolders(ByVal name As String, ByVal arMRUList As MRUArrayList)
            If arMRUList IsNot Nothing Then
                name = Path.GetFullPath(name)
                arMRUList.InsertElement(Path.GetDirectoryName(name))
            End If

            name = Path.GetDirectoryName(Path.GetFullPath(name))
            Dim pinItem As RecentPinItem = New RecentPinItem() With {.Caption = GetFileName(name), .Description = name, .PinButtonChecked = False}
            If CheckForOverlap(pinItem, recentTabItem2.TabPanel.Items) Then Return
            Dim pinItem_ As RecentPinItem = New RecentPinItem() With {.Caption = GetFileName(name), .Description = name, .PinButtonChecked = False}
            recentTabItem2.TabPanel.Items.Insert(FindFirstUnCheckedIntemIndex(recentTabItem2.TabPanel), pinItem)
            recentTabItem3.TabPanel.Items.Insert(FindFirstUnCheckedIntemIndex(recentTabItem3.TabPanel), pinItem_)
        End Sub

        Private Sub iOpen_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            OpenFile()
        End Sub

        Private Sub iPrint_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            XtraMessageBox.Show(Me, "Note that you can use the XtraPrinting Library to print the contents of the standard RichTextBox control." & Microsoft.VisualBasic.Constants.vbCrLf & "For more information, see the main XtraPrinting demo.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Private Sub iSave_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Save()
        End Sub

        Private Sub iSaveAs_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            SaveAs()
        End Sub

        Private Sub Save()
            If CurrentForm Is Nothing Then Return
            If CurrentForm.NewDocument Then
                SaveAs()
            Else
                CurrentRichTextBox.SaveFile(CurrentDocName, RichTextBoxStreamType.RichText)
                CurrentForm.Modified = False
            End If

            SetModifiedCaption()
        End Sub

        Private Sub SaveAs()
            SaveAs(String.Empty)
        End Sub

        Private Sub SaveAs(ByVal path As String)
            If CurrentForm IsNot Nothing Then
                Dim s As String = CurrentForm.SaveAs(path)
                If Not Equals(s, String.Empty) Then
                    AddToMostRecentFiles(s, arMRUList)
                    AddToMostRecentFiles(s, Nothing)
                    AddToMostRecentFolders(s, Nothing)
                End If

                UpdateText()
            End If
        End Sub

        Private Sub iExit_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Close()
        End Sub

        Private Sub ribbonPageGroup1_CaptionButtonClick(ByVal sender As Object, ByVal e As RibbonPageGroupEventArgs)
            OpenFile()
        End Sub

        Private Sub ribbonPageGroup9_CaptionButtonClick(ByVal sender As Object, ByVal e As RibbonPageGroupEventArgs)
            SaveAs()
        End Sub

#End Region
#Region "Format"
        Private Function rtPadFontStyle() As FontStyle
            Dim fs As FontStyle = New FontStyle()
            If iBold.Down Then fs = fs Or FontStyle.Bold
            If iItalic.Down Then fs = fs Or FontStyle.Italic
            If iUnderline.Down Then fs = fs Or FontStyle.Underline
            Return fs
        End Function

        Private Sub iBullets_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If CurrentRichTextBox Is Nothing Then Return
            CurrentRichTextBox.SelectionBullet = iBullets.Down
            InitUndo()
        End Sub

        Private Sub iFontStyle_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If CurrentRichTextBox Is Nothing Then Return
            CurrentRichTextBox.SelectionFont = New Font(SelectFont, rtPadFontStyle())
        End Sub

        Private Sub iProtected_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If CurrentRichTextBox Is Nothing Then Return
            CurrentRichTextBox.SelectionProtected = iProtected.Down
        End Sub

        Private Sub iAlign_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If CurrentRichTextBox Is Nothing Then Return
            If iAlignLeft.Down Then CurrentRichTextBox.SelectionAlignment = HorizontalAlignment.Left
            If iCenter.Down Then CurrentRichTextBox.SelectionAlignment = HorizontalAlignment.Center
            If iAlignRight.Down Then CurrentRichTextBox.SelectionAlignment = HorizontalAlignment.Right
            InitUndo()
        End Sub

        Protected ReadOnly Property SelectFont As Font
            Get
                If CurrentRichTextBox IsNot Nothing Then Return CurrentRichTextBox.SelectionFont
                Return Nothing
            End Get
        End Property

        Private Sub ShowFontDialog()
            If CurrentRichTextBox Is Nothing Then Return
            Dim dialogFont As Font = Nothing
            If SelectFont IsNot Nothing Then
                dialogFont = CType(SelectFont.Clone(), Font)
            Else
                dialogFont = CurrentRichTextBox.Font
            End If

            Dim dlg As XtraFontDialog = New XtraFontDialog(dialogFont)
            If dlg.ShowDialog() = DialogResult.OK Then
                CurrentRichTextBox.SelectionFont = dlg.ResultFont
                beiFontSize.EditValue = dlg.ResultFont.Size
            End If
        End Sub

        Private Sub iFont_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            ShowFontDialog()
        End Sub

        Private Sub iFontColor_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If CurrentRichTextBox Is Nothing Then Return
            CurrentRichTextBox.SelectionColor = CType(pc, IPopupColorPickEdit).Color
        End Sub

#End Region
#Region "Edit"
        Private Sub iUndo_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If CurrentRichTextBox Is Nothing Then Return
            CurrentRichTextBox.Undo()
            CurrentForm.Modified = CurrentRichTextBox.CanUndo
            SetModifiedCaption()
            InitUndo()
            InitFormat()
        End Sub

        Private Sub iCut_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If CurrentRichTextBox Is Nothing Then Return
            CurrentRichTextBox.Cut()
            InitPaste()
        End Sub

        Private Sub iCopy_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If CurrentRichTextBox Is Nothing Then Return
            CurrentRichTextBox.Copy()
            InitPaste()
        End Sub

        Private Sub iPaste_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If CurrentRichTextBox Is Nothing Then Return
            CurrentRichTextBox.Paste()
        End Sub

        Private Sub iClear_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If CurrentRichTextBox Is Nothing Then Return
            CurrentRichTextBox.SelectedRtf = ""
        End Sub

        Private Sub iSelectAll_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If CurrentRichTextBox Is Nothing Then Return
            CurrentRichTextBox.SelectAll()
        End Sub

        Private Sub ribbonPageGroup2_CaptionButtonClick(ByVal sender As Object, ByVal e As RibbonPageGroupEventArgs)
            pmMain.ShowPopup(ribbonControl1.Manager, MousePosition)
        End Sub

#End Region
#Region "SkinGallery"
        Private Sub InitSkinGallery()
            XtraBars.Helpers.SkinHelper.InitSkinGallery(rgbiSkins, True)
        End Sub

#End Region
#Region "FontGallery"
        Private Function GetFontImage(ByVal width As Integer, ByVal height As Integer, ByVal fontName As String, ByVal fontSize As Integer) As Image
            Dim rect As Rectangle = New Rectangle(0, 0, width, height)
            Dim fontImage As Image = New Bitmap(width, height)
            Try
                Using fontSample As Font = New Font(fontName, fontSize)
                    Dim g As Graphics = Graphics.FromImage(fontImage)
                    g.FillRectangle(Brushes.White, rect)
                    Using fs As StringFormat = New StringFormat()
                        fs.Alignment = StringAlignment.Center
                        fs.LineAlignment = StringAlignment.Center
                        'g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                        g.DrawString("Aa", fontSample, Brushes.Black, rect, fs)
                        g.Dispose()
                    End Using
                End Using
            Catch
            End Try

            Return fontImage
        End Function

        Private Sub InitFont(ByVal groupDropDown As GalleryItemGroup, ByVal galleryGroup As GalleryItemGroup)
            Dim fonts As FontFamily() = FontFamily.Families
            For i As Integer = 0 To fonts.Length - 1
                If Not FontFamily.Families(i).IsStyleAvailable(FontStyle.Regular) Then Continue For
                Dim fontName As String = fonts(i).Name
                Dim item As GalleryItem = New GalleryItem()
                item.Caption = fontName
                item.Image = GetFontImage(40, 40, fontName, 16)
                item.HoverImage = item.Image
                item.Description = fontName
                item.Hint = fontName
                Try
                    item.Tag = New Font(fontName, 9)
                    If ControlUtils.IsSymbolFont(CType(item.Tag, Font)) Then
                        item.Tag = New Font(AppearanceObject.DefaultFont.FontFamily, 9)
                        item.Description += " (Symbol Font)"
                    End If
                Catch
                    Continue For
                End Try

                groupDropDown.Items.Add(item)
                galleryGroup.Items.Add(item)
            Next
        End Sub

        Private Sub InitFontGallery()
            gddFont.Gallery.BeginUpdate()
            rgbiFont.Gallery.BeginUpdate()
            Try
                InitFont(gddFont.Gallery.Groups(0), rgbiFont.Gallery.Groups(0))
            Finally
                gddFont.Gallery.EndUpdate()
                rgbiFont.Gallery.EndUpdate()
            End Try

            beiFontSize.EditValue = 8
        End Sub

        Private Sub SetFont(ByVal fontName As String, ByVal item As GalleryItem)
            If CurrentRichTextBox Is Nothing Then Return
            CurrentRichTextBox.SelectionFont = New Font(fontName, Convert.ToInt32(beiFontSize.EditValue), rtPadFontStyle())
            If item IsNot Nothing Then CurrentFontItem = item
        End Sub

        Private Sub gddFont_Gallery_ItemClick(ByVal sender As Object, ByVal e As GalleryItemClickEventArgs)
            SetFont(e.Item.Caption, e.Item)
        End Sub

        Private Sub rpgFont_CaptionButtonClick(ByVal sender As Object, ByVal e As RibbonPageGroupEventArgs)
            ShowFontDialog()
        End Sub

        Private Sub rgbiFont_Gallery_ItemClick(ByVal sender As Object, ByVal e As GalleryItemClickEventArgs)
            SetFont(e.Item.Caption, e.Item)
        End Sub

        Private Sub gddFont_Gallery_CustomDrawItemText(ByVal sender As Object, ByVal e As GalleryItemCustomDrawEventArgs)
            Dim itemInfo As Ribbon.ViewInfo.GalleryItemViewInfo = TryCast(e.ItemInfo, Ribbon.ViewInfo.GalleryItemViewInfo)
            itemInfo.PaintAppearance.ItemDescriptionAppearance.Normal.DrawString(e.Cache, e.Item.Description, itemInfo.DescriptionBounds)
            Dim app As AppearanceObject = TryCast(itemInfo.PaintAppearance.ItemCaptionAppearance.Normal.Clone(), AppearanceObject)
            app.Font = CType(e.Item.Tag, Font)
            Try
                e.Cache.Graphics.DrawString(e.Item.Caption, app.Font, app.GetForeBrush(e.Cache), itemInfo.CaptionBounds)
            Catch
            End Try

            e.Handled = True
        End Sub

#End Region
#Region "ColorGallery"
        Private Sub InitColorGallery()
            gddFontColor.BeginUpdate()
            For Each color As Color In ColorListBoxViewInfo.WebColors
                If color = Color.Transparent Then Continue For
                Dim item As GalleryItem = New GalleryItem()
                item.Caption = color.Name
                item.Tag = color
                item.Hint = color.Name
                gddFontColor.Gallery.Groups(0).Items.Add(item)
                rgbiFontColor.Gallery.Groups(0).Items.Add(item)
            Next

            For Each color As Color In ColorListBoxViewInfo.SystemColors
                Dim item As GalleryItem = New GalleryItem()
                item.Caption = color.Name
                item.Tag = color
                gddFontColor.Gallery.Groups(1).Items.Add(item)
            Next

            gddFontColor.EndUpdate()
        End Sub

        Private Sub gddFontColor_Gallery_CustomDrawItemImage(ByVal sender As Object, ByVal e As GalleryItemCustomDrawEventArgs)
            Dim clr As Color = CType(e.Item.Tag, Color)
            Using brush As Brush = New SolidBrush(clr)
                e.Cache.FillRectangle(brush, e.Bounds)
                e.Handled = True
            End Using
        End Sub

        Private Sub SetResultColor(ByVal color As Color, ByVal item As GalleryItem)
            If CurrentRichTextBox Is Nothing Then Return
            CurrentRichTextBox.SelectionColor = color
            If item IsNot Nothing Then CurrentColorItem = item
        End Sub

        Private Sub gddFontColor_Gallery_ItemClick(ByVal sender As Object, ByVal e As GalleryItemClickEventArgs)
            SetResultColor(CType(e.Item.Tag, Color), e.Item)
        End Sub

        Private Sub rpgFontColor_CaptionButtonClick(ByVal sender As Object, ByVal e As RibbonPageGroupEventArgs)
            If CurrentRichTextBox Is Nothing Then Return
            If pc Is Nothing Then CreateColorPopup(popupControlContainer1)
            popupControlContainer1.ShowPopup(ribbonControl1.Manager, MousePosition)
        End Sub

        Private Sub rgbiFontColor_Gallery_ItemClick(ByVal sender As Object, ByVal e As GalleryItemClickEventArgs)
            SetResultColor(CType(e.Item.Tag, Color), e.Item)
        End Sub

#End Region
        Private Sub iFind_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If CurrentRichTextBox Is Nothing Then Return
            If dlgReplace IsNot Nothing Then dlgReplace.Close()
            If dlgFind IsNot Nothing Then dlgFind.Close()
            dlgFind = New frmFind(CurrentRichTextBox, Bounds)
            AddOwnedForm(dlgFind)
            dlgFind.Show()
        End Sub

        Private Sub iReplace_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If CurrentRichTextBox Is Nothing Then Return
            If dlgReplace IsNot Nothing Then dlgReplace.Close()
            If dlgFind IsNot Nothing Then dlgFind.Close()
            dlgReplace = New frmReplace(CurrentRichTextBox, Bounds)
            AddOwnedForm(dlgReplace)
            dlgReplace.Show()
        End Sub

        Private Sub iWeb_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim fileName As String = "https://www.devexpress.com"
            SafeProcess.Open(fileName)
        End Sub

        Private Sub iAbout_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Call BarManager.About()
        End Sub

        Private Function TextByCaption(ByVal caption As String) As String
            Return caption.Replace("&", "")
        End Function

        Private Sub frmMain_Load(ByVal sender As Object, ByVal e As EventArgs)
            InitMostRecentFiles()
            arMRUList = New MRUArrayList(pcAppMenuFileLabels, imageCollection3.Images(0), imageCollection3.Images(1))
            AddHandler arMRUList.LabelClicked, New EventHandler(AddressOf OnMRUFileLabelClicked)
            InitMostRecentFiles(arMRUList)
            ribbonControl1.ForceInitialize()
            Dim skins As GalleryDropDown = New GalleryDropDown()
            skins.Ribbon = ribbonControl1
            XtraBars.Helpers.SkinHelper.InitSkinGalleryDropDown(skins)
            iPaintStyle.DropDownControl = skins
            CreateNewDocument()
            barEditItem1.EditValue = CType(ResourceImageHelperCore.CreateImageFromResources("DevExpress.XtraBars.Demos.RibbonSimplePad.online.gif", GetType(frmMain).Assembly), Bitmap)
        End Sub

        Private Sub InitMostRecentFiles(ByVal arMRUList As MRUArrayList)
            Dim fileName As String = Path.Combine(Application.StartupPath, MRUArrayList.MRUFileName)
            arMRUList.Init(fileName, "Document1.rtf")
        End Sub

#Region "GalleryItemsChecked"
        Private Function GetColorItemByColor(ByVal color As Color, ByVal gallery As BaseGallery) As GalleryItem
            For Each galleryGroup As GalleryItemGroup In gallery.Groups
                For Each item As GalleryItem In galleryGroup.Items
                    If Equals(item.Caption, color.Name) Then Return item
                Next
            Next

            Return Nothing
        End Function

        Private Function GetFontItemByFont(ByVal fontName As String, ByVal gallery As BaseGallery) As GalleryItem
            For Each galleryGroup As GalleryItemGroup In gallery.Groups
                For Each item As GalleryItem In galleryGroup.Items
                    If Equals(item.Caption, fontName) Then Return item
                Next
            Next

            Return Nothing
        End Function

        Private Property CurrentFontItem As GalleryItem
            Get
                Return fCurrentFontItem
            End Get

            Set(ByVal value As GalleryItem)
                If fCurrentFontItem Is value Then Return
                If fCurrentFontItem IsNot Nothing Then fCurrentFontItem.Checked = False
                fCurrentFontItem = value
                If fCurrentFontItem IsNot Nothing Then
                    fCurrentFontItem.Checked = True
                    MakeFontVisible(fCurrentFontItem)
                End If
            End Set
        End Property

        Private Sub MakeFontVisible(ByVal item As GalleryItem)
            gddFont.Gallery.MakeVisible(fCurrentFontItem)
            rgbiFont.Gallery.MakeVisible(fCurrentFontItem)
        End Sub

        Private Property CurrentColorItem As GalleryItem
            Get
                Return fCurrentColorItem
            End Get

            Set(ByVal value As GalleryItem)
                If fCurrentColorItem Is value Then Return
                If fCurrentColorItem IsNot Nothing Then fCurrentColorItem.Checked = False
                fCurrentColorItem = value
                If fCurrentColorItem IsNot Nothing Then
                    fCurrentColorItem.Checked = True
                    MakeColorVisible(fCurrentColorItem)
                End If
            End Set
        End Property

        Private Sub MakeColorVisible(ByVal item As GalleryItem)
            gddFontColor.Gallery.MakeVisible(fCurrentColorItem)
            rgbiFontColor.Gallery.MakeVisible(fCurrentColorItem)
        End Sub

        Private Sub CurrentFontChanged()
            If CurrentRichTextBox Is Nothing OrElse CurrentRichTextBox.SelectionFont Is Nothing Then Return
            CurrentFontItem = GetFontItemByFont(CurrentRichTextBox.SelectionFont.Name, rgbiFont.Gallery)
            CurrentColorItem = GetColorItemByColor(CurrentRichTextBox.SelectionColor, rgbiFontColor.Gallery)
        End Sub

        Private Sub gddFont_Popup(ByVal sender As Object, ByVal e As EventArgs)
            MakeFontVisible(CurrentFontItem)
            If CurrentRichTextBox Is Nothing OrElse CurrentRichTextBox.SelectionFont Is Nothing Then Return
            beiFontSize.EditValue = CurrentRichTextBox.SelectionFont.Size
        End Sub

        Private Sub gddFontColor_Popup(ByVal sender As Object, ByVal e As EventArgs)
            MakeColorVisible(CurrentColorItem)
        End Sub

#End Region
#Region "MostRecentFiles"
        Private arMRUList As MRUArrayList = Nothing

        Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            Dim startUpPath As String = Application.StartupPath
            SaveMostRecentFiles(recentTabItem1.TabPanel.Items, Path.Combine(startUpPath, FileNames))
            SaveMostRecentFiles(recentTabItem2.TabPanel.Items, Path.Combine(startUpPath, FolderNames))
        End Sub

        Private Sub InitMostRecentFiles()
            Dim startUpPath As String = Application.StartupPath
            Dim fileName As String = Path.Combine(startUpPath, MRUArrayList.MRUFileName)
            Dim folderName As String = Path.Combine(startUpPath, MRUArrayList.MRUFolderName)
            InitFiles(fileName, "Document1.rtf", True)
            InitFiles(folderName, Application.StartupPath, False)
        End Sub

        Public Sub InitFiles(ByVal fileName As String, ByVal defaultItem As String, ByVal isFile As Boolean)
            If Not File.Exists(fileName) Then
                StartInitFiles(isFile)
                EndInitFiles(isFile)
                'InsertElement(defaultItem, isFile);
                Return
            End If

            Dim sr As StreamReader = File.OpenText(fileName)
            Dim list As List(Of String) = New List(Of String)()
            Dim s As String = sr.ReadLine()
            While Not Equals(s, Nothing)
                list.Add(s)
                s = sr.ReadLine()
            End While

            For i As Integer = 0 To list.Count - 1
                InsertElement(list(i), isFile)
            Next

            sr.Close()
            If Not isFile Then CreateButtonBrowse()
        End Sub

        Private Function FindFirstUnCheckedIntemIndex(ByVal recentPanelBase As RecentPanelBase) As Integer
            For i As Integer = 0 To recentPanelBase.Items.Count - 1
                Dim pinItem As RecentPinItem = TryCast(recentPanelBase.Items(i), RecentPinItem)
                If pinItem Is Nothing Then Continue For
                If Not pinItem.PinButtonChecked Then Return i
            Next

            Return 0
        End Function

        Private Sub InsertElement(ByVal obj As Object, ByVal isFile As Boolean)
            Dim names As String() = obj.ToString().Split(","c)
            Dim _name As String = names(0)
            Dim checkedLabel As Boolean = False
            If names.Length > 1 Then checkedLabel = names(1).ToLower().Equals("true")
            If isFile Then
                Dim pinItem As RecentPinItem = New RecentPinItem() With {.Caption = GetFileName(_name), .Description = _name, .PinButtonChecked = checkedLabel}
                recentTabItem1.TabPanel.Items.Add(pinItem)
            Else
                Dim pinItem As RecentPinItem = New RecentPinItem() With {.Caption = GetFileName(_name), .Description = _name, .PinButtonChecked = checkedLabel}
                Dim pinItem_ As RecentPinItem = New RecentPinItem() With {.Caption = GetFileName(_name), .Description = _name, .PinButtonChecked = checkedLabel}
                recentTabItem2.TabPanel.Items.Add(pinItem)
                recentTabItem3.TabPanel.Items.Add(pinItem_)
            End If
        End Sub

        Private Sub CreateButtonBrowse()
            Dim hyperlinkBrowse As RecentHyperlinkItem = New RecentHyperlinkItem() With {.Caption = "Browse..."}
            recentTabItem2.TabPanel.Items.Add(hyperlinkBrowse)
            AddHandler hyperlinkBrowse.ItemClick, AddressOf hyperlinkBrowse_ItemClick
            Dim hyperlinkBrowse1 As RecentHyperlinkItem = New RecentHyperlinkItem() With {.Caption = "Browse..."}
            recentTabItem3.TabPanel.Items.Add(hyperlinkBrowse1)
            AddHandler hyperlinkBrowse1.ItemClick, AddressOf hyperlinkBrowse_ItemClick
        End Sub

        Private Sub hyperlinkBrowse_ItemClick(ByVal sender As Object, ByVal e As RecentItemEventArgs)
            SaveAs()
        End Sub

        Private Sub EndInitFiles(ByVal isFile As Boolean)
            If isFile Then
                InitDefaultFiles()
            Else
                InitDefaultFolders()
            End If

            If Not isFile Then CreateButtonBrowse()
        End Sub

        Private Sub StartInitFiles(ByVal isFile As Boolean)
            If Not isFile Then InitStartDefaultFolders()
        End Sub

        Private Sub InitStartDefaultFolders()
            Dim desktop As RecentPinItem = New RecentPinItem() With {.Caption = "Desktop", .Description = SafeEnvironment.Desktop, .PinButtonChecked = True, .ShowDescription = False}
            Dim desktop_ As RecentPinItem = New RecentPinItem() With {.Caption = "Desktop", .Description = SafeEnvironment.Desktop, .PinButtonChecked = True, .ShowDescription = False}
            recentTabItem2.TabPanel.Items.Add(desktop)
            recentTabItem3.TabPanel.Items.Add(desktop_)
            Dim separator As RecentSeparatorItem = New RecentSeparatorItem()
            Dim separator_ As RecentSeparatorItem = New RecentSeparatorItem()
            recentTabItem2.TabPanel.Items.Add(separator)
            recentTabItem3.TabPanel.Items.Add(separator_)
        End Sub

        Private Sub InitDefaultFolders()
            Dim item1 As RecentPinItem = New RecentPinItem() With {.Caption = "MyDocuments", .Description = SafeEnvironment.MyDocuments}
            Dim item1_ As RecentPinItem = New RecentPinItem() With {.Caption = "MyDocuments", .Description = SafeEnvironment.MyDocuments}
            recentTabItem2.TabPanel.Items.Add(item1)
            recentTabItem3.TabPanel.Items.Add(item1_)
            Dim item7 As RecentPinItem = New RecentPinItem() With {.Caption = "Saved HTML Articles", .Description = "D:\Personal\Saved HTML Articles"}
            Dim item7_ As RecentPinItem = New RecentPinItem() With {.Caption = "Saved HTML Articles", .Description = "D:\Personal\Saved HTML Articles"}
            recentTabItem2.TabPanel.Items.Add(item7)
            recentTabItem3.TabPanel.Items.Add(item7_)
            Dim item3 As RecentPinItem = New RecentPinItem() With {.Caption = "Tutorials", .Description = "C:\Program Files x86\DevExpress 15.2\Tutorials"}
            Dim item3_ As RecentPinItem = New RecentPinItem() With {.Caption = "Tutorials", .Description = "C:\Program Files x86\DevExpress 15.2\Tutorials"}
            recentTabItem2.TabPanel.Items.Add(item3)
            recentTabItem3.TabPanel.Items.Add(item3_)
            Dim item2 As RecentPinItem = New RecentPinItem() With {.Caption = "Products", .Description = "C:\DevExpress\Products"}
            Dim item2_ As RecentPinItem = New RecentPinItem() With {.Caption = "Products", .Description = "C:\DevExpress\Products"}
            recentTabItem2.TabPanel.Items.Add(item2)
            recentTabItem3.TabPanel.Items.Add(item2_)
            Dim item8 As RecentPinItem = New RecentPinItem() With {.Caption = "Win Forms", .Description = "C:\DevExpress\Products\Win Forms"}
            Dim item8_ As RecentPinItem = New RecentPinItem() With {.Caption = "Win Forms", .Description = "C:\DevExpress\Products\Win Forms"}
            recentTabItem2.TabPanel.Items.Add(item8)
            recentTabItem3.TabPanel.Items.Add(item8_)
            Dim item9 As RecentPinItem = New RecentPinItem() With {.Caption = "Controls", .Description = "C:\DevExpress\Products\Win Forms\Controls"}
            Dim item9_ As RecentPinItem = New RecentPinItem() With {.Caption = "Controls", .Description = "C:\DevExpress\Products\Win Forms\Controls"}
            recentTabItem2.TabPanel.Items.Add(item9)
            recentTabItem3.TabPanel.Items.Add(item9_)
        End Sub

        Private Sub InitDefaultFiles()
            Dim item1 As RecentPinItem = New RecentPinItem() With {.Caption = "Windows 10 GuideLines.doc", .Description = "D:\Personal\Saved HTML Articles"}
            recentTabItem1.TabPanel.Items.Add(item1)
            Dim item2 As RecentPinItem = New RecentPinItem() With {.Caption = "Web Site Usability.doc", .Description = "C:\Users\Default\Documents"}
            recentTabItem1.TabPanel.Items.Add(item2)
            Dim item3 As RecentPinItem = New RecentPinItem() With {.Caption = "Getting Started.pdf", .Description = "C:\Program Files x86\DevExpress 15.2\Tutorials"}
            recentTabItem1.TabPanel.Items.Add(item3)
            Dim item4 As RecentPinItem = New RecentPinItem() With {.Caption = "Office 2013 features.docx", .Description = "C:\DevExpress\Products\Win Forms"}
            recentTabItem1.TabPanel.Items.Add(item4)
            Dim item5 As RecentPinItem = New RecentPinItem() With {.Caption = "WinForms Webinar.pdf", .Description = "C:\DevExpress\Webinars"}
            recentTabItem1.TabPanel.Items.Add(item5)
        End Sub

        Private Function GetFileName(ByVal obj As Object) As String
            Dim fi As FileInfo = New FileInfo(obj.ToString())
            Return fi.Name
        End Function

        Private Sub recentControlOpen_ItemClick(ByVal sender As Object, ByVal e As RecentItemEventArgs)
            Dim recentItem As RecentPinItem = TryCast(e.Item, RecentPinItem)
            If recentItem IsNot Nothing Then ribbonControl1.HideApplicationButtonContentControl()
            If recentTabItem1.TabPanel.Items.Contains(e.Item) AndAlso recentItem IsNot Nothing Then
                OpenFileCore(recentItem.Description)
            ElseIf recentTabItem2.TabPanel.Items.Contains(e.Item) Then
                If recentItem IsNot Nothing Then OpenFileFolder(recentItem.Description)
            End If
        End Sub

        Private Sub OpenFileFolder(ByVal p As String)
            Dim dlg As OpenFileDialog = New OpenFileDialog()
            If Not Equals(p, String.Empty) Then dlg.InitialDirectory = p
            dlg.Filter = "Rich Text Files (*.rtf)|*.rtf"
            dlg.Title = "Open"
            If dlg.ShowDialog(Me) = DialogResult.OK Then
                OpenFile(dlg.FileName)
            End If
        End Sub

        Private Sub recentControlSave_ItemClick(ByVal sender As Object, ByVal e As RecentItemEventArgs)
            ribbonControl1.HideApplicationButtonContentControl()
            Dim recentItem As RecentPinItem = TryCast(e.Item, RecentPinItem)
            If recentTabItem3.TabPanel.Items.Contains(e.Item) Then
                If recentItem IsNot Nothing Then SaveAs(recentItem.Description)
            End If
        End Sub

        Private Sub recentControlExport_ItemClick(ByVal sender As Object, ByVal e As RecentItemEventArgs)
            If CurrentForm Is Nothing Then
                Ribbon.HideApplicationButtonContentControl()
                Return
            End If

            Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
            saveFileDialog.Title = "Export"
            If Not(TypeOf e.Item Is RecentPinItem) Then Return
            Dim caption As String = TryCast(e.Item, RecentPinItem).Caption
            If caption.Contains("PDF") Then
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf"
            ElseIf caption.Contains("HTML") Then
                saveFileDialog.Filter = "HTML files (*.html)|*.html"
            ElseIf caption.Contains("MHT") Then
                saveFileDialog.Filter = "MHT files (*.mht)|*.mht"
            ElseIf caption.Contains("RTF") Then
                saveFileDialog.Filter = "RTF files (*.rtf)|*.rtf"
            ElseIf caption.Contains("XLS") Then
                saveFileDialog.Filter = "XLS files (*.xls)|*.xls"
            ElseIf caption.Contains("XLSX") Then
                saveFileDialog.Filter = "XLSX files (*.xls)|*.xls"
            ElseIf caption.Contains("CSV") Then
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv"
            ElseIf caption.Contains("Text File") Then
                saveFileDialog.Filter = "Text files (*.txt)|*.txt"
            ElseIf caption.Contains("Image") Then
                saveFileDialog.Filter = "BMP files (*.bmp)|*.bmp|Gif files (*.gif)|*.gif|Jpeg files (*.jpeg)|*.jpeg|PNG files (*.png)|*.png|Tiff files (*.tiff)|*.tiff|EMF files (*.emf)|.emf|WMF files (*.wmf)|*.wmf"
            End If

            saveFileDialog.Filter += "|All files (*.*)|*.*"
            saveFileDialog.FilterIndex = 0
            If saveFileDialog.ShowDialog() <> DialogResult.OK Then Return
            Dim report As XtraReport = New XtraReport()
             ''' Cannot convert InvocationExpressionSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ArgumentListSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitInvocationExpression(InvocationExpressionSyntax node) in C:\a\_work\dxvcs\dxvcs\Temp\NetStudio.v26.1.2005\XPF\Utils\CSharpToVBConverter.Demos\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 1392
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\a\_work\dxvcs\dxvcs\Temp\NetStudio.v26.1.2005\XPF\Utils\CSharpToVBConverter.Demos\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
'''             report.Bands.Add(new DevExpress.XtraReports.UI.DetailBand() {
'''                 Controls = { new DevExpress.XtraReports.UI.XRRichText() {
'''                     BoundsF = new System.Drawing.RectangleF(0, 0, 650, 0),
'''                     Rtf = this.CurrentRichTextBox.Rtf,
'''                 } }
'''             })
'''  report.CreateDocument()
            If caption.Contains("PDF") Then
                report.ExportToPdf(saveFileDialog.FileName)
            ElseIf caption.Contains("HTML") Then
                report.ExportToHtml(saveFileDialog.FileName)
            ElseIf caption.Contains("MHT") Then
                report.ExportToMht(saveFileDialog.FileName)
            ElseIf caption.Contains("RTF") Then
                report.ExportToRtf(saveFileDialog.FileName)
            ElseIf caption.Contains("XLS") Then
                report.ExportToXls(saveFileDialog.FileName)
            ElseIf caption.Contains("XLSX") Then
                report.ExportToXlsx(saveFileDialog.FileName)
            ElseIf caption.Contains("CSV") Then
                report.ExportToCsv(saveFileDialog.FileName)
            ElseIf caption.Contains("Text File") Then
                report.ExportToText(saveFileDialog.FileName)
            ElseIf caption.Contains("Image") Then
                Dim fmt As DXImageFormat = DXImageFormat.Bmp
                Select Case saveFileDialog.FilterIndex
                    Case 0
                        fmt = DXImageFormat.Bmp
                    Case 1
                        fmt = DXImageFormat.Gif
                    Case 2
                        fmt = DXImageFormat.Jpeg
                    Case 3
                        fmt = DXImageFormat.Png
                    Case 4
                        fmt = DXImageFormat.Tiff
                    Case 5
                        fmt = DXImageFormat.Emf
                    Case 6
                        fmt = DXImageFormat.Wmf
                End Select

                report.ExportToImage(saveFileDialog.FileName, fmt)
            End If
        End Sub

        Private Sub OpenFileCore(ByVal path As String)
            ribbonControl1.DeactivateKeyboardNavigation()
            pmAppMain.HidePopup()
            Refresh()
            If File.Exists(path) Then
                OpenFile(path)
                backstageViewControl1.Ribbon.HideApplicationButtonContentControl()
            Else
                XtraMessageBox.Show(String.Format("ItemClick {0}", path.ToString()))
            End If
        End Sub

        Private Sub SaveMostRecentFiles(ByVal files As RecentItemCollection, ByVal fileName As String)
            Try
                Dim sw As StreamWriter = File.CreateText(fileName)
                For i As Integer = 0 To files.Count - 1
                    Dim pinItem As RecentPinItem = TryCast(files(i), RecentPinItem)
                    If pinItem Is Nothing Then Continue For
                    sw.WriteLine(String.Format("{0},{1}", If(Not Equals(pinItem.Description, String.Empty), pinItem.Description, pinItem.Caption), pinItem.PinButtonChecked.ToString()))
                Next

                sw.Close()
            Catch
            End Try
        End Sub

        Private Sub OnMRUFileLabelClicked(ByVal sender As Object, ByVal e As EventArgs)
            ribbonControl1.DeactivateKeyboardNavigation()
            pmAppMain.HidePopup()
            Refresh()
            OpenFile(sender.ToString())
        End Sub

#End Region
        Private Sub ribbonControl1_ApplicationButtonDoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            If ribbonControl1.RibbonStyle = RibbonControlStyle.Office2007 Then Close()
        End Sub

        Private Sub barEditItem1_ItemPress(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            SafeProcess.TryOpenHyperlink("https://www.devexpress.com")
        End Sub

        Private Sub biStyle_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim style As RibbonControlStyle = CType(biStyle.EditValue, RibbonControlStyle)
            ribbonControl1.RibbonStyle = style
            ribbonControl1.ApplicationButtonDropDownControl = If(style = RibbonControlStyle.Office2007, CObj(pmAppMain), backstageViewControl1)
            If style = RibbonControlStyle.TabletOffice OrElse style = RibbonControlStyle.OfficeUniversal Then
                barToggleSwitchItem1.Visibility = BarItemVisibility.Always
            Else
                barToggleSwitchItem1.Visibility = BarItemVisibility.Never
            End If

            UpdateLookAndFeel()
            UpdateSearchBoxPosition()
            UpdateEmpaSpacePanelVisibility()
        End Sub

        Private ReadOnly Property IsOffice365StyleOrDefault As Boolean
            Get
                Return Ribbon.RibbonStyle = RibbonControlStyle.Office365 OrElse Ribbon.RibbonStyle = RibbonControlStyle.Default
            End Get
        End Property

        Private Sub UpdateEmpaSpacePanelVisibility()
            emptySpacePanel.Visible = IsOffice365StyleOrDefault
        End Sub

        Private Sub UpdateSearchBoxPosition()
            Ribbon.SearchItemPosition = If(IsOffice365StyleOrDefault, SearchItemPosition.Caption, SearchItemPosition.PageHeader)
        End Sub

        Private Sub UpdateLookAndFeel()
            Dim skinName As String
            Dim style As RibbonControlStyle = ribbonControl1.RibbonStyle
            Select Case style
                Case RibbonControlStyle.Office365, RibbonControlStyle.Default
                    skinName = "WXI"
                Case RibbonControlStyle.Office2019
                    skinName = "Office 2019 Colorful"
                Case RibbonControlStyle.Office2007
                    skinName = "Office 2007 Blue"
                Case RibbonControlStyle.Office2013, RibbonControlStyle.TabletOffice, RibbonControlStyle.OfficeUniversal
                    skinName = "Office 2013"
                Case Else
                    skinName = "Office 2010 Blue"
            End Select

            UserLookAndFeel.Default.SetSkinStyle(skinName)
        End Sub

        Private Sub sbExit_Click(ByVal sender As Object, ByVal e As EventArgs)
            Close()
        End Sub

        Private Sub beiFontSize_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If CurrentRichTextBox Is Nothing Then Return
            Dim _font As Font = CurrentRichTextBox.SelectionFont
            If _font Is Nothing Then
                _font = AppearanceObject.DefaultFont
            End If

            CurrentRichTextBox.SelectionFont = New Font(_font.FontFamily, Convert.ToSingle(beiFontSize.EditValue), _font.Style)
        End Sub

        Private Sub onTabPrint_SelectedChanged(ByVal sender As Object, ByVal e As BackstageViewItemEventArgs)
            InitPrintingSystem()
        End Sub

        Private Sub ribbonControl1_BeforeApplicationButtonContentControlShow(ByVal sender As Object, ByVal e As EventArgs)
            If backstageViewControl1.SelectedTab Is printTabItem Then InitPrintingSystem()
        End Sub

        Private Sub bvItemSave_ItemClick(ByVal sender As Object, ByVal e As BackstageViewItemEventArgs)
            Save()
        End Sub

        Private Sub bvItemSaveAs_ItemClick(ByVal sender As Object, ByVal e As BackstageViewItemEventArgs)
            SaveAs()
        End Sub

        Private Sub bvItemOpen_ItemClick(ByVal sender As Object, ByVal e As BackstageViewItemEventArgs)
            OpenFile()
        End Sub

        Private Sub bvItemClose_ItemClick(ByVal sender As Object, ByVal e As BackstageViewItemEventArgs)
            If xtraTabbedMdiManager1.SelectedPage IsNot Nothing Then xtraTabbedMdiManager1.SelectedPage.MdiChild.Close()
        End Sub

        Private Sub bvItemExit_ItemClick(ByVal sender As Object, ByVal e As BackstageViewItemEventArgs)
            Close()
        End Sub

        Private Sub ribbonControl1_ResetLayout(ByVal sender As Object, ByVal e As ResetLayoutEventArgs)
            ShowHideFormatCategory()
        End Sub

        Private Sub OnNewDocThumbButtonClick(ByVal sender As Object, ByVal e As ThumbButtonClickEventArgs)
            CreateNewDocument()
        End Sub

        Private Sub OnPrevThumbButtonClick(ByVal sender As Object, ByVal e As ThumbButtonClickEventArgs)
            Dim mdiChild As Form = GetPrevMdiChild()
            If mdiChild IsNot Nothing Then ActivateMdiChild(mdiChild)
        End Sub

        Private Sub OnNextDocThumbButtonClick(ByVal sender As Object, ByVal e As ThumbButtonClickEventArgs)
            Dim mdiChild As Form = GetNextMdiChild()
            If mdiChild IsNot Nothing Then ActivateMdiChild(mdiChild)
        End Sub

        Private Sub OnExitThumbButtonClick(ByVal sender As Object, ByVal e As ThumbButtonClickEventArgs)
            Close()
        End Sub

        Private Function GetNextMdiChild() As Form
            If ActiveMdiChild Is Nothing OrElse MdiChildren.Length < 2 Then Return Nothing
            Dim pos As Integer = Array.IndexOf(MdiChildren, ActiveMdiChild)
            Return If(pos = MdiChildren.Length - 1, MdiChildren(0), MdiChildren(pos + 1))
        End Function

        Private Function GetPrevMdiChild() As Form
            If ActiveMdiChild Is Nothing OrElse MdiChildren.Length < 2 Then Return Nothing
            Dim pos As Integer = Array.IndexOf(MdiChildren, ActiveMdiChild)
            Return If(pos = 0, MdiChildren(MdiChildren.Length - 1), MdiChildren(pos - 1))
        End Function

        Private Sub OnTabbedMdiManagerPageCollectionChanged(ByVal sender As Object, ByVal e As XtraTabbedMdi.MdiTabPageEventArgs)
            UpdateThumbnailButtons()
        End Sub

        Private Sub UpdateThumbnailButtons()
            thumbButtonPrev.Enabled = MdiChildren.Length > 1
            thumbButtonNext.Enabled = thumbButtonPrev.Enabled
        End Sub

        Private Sub bbColorMix_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim form As ColorWheelForm = New ColorWheelForm()
            form.StartPosition = FormStartPosition.CenterParent
            form.SkinMaskColor = UserLookAndFeel.Default.SkinMaskColor
            form.SkinMaskColor2 = UserLookAndFeel.Default.SkinMaskColor2
            form.ShowDialog(Me)
        End Sub

#Region "Print processing"
        Private Sub InitPrintingSystem()
            Dim frm As RibbonForm = TryCast(FindForm(), RibbonForm)
            Dim manager As BarManager = ribbonControl1.Manager
            CType(ddbOrientation.DropDownControl, GalleryDropDown).Manager = manager
            CType(ddbMargins.DropDownControl, GalleryDropDown).Manager = manager
            CType(ddbPaperSize.DropDownControl, GalleryDropDown).Manager = manager
            CType(ddbCollate.DropDownControl, GalleryDropDown).Manager = manager
            CType(ddbPrinter.DropDownControl, GalleryDropDown).Manager = manager
            CType(ddbDuplex.DropDownControl, GalleryDropDown).Manager = manager
            Dim report As XtraReport = New XtraReport()
             ''' Cannot convert InvocationExpressionSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ArgumentListSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitInvocationExpression(InvocationExpressionSyntax node) in C:\a\_work\dxvcs\dxvcs\Temp\NetStudio.v26.1.2005\XPF\Utils\CSharpToVBConverter.Demos\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 1392
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\a\_work\dxvcs\dxvcs\Temp\NetStudio.v26.1.2005\XPF\Utils\CSharpToVBConverter.Demos\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
'''             report.Bands.Add(new DevExpress.XtraReports.UI.DetailBand() {
'''                 Controls = { new DevExpress.XtraReports.UI.XRRichText() {
'''                     BoundsF = new System.Drawing.RectangleF(0, 0, 650, 0),
'''                     Rtf = this.CurrentRichTextBox.Rtf,
'''                 } }
'''             })
'''  AddHandler report.AfterPrint, AddressOf Report_AfterPrint
            Dim ps As PrintingSystemBase = report.PrintingSystem
            AddHandler ps.StartPrint, New PrintDocumentEventHandler(AddressOf OnStartPrint)
            printControl2.DocumentSource = report
            printControl2.InitiateDocumentCreation()
            printButton.Enabled = False
            pageButtonEdit.Enabled = False
            pageButtonEdit.EditValue = Nothing
            pageButtonEdit.Properties.DisplayFormat.FormatString = ""
            UpdatePrintPageSettings()
        End Sub

        Private Sub Report_AfterPrint(ByVal sender As Object, ByVal e As EventArgs)
            Dim pages = CType(sender, XtraReport).Pages
            printButton.Enabled = pages.Count > 0
            pageButtonEdit.Enabled = pages.Count > 0
            pageButtonEdit.Properties.DisplayFormat.FormatString = "Page {0} of " & pages.Count
        End Sub

        Private Sub printButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            CType(printControl2.PrintingSystem, PrintingSystem).Print(ddbPrinter.Text)
        End Sub

        Private Sub OnStartPrint(ByVal sender As Object, ByVal e As PrintDocumentEventArgs)
            e.PrintDocument.PrinterSettings.Copies = CShort(copySpinEdit.Value)
            Dim p As Padding = CType(ddbMargins.Tag, Padding)
            printControl2.PrintingSystem.PageSettings.TopMargin = CInt(p.Top * 3.9)
            printControl2.PrintingSystem.PageSettings.BottomMargin = CInt(p.Bottom * 3.9)
            printControl2.PrintingSystem.PageSettings.LeftMargin = CInt(p.Left * 3.9)
            printControl2.PrintingSystem.PageSettings.RightMargin = CInt(p.Right * 3.9)
            e.PrintDocument.PrinterSettings.Collate = CBool(ddbCollate.Tag)
            e.PrintDocument.PrinterSettings.Duplex = If((CBool(ddbDuplex.Tag)), Duplex.Horizontal, Duplex.Simplex)
        End Sub

        Private Sub InitPrint()
            ddbOrientation.DropDownControl = CreateOrientationGallery()
            ddbMargins.DropDownControl = CreateMarginsGallery()
            ddbPaperSize.DropDownControl = CreatePageSizeGallery()
            ddbCollate.DropDownControl = CreateCollateGallery()
            ddbPrinter.DropDownControl = CreatePrintersGallery()
            ddbDuplex.DropDownControl = CreateDuplexGallery()
        End Sub

        Private Function CreateListBoxGallery() As GalleryDropDown
            Dim res As GalleryDropDown = New GalleryDropDown()
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
            res.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = HorzAlignment.Near
            res.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.VAlignment = VertAlignment.Center
            res.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
            res.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = HorzAlignment.Near
            res.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.VAlignment = VertAlignment.Center
            res.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
            res.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = HorzAlignment.Near
            res.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.VAlignment = VertAlignment.Center
            res.Gallery.ItemImageLocation = Locations.Left
            res.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = HorzAlignment.Near
            res.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = True
            res.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = HorzAlignment.Near
            res.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = True
            res.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = HorzAlignment.Near
            res.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = True
            res.Gallery.Groups.Add(New GalleryItemGroup())
            res.Gallery.StretchItems = True
            Return res
        End Function

        Private Function CreateOrientationGallery() As GalleryDropDown
            Dim res As GalleryDropDown = CreateListBoxGallery()
            Dim portraitItem As GalleryItem = New GalleryItem()
            portraitItem.ImageOptions.SvgImage = Global.DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PageOrientationPortrait1
            portraitItem.Caption = "Portrait Orientation"
            Dim landscapeItem As GalleryItem = New GalleryItem()
            landscapeItem.ImageOptions.SvgImage = Global.DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PageOrientationLandscape1
            landscapeItem.Caption = "Landscape Orientation"
            res.Gallery.Groups(0).Items.Add(portraitItem)
            res.Gallery.Groups(0).Items.Add(landscapeItem)
            AddHandler res.Gallery.ItemCheckedChanged, New GalleryItemEventHandler(AddressOf OnOrientationGalleryItemCheckedChanged)
            portraitItem.Checked = True
            Return res
        End Function

        Private Function CreateMarginsGallery() As GalleryDropDown
            Dim res As GalleryDropDown = CreateListBoxGallery()
            Dim normal As GalleryItem = New GalleryItem()
            normal.ImageOptions.SvgImage = Global.DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PageMarginsNormal1
            normal.Caption = "Normal"
            normal.Description = "Top:" & Microsoft.VisualBasic.Constants.vbTab & "25 mm" & Microsoft.VisualBasic.Constants.vbTab & "Bottom:" & Microsoft.VisualBasic.Constants.vbTab & "25 mm" & Microsoft.VisualBasic.Constants.vbLf & "Left:" & Microsoft.VisualBasic.Constants.vbTab & "25 mm" & Microsoft.VisualBasic.Constants.vbTab & "Right:" & Microsoft.VisualBasic.Constants.vbTab & "25 mm"
            normal.Tag = New Padding(25, 25, 25, 25)
            Dim narrow As GalleryItem = New GalleryItem()
            narrow.ImageOptions.SvgImage = Properties.Resources.PageMarginsNarrow1
            narrow.Caption = "Narrow"
            narrow.Description = "Top:" & Microsoft.VisualBasic.Constants.vbTab & "12 mm" & Microsoft.VisualBasic.Constants.vbTab & "Bottom:" & Microsoft.VisualBasic.Constants.vbTab & "12 mm" & Microsoft.VisualBasic.Constants.vbLf & "Left:" & Microsoft.VisualBasic.Constants.vbTab & "12 mm" & Microsoft.VisualBasic.Constants.vbTab & "Right:" & Microsoft.VisualBasic.Constants.vbTab & "12 mm"
            narrow.Tag = New Padding(12, 12, 12, 12)
            Dim moderate As GalleryItem = New GalleryItem()
            moderate.ImageOptions.SvgImage = Properties.Resources.PageMarginsModerate1
            moderate.Caption = "Moderate"
            moderate.Description = "Top:" & Microsoft.VisualBasic.Constants.vbTab & "25 mm" & Microsoft.VisualBasic.Constants.vbTab & "Bottom:" & Microsoft.VisualBasic.Constants.vbTab & "25 mm" & Microsoft.VisualBasic.Constants.vbLf & "Left:" & Microsoft.VisualBasic.Constants.vbTab & "19 mm" & Microsoft.VisualBasic.Constants.vbTab & "Right:" & Microsoft.VisualBasic.Constants.vbTab & "19 mm"
            moderate.Tag = New Padding(19, 25, 19, 25)
            Dim wide As GalleryItem = New GalleryItem()
            wide.ImageOptions.SvgImage = Properties.Resources.PageMarginsWide1
            wide.Caption = "Wide"
            wide.Description = "Top:" & Microsoft.VisualBasic.Constants.vbTab & "25 mm" & Microsoft.VisualBasic.Constants.vbTab & "Bottom:" & Microsoft.VisualBasic.Constants.vbTab & "25 mm" & Microsoft.VisualBasic.Constants.vbLf & "Left:" & Microsoft.VisualBasic.Constants.vbTab & "50 mm" & Microsoft.VisualBasic.Constants.vbTab & "Right:" & Microsoft.VisualBasic.Constants.vbTab & "50 mm"
            wide.Tag = New Padding(50, 25, 50, 25)
            res.Gallery.Groups(0).Items.Add(normal)
            res.Gallery.Groups(0).Items.Add(narrow)
            res.Gallery.Groups(0).Items.Add(moderate)
            res.Gallery.Groups(0).Items.Add(wide)
            AddHandler res.Gallery.ItemCheckedChanged, New GalleryItemEventHandler(AddressOf OnMarginsGalleryItemCheckedChanged)
            normal.Checked = True
            Return res
        End Function

        Private Function CreatePageSizeGallery() As GalleryDropDown
            Dim res As GalleryDropDown = CreateListBoxGallery()
            Dim letter As GalleryItem = New GalleryItem()
            letter.ImageOptions.SvgImage = Properties.Resources.PaperKind_Letter1
            letter.Caption = "Letter"
            letter.Description = "215 mm x 279 mm"
            letter.Tag = DXPaperKind.Letter
            Dim tabloid As GalleryItem = New GalleryItem()
            tabloid.ImageOptions.SvgImage = Properties.Resources.PaperKind_Tabloid1
            tabloid.Caption = "Tabloid"
            tabloid.Description = "279 mm x 431 mm"
            tabloid.Tag = DXPaperKind.Tabloid
            Dim legal As GalleryItem = New GalleryItem()
            legal.ImageOptions.SvgImage = Properties.Resources.PaperKind_Legal1
            legal.Caption = "Legal"
            legal.Description = "215 mm x 355 mm"
            legal.Tag = DXPaperKind.Legal
            Dim executive As GalleryItem = New GalleryItem()
            executive.ImageOptions.SvgImage = Properties.Resources.PaperKind_Executive1
            executive.Caption = "Executive"
            executive.Description = "184 mm x 266 mm"
            executive.Tag = DXPaperKind.Executive
            Dim a3 As GalleryItem = New GalleryItem()
            a3.ImageOptions.SvgImage = Properties.Resources.PaperKind_A31
            a3.Caption = "A3"
            a3.Description = "296 mm x 420 mm"
            a3.Tag = DXPaperKind.A3
            Dim a4 As GalleryItem = New GalleryItem()
            a4.ImageOptions.SvgImage = Properties.Resources.PaperKind_A41
            a4.Caption = "A4"
            a4.Description = "210 mm x 296 mm"
            a4.Tag = DXPaperKind.A4
            Dim a5 As GalleryItem = New GalleryItem()
            a5.ImageOptions.SvgImage = Properties.Resources.PaperKind_A51
            a5.Caption = "A5"
            a5.Description = "148 mm x 210 mm"
            a5.Tag = DXPaperKind.A5
            Dim a6 As GalleryItem = New GalleryItem()
            a6.ImageOptions.SvgImage = Properties.Resources.PaperKind_A61
            a6.Caption = "A6"
            a6.Description = "105 mm x 148 mm"
            a6.Tag = DXPaperKind.A6
            res.Gallery.Groups(0).Items.Add(letter)
            res.Gallery.Groups(0).Items.Add(tabloid)
            res.Gallery.Groups(0).Items.Add(legal)
            res.Gallery.Groups(0).Items.Add(executive)
            res.Gallery.Groups(0).Items.Add(a3)
            res.Gallery.Groups(0).Items.Add(a4)
            res.Gallery.Groups(0).Items.Add(a5)
            res.Gallery.Groups(0).Items.Add(a6)
            AddHandler res.Gallery.ItemCheckedChanged, New GalleryItemEventHandler(AddressOf OnPaperSizeGalleryItemCheckedChanged)
            a4.Checked = True
            Return res
        End Function

        Private Function CreateCollateGallery() As GalleryDropDown
            Dim res As GalleryDropDown = CreateListBoxGallery()
            Dim collated As GalleryItem = New GalleryItem()
            collated.ImageOptions.SvgImage = Global.DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.Page_
            collated.Caption = "Collated"
            collated.Description = "1,2,3   1,2,3  1,2,3"
            collated.Tag = True
            Dim uncollated As GalleryItem = New GalleryItem()
            uncollated.ImageOptions.SvgImage = Global.DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.Page_
            uncollated.Caption = "Uncollated"
            uncollated.Description = "1,1,1  2,2,2  3,3,3"
            uncollated.Tag = False
            res.Gallery.Groups(0).Items.Add(collated)
            res.Gallery.Groups(0).Items.Add(uncollated)
            AddHandler res.Gallery.ItemCheckedChanged, New GalleryItemEventHandler(AddressOf OnCollateGalleryItemCheckedChanged)
            collated.Checked = True
            Return res
        End Function

        Private Function CreateDuplexGallery() As GalleryDropDown
            Dim res As GalleryDropDown = CreateListBoxGallery()
            Dim oneSided As GalleryItem = New GalleryItem()
            oneSided.ImageOptions.SvgImage = Global.DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.Page_
            oneSided.Caption = "Print One Sided"
            oneSided.Description = "Only print on one side of the page"
            oneSided.Tag = False
            Dim twoSided As GalleryItem = New GalleryItem()
            twoSided.ImageOptions.SvgImage = Global.DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.Page_
            twoSided.Caption = "Manually Print on Both Sides"
            twoSided.Description = "Reload paper when prompted to print the second side"
            twoSided.Tag = False
            res.Gallery.Groups(0).Items.Add(oneSided)
            res.Gallery.Groups(0).Items.Add(twoSided)
            AddHandler res.Gallery.ItemCheckedChanged, New GalleryItemEventHandler(AddressOf OnDuplexGalleryItemCheckedChanged)
            oneSided.Checked = True
            Return res
        End Function

        Private Sub OnDuplexGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            UpdatePrintPageDuplex(e.Item)
        End Sub

        Private Function CreatePrintersGallery() As GalleryDropDown
            Dim res As GalleryDropDown = CreateListBoxGallery()
            Dim printerItemContainer As PrinterItemContainer = New PrinterItemContainer()
            Dim defaultPrinterName = printerItemContainer.DefaultPrinterName
            Dim defaultPrinter As GalleryItem = Nothing
            Try
                For Each printerItem In printerItemContainer.Items
                    Dim item As GalleryItem = New GalleryItem()
                    item.ImageOptions.SvgImage = printButton.ImageOptions.SvgImage
                    item.Caption = printerItem.FullName
                    res.Gallery.Groups(0).Items.Add(item)
                    If Equals(printerItem.FullName, defaultPrinterName) Then defaultPrinter = item
                Next
            Catch
            End Try

            AddHandler res.Gallery.ItemCheckedChanged, New GalleryItemEventHandler(AddressOf OnPrinterGalleryItemCheckedChanged)
            If defaultPrinter IsNot Nothing Then defaultPrinter.Checked = True
            Return res
        End Function

        Private Sub OnMarginsGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            UpdatePrintPageMargins(e.Item)
        End Sub

        Private Sub OnPrinterGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            UpdatePrintPagePrinters(e.Item)
        End Sub

        Private Sub OnCollateGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            UpdatePrintPageCollate(e.Item)
        End Sub

        Private Sub OnPaperSizeGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            UpdatePrintPageSize(e.Item)
        End Sub

        Private Sub OnOrientationGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            UpdatePrintPageOrientation(e.Item)
        End Sub

        Public Sub UpdatePrintPageSettings()
            If ddbOrientation.DropDownControl IsNot Nothing Then
                UpdatePrintPageOrientation(CType(ddbOrientation.DropDownControl, GalleryDropDown).Gallery.GetCheckedItem())
            End If

            If ddbMargins.DropDownControl IsNot Nothing Then
                UpdatePrintPageMargins(CType(ddbMargins.DropDownControl, GalleryDropDown).Gallery.GetCheckedItem())
            End If

            If ddbPaperSize.DropDownControl IsNot Nothing Then
                UpdatePrintPageSize(CType(ddbPaperSize.DropDownControl, GalleryDropDown).Gallery.GetCheckedItem())
            End If

            If ddbCollate.DropDownControl IsNot Nothing Then
                UpdatePrintPageCollate(CType(ddbCollate.DropDownControl, GalleryDropDown).Gallery.GetCheckedItem())
            End If

            If ddbPrinter.DropDownControl IsNot Nothing Then
                UpdatePrintPagePrinters(CType(ddbPrinter.DropDownControl, GalleryDropDown).Gallery.GetCheckedItem())
            End If

            If ddbDuplex.DropDownControl IsNot Nothing Then
                UpdatePrintPageDuplex(CType(ddbDuplex.DropDownControl, GalleryDropDown).Gallery.GetCheckedItem())
            End If
        End Sub

        Private Sub UpdatePrintPageOrientation(ByVal item As GalleryItem)
            If item Is Nothing Then Return
            ddbOrientation.Text = item.Caption
            ddbOrientation.ImageOptions.SvgImage = item.ImageOptions.SvgImage
            If ddbOrientation.DropDownControl IsNot Nothing Then
                printControl2.PrintingSystem.PageSettings.Landscape = CType(ddbOrientation.DropDownControl, GalleryDropDown).Gallery.Groups(0).Items(1).Checked
            End If
        End Sub

        Private Sub UpdatePrintPageMargins(ByVal item As GalleryItem)
            If item Is Nothing Then Return
            ddbMargins.ImageOptions.SvgImage = item.ImageOptions.SvgImage
            ddbMargins.Text = item.Caption
            ddbMargins.Tag = item.Tag
            Dim p As Padding = CType(item.Tag, Padding)
            If printControl2.PrintingSystem IsNot Nothing Then
                printControl2.PrintingSystem.PageSettings.TopMargin = CInt(p.Top * 3.9)
                printControl2.PrintingSystem.PageSettings.BottomMargin = CInt(p.Bottom * 3.9)
                printControl2.PrintingSystem.PageSettings.LeftMargin = CInt(p.Left * 3.9)
                printControl2.PrintingSystem.PageSettings.RightMargin = CInt(p.Right * 3.9)
            End If
        End Sub

        Private Sub UpdatePrintPageSize(ByVal item As GalleryItem)
            If item Is Nothing Then Return
            ddbPaperSize.ImageOptions.SvgImage = item.ImageOptions.SvgImage
            ddbPaperSize.Text = item.Caption
            If printControl2.PrintingSystem IsNot Nothing Then
                printControl2.PrintingSystem.PageSettings.PaperKind = CType(item.Tag, DXPaperKind)
            End If
        End Sub

        Private Sub UpdatePrintPageCollate(ByVal item As GalleryItem)
            If item Is Nothing Then Return
            ddbCollate.ImageOptions.SvgImage = item.ImageOptions.SvgImage
            ddbCollate.Text = item.Caption
            ddbCollate.Tag = item.Tag
        End Sub

        Private Sub UpdatePrintPagePrinters(ByVal item As GalleryItem)
            If item Is Nothing Then Return
            ddbPrinter.Text = item.Caption
            ddbPrinter.ImageOptions.SvgImage = item.ImageOptions.SvgImage
        End Sub

        Private Sub zoomTrackBarControl1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updatedZoom Then Return
            updatedZoom = True
            Try
                zoomTextEdit.EditValue = GetZoomValue()
            Finally
                updatedZoom = False
            End Try
        End Sub

        Private Function GetZoomValue() As Integer
            If zoomTrackBarControl1.Value <= 40 Then
                Return 10 + 90 * (zoomTrackBarControl1.Value - 0) \ 40
            Else
                Return 100 + 400 * (zoomTrackBarControl1.Value - 40) \ 40
            End If
        End Function

        Private updatedZoom As Boolean = False

        Private Sub zoomTextEdit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Try
                Dim zoomValue As Integer = Integer.Parse(CStr(zoomTextEdit.EditValue.ToString()))
                zoomTrackBarControl1.Value = ZoomValueToValue(zoomValue)
                printControl2.Zoom = 0.01F * CInt(zoomValue)
            Catch __unusedException1__ As Exception
            End Try
        End Sub

        Private Function ZoomValueToValue(ByVal zoomValue As Integer) As Integer
            If zoomValue < 100 Then Return Math.Min(80, Math.Max(0, (zoomValue - 10) * 40 \ 90))
            Return Math.Min(80, Math.Max(0, (zoomValue - 100) * 40 \ 400 + 40))
        End Function

        Private Sub pageButtonEdit_ButtonClick(ByVal sender As Object, ByVal e As ButtonPressedEventArgs)
            Dim pageIndex As Integer = CInt(pageButtonEdit.EditValue)
            If e.Button.Kind = ButtonPredefines.Left Then
                If pageIndex > 1 Then pageIndex -= 1
            ElseIf e.Button.Kind = ButtonPredefines.Right Then
                If pageIndex < printControl2.PrintingSystem.Pages.Count Then pageIndex += 1
            End If

            pageButtonEdit.EditValue = pageIndex
        End Sub

        Private Sub pageButtonEdit_EditValueChanging(ByVal sender As Object, ByVal e As ChangingEventArgs)
            Try
                If e.NewValue IsNot Nothing Then
                    Dim pageIndex As Integer = Integer.Parse(e.NewValue.ToString())
                    If pageIndex < 1 Then
                        pageIndex = 1
                    ElseIf pageIndex > printControl2.PrintingSystem.Pages.Count Then
                        pageIndex = printControl2.PrintingSystem.Pages.Count
                    End If

                    e.NewValue = pageIndex
                End If
            Catch __unusedException1__ As Exception
                e.NewValue = 1
            End Try
        End Sub

        Private Sub UpdatePageButtonsEnabledState(ByVal pageIndex As Integer)
            If pageButtonEdit.Properties.Buttons.Count = 0 Then Return
            pageButtonEdit.Properties.Buttons(0).Enabled = pageIndex <> 1
            pageButtonEdit.Properties.Buttons(1).Enabled = pageIndex <> printControl2.PrintingSystem.Pages.Count
        End Sub

        Private Sub pageButtonEdit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim pageIndex As Integer = Convert.ToInt32(pageButtonEdit.EditValue)
            printControl2.SelectedPageIndex = pageIndex - 1
            UpdatePageButtonsEnabledState(pageIndex)
        End Sub

        Private Sub printControl2_SelectedPageChanged(ByVal sender As Object, ByVal e As EventArgs)
            pageButtonEdit.EditValue = printControl2.SelectedPageIndex + 1
        End Sub

        Private Sub rgbiColorScheme_Gallery_ItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            ribbonControl1.ColorScheme = CType(e.Item.Value, RibbonControlColorScheme)
        End Sub

        Private Sub rgbiColorScheme_Gallery_InitDropDownGallery(ByVal sender As Object, ByVal e As InplaceGalleryEventArgs)
            e.PopupGallery.SynchWithInRibbonGallery = True
        End Sub

        Private Sub barButtonItem2_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            XtraMessageBox.Show("Page Borders clicked.")
        End Sub

        Private Sub UpdatePrintPageDuplex(ByVal item As GalleryItem)
            If item Is Nothing Then Return
            ddbDuplex.Text = item.Caption
            ddbDuplex.ImageOptions.SvgImage = item.ImageOptions.SvgImage
            ddbDuplex.Tag = item.Tag
        End Sub
#End Region
    End Class

    Public Class RibbonSimplePadSplashScreen
        Inherits DemoSplashScreen

        Public Sub New()
            DemoText = "RibbonSimplePad"
            ProductText = "The XtraBars Suite"
        End Sub
    End Class
End Namespace
