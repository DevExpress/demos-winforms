Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting

Namespace DevExpress.XtraTreeList.Demos

    Public Class TutorialControl
        Inherits DevExpress.DXperience.Demos.TutorialControlBase

        Private fDescription As DevExpress.Utils.Frames.NotePanel = Nothing

        Public Sub New()
        End Sub

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public Property Description As DevExpress.Utils.Frames.NotePanel
            Get
                Return Me.fDescription
            End Get

            Set(ByVal value As DevExpress.Utils.Frames.NotePanel)
                Me.fDescription = value
                Me.OnSetDescription("")
            End Set
        End Property

        Protected Overrides ReadOnly Property CodeInfoFolder As String
            Get
                Return "DevExpress.XtraTreeList.Demos.CodeInfo"
            End Get
        End Property

        Protected Overridable Sub OnSetDescription(ByVal fDescription As String)
            If Equals(fDescription, String.Empty) Then Return
            Me.Description.Text = String.Format(fDescription)
        End Sub

        Public ReadOnly Property TreeListRibbonMenuManager As TreeListRibbonMenuManager
            Get
                Return TryCast(Me.RibbonMenuManager, DevExpress.XtraTreeList.Demos.TreeListRibbonMenuManager)
            End Get
        End Property

        Protected Overrides Sub AllowExport()
            Me.EnabledPrintExportActions(True, DevExpress.DXperience.Demos.ExportFormats.PDF Or DevExpress.DXperience.Demos.ExportFormats.HTML Or DevExpress.DXperience.Demos.ExportFormats.MHT Or DevExpress.DXperience.Demos.ExportFormats.XLS Or DevExpress.DXperience.Demos.ExportFormats.RTF Or DevExpress.DXperience.Demos.ExportFormats.DOCX Or DevExpress.DXperience.Demos.ExportFormats.Text Or DevExpress.DXperience.Demos.ExportFormats.XLSX, False)
        End Sub

        Public Overrides ReadOnly Property AllowPrintOptions As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overridable Sub CreateBarSubItemOptions()
        End Sub

        Public Overridable ReadOnly Property MainControl As TreeList
            Get
                Return Nothing
            End Get
        End Property

        Protected Overridable ReadOnly Property Options As Object
            Get
                Return Nothing
            End Get
        End Property

        Protected Overridable ReadOnly Property OptionsName As String
            Get
                Return String.Empty
            End Get
        End Property

        Public Overridable Function InitCustomBarItemOptions(ByVal barItemOptions As DevExpress.XtraBars.BarSubItem, ByVal manager As DevExpress.XtraTreeList.Demos.TreeListRibbonMenuManager) As Boolean
            If Me.Options Is Nothing OrElse Me.MainControl Is Nothing Then Return False
            barItemOptions.Caption = Me.OptionsName
            Call DevExpress.DXperience.Demos.LookAndFeelMenu.AddOptionsMenu(barItemOptions, Me.Options, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.miViewOptions_Click), manager.Manager)
            Return True
        End Function

        Private Sub miViewOptions_Click(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            Dim _item As DevExpress.DXperience.Demos.OptionBarItem = TryCast(e.Item, DevExpress.DXperience.Demos.OptionBarItem)
            If _item IsNot Nothing Then
                DevExpress.Utils.SetOptions.SetOptionValueByString(_item.Caption, Me.Options, _item.Checked)
                _item.Checked = DevExpress.Utils.SetOptions.OptionValueByString(_item.Tag.ToString(), Me.Options)
            End If
        End Sub

        Protected Overrides Sub OnUseEmptyRootPadding()
            If Me.MainControl IsNot Nothing Then Me.MainControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        End Sub

        Protected Overrides Sub DoHide()
            For Each ctrl As System.Windows.Forms.Control In Me.Controls
                If TypeOf ctrl Is DevExpress.XtraTreeList.TreeList Then CType(ctrl, DevExpress.XtraTreeList.TreeList).DestroyCustomization()
            Next
        End Sub

        Protected Overrides Sub SetControlManager(ByVal ctrl As System.Windows.Forms.Control, ByVal manager As DevExpress.XtraBars.BarManager)
            Dim _treeList As DevExpress.XtraTreeList.TreeList = TryCast(ctrl, DevExpress.XtraTreeList.TreeList)
            If _treeList IsNot Nothing Then _treeList.MenuManager = manager
            Dim scrollBar As DevExpress.XtraEditors.ScrollBarBase = TryCast(ctrl, DevExpress.XtraEditors.ScrollBarBase)
            If scrollBar IsNot Nothing AndAlso Me.FluentScrollBars Then Call DevExpress.XtraEditors.ScrollBarBase.ApplyUIMode(scrollBar, DevExpress.XtraEditors.ScrollUIMode.Fluent)
        End Sub

        Protected Overridable ReadOnly Property FluentScrollBars As Boolean
            Get
                Return False
            End Get
        End Property

#Region "Print and Export"
        Protected Overrides Sub ExportToCore(ByVal filename As System.[String], ByVal ext As String)
            If Me.MainControl Is Nothing Then Return
            Dim currentCursor As System.Windows.Forms.Cursor = System.Windows.Forms.Cursor.Current
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            If Equals(ext, "rtf") Then Me.MainControl.ExportToRtf(filename)
            If Equals(ext, "docx") Then Me.MainControl.ExportToDocx(filename)
            If Equals(ext, "pdf") Then Me.MainControl.ExportToPdf(filename)
            If Equals(ext, "mht") Then Me.MainControl.ExportToMht(filename, New DevExpress.XtraPrinting.MhtExportOptions())
            If Equals(ext, "html") Then Me.MainControl.ExportToHtml(filename)
            If Equals(ext, "txt") Then Me.MainControl.ExportToText(filename)
            If Equals(ext, "xls") Then Me.MainControl.ExportToXls(filename)
            If Equals(ext, "xlsx") Then Me.MainControl.ExportToXlsx(filename)
            System.Windows.Forms.Cursor.Current = currentCursor
        End Sub

        Protected Overrides Sub ExportToPDF()
            Me.ExportTo("pdf", "PDF document (*.pdf)|*.pdf")
        End Sub

        Protected Overrides Sub ExportToHTML()
            Me.ExportTo("html", "HTML document (*.html)|*.html")
        End Sub

        Protected Overrides Sub ExportToMHT()
            Me.ExportTo("mht", "MHT document (*.mht)|*.mht")
        End Sub

        Protected Overrides Sub ExportToXLS()
            Me.ExportTo("xls", "XLS document (*.xls)|*.xls")
        End Sub

        Protected Overrides Sub ExportToXLSX()
            Me.ExportTo("xlsx", "XLSX document (*.xlsx)|*.xlsx")
        End Sub

        Protected Overrides Sub ExportToRTF()
            Me.ExportTo("rtf", "RTF document (*.rtf)|*.rtf")
        End Sub

        Protected Overrides Sub ExportToDOCX()
            Me.ExportTo("docx", "DOCX document (*.docx)|*.docx")
        End Sub

        Protected Overrides Sub ExportToText()
            Me.ExportTo("txt", "Text document (*.txt)|*.txt")
        End Sub

        Protected Overrides Sub PrintPreview()
            If Me.MainControl IsNot Nothing Then
                If Me.RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm Then
                    Me.MainControl.ShowRibbonPrintPreview()
                Else
                    Me.MainControl.ShowPrintPreview()
                End If
            End If
        End Sub
#End Region
    End Class

    Public Class TreeListRibbonMenuManager
        Inherits DevExpress.DXperience.Demos.RibbonMenuManager

        Private bsiViewOptions As DevExpress.XtraBars.BarSubItem

        Public Sub New(ByVal form As DevExpress.DXperience.Demos.RibbonMainForm)
            MyBase.New(form)
            Me.CreateOptionsMenu(form.ReservGroup1, form.Ribbon)
        End Sub

        Private Sub CreateOptionsMenu(ByVal ribbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup, ByVal ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl)
            ribbonPageGroup.Text = "Options"
            Me.bsiViewOptions = New DevExpress.XtraBars.BarSubItem()
            Call DevExpress.DXperience.Demos.MainFormHelper.SetBarButtonImage(Me.bsiViewOptions, "View")
            ribbonControl.Items.Add(Me.bsiViewOptions)
            ribbonPageGroup.ItemLinks.Add(Me.bsiViewOptions)
        End Sub

        Public Sub RefreshOptionsMenu(ByVal tutorialControl As DevExpress.XtraTreeList.Demos.TutorialControl)
            Call DevExpress.DXperience.Demos.LookAndFeelMenu.ClearOptionItems(Me.Manager)
            If tutorialControl IsNot Nothing AndAlso tutorialControl.InitCustomBarItemOptions(Me.bsiViewOptions, Me) Then
                Me.ShowReservGroup1(True)
            Else
                Me.ShowReservGroup1(False)
            End If
        End Sub
    End Class

    Public Class DemosHelper

        Public Shared Sub ShowDescriptionForm(ByVal location As System.Drawing.Point, ByVal size As System.Drawing.Size, ByVal description As String, ByVal caption As String)
            Dim frm As DevExpress.XtraEditors.XtraForm = New DevExpress.XtraEditors.XtraForm() With {.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow, .ShowInTaskbar = False, .StartPosition = System.Windows.Forms.FormStartPosition.Manual, .Text = caption, .Size = size}
            Dim tb As DevExpress.XtraEditors.MemoEdit = New DevExpress.XtraEditors.MemoEdit() With {.Dock = System.Windows.Forms.DockStyle.Fill, .[ReadOnly] = True, .Text = description}
            frm.Controls.Add(tb)
            frm.Location = DevExpress.Utils.ControlUtils.CalcLocation(location, location, frm.Size)
            AddHandler frm.Shown, Sub(sender, e) tb.DeselectAll()
            frm.ShowDialog()
        End Sub
    End Class

    Public Module LicenseInfo

        Public Sub SetToolTipController(ByVal [module] As DevExpress.XtraTreeList.Demos.TutorialControl, ByVal treeList As DevExpress.XtraTreeList.TreeList)
            treeList.ToolTipController = [module].LicenseToolTipController
            AddHandler [module].LicenseToolTipController.OnLicenseChanged, Sub(s, e) e.Info = DevExpress.XtraTreeList.Demos.LicenseInfo.GetLicenseInfo(e.Row)
            [module].LicenseToolTipController.UpdateMaskOptions(treeList)
        End Sub

        Private Function GetLicenseInfo(ByVal obj As Object) As String
            Dim item = TryCast(obj, DevExpress.XtraTreeList.Demos.VehiclesData.TrademarkBody)
            If item IsNot Nothing Then Return item.Model.LicenseInfo
            Return Nothing
        End Function
    End Module
End Namespace
