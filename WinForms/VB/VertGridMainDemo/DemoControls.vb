Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Internal
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraPrinting

Namespace DevExpress.XtraVerticalGrid.Demos

    Public Class TutorialControl
        Inherits TutorialControlBase

        Public Sub New()
        End Sub

        Protected Overrides ReadOnly Property ModulesFolder As String
            Get
                Return "VertGridMainDemo\Modules"
            End Get
        End Property

        Protected Overrides ReadOnly Property CodeInfoFolder As String
            Get
                Return "DevExpress.XtraVerticalGrid.Demos.CodeInfo"
            End Get
        End Property

        Public ReadOnly Property VertGridRibbonMenuManager As VGridRibbonMenuManager
            Get
                Return TryCast(RibbonMenuManager, VGridRibbonMenuManager)
            End Get
        End Property

        Protected Overrides Sub SetControlManager(ByVal ctrl As Control, ByVal manager As BarManager)
            Dim vGrid = TryCast(ctrl, VGridControlBase)
            If vGrid IsNot Nothing Then vGrid.MenuManager = manager
        End Sub

        Public Overridable ReadOnly Property ViewOptionsControl As VGridControlBase
            Get
                Return Nothing
            End Get
        End Property

        Private Sub HideCustomization(ByVal collection As ControlCollection)
            For Each ctrl As Control In collection
                HideCustomization(ctrl.Controls)
                If TypeOf ctrl Is VGridControlBase Then CType(ctrl, VGridControlBase).DestroyCustomization()
            Next
        End Sub

        Protected Overrides Sub DoHide()
            HideCustomization(Me.Controls)
        End Sub

        Protected Overridable Sub InitNWindData()
            Dim DBFileName As String = DataDirectoryHelper.GetDataFile("nwind.xml")
            If Not Equals(DBFileName, String.Empty) Then InitXMLData(DBFileName)
        End Sub

        Protected Overridable Sub InitMDBData(ByVal connectionString As String)
        End Sub

        Protected Overridable Sub InitXMLData(ByVal xmlFileName As String)
        End Sub

#Region "Print and Export"
        Protected Overrides Sub AllowExport()
            EnabledPrintExportActions(True, ExportFormats.PDF Or ExportFormats.HTML Or ExportFormats.MHT Or ExportFormats.XLS Or ExportFormats.RTF Or ExportFormats.DOCX Or ExportFormats.Text Or ExportFormats.XLSX, False)
        End Sub

        Public Overrides ReadOnly Property AllowPrintOptions As Boolean
            Get
                Return ExportControl IsNot Nothing
            End Get
        End Property

        Public Overridable ReadOnly Property ExportControl As VGridControlBase
            Get
                Return Nothing
            End Get
        End Property

        Protected Overrides Sub ExportToCore(ByVal filename As String, ByVal ext As String)
            If ExportControl Is Nothing Then Return
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            If Equals(ext, "rtf") Then ExportControl.ExportToRtf(filename)
            If Equals(ext, "docx") Then ExportControl.ExportToDocx(filename)
            If Equals(ext, "pdf") Then ExportControl.ExportToPdf(filename)
            If Equals(ext, "mht") Then ExportControl.ExportToMht(filename, New MhtExportOptions())
            If Equals(ext, "html") Then ExportControl.ExportToHtml(filename)
            If Equals(ext, "txt") Then ExportControl.ExportToText(filename)
            If Equals(ext, "xls") Then ExportControl.ExportToXls(filename)
            If Equals(ext, "xlsx") Then ExportControl.ExportToXlsx(filename)
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

        Protected Overrides Sub ExportToXLSX()
            ExportTo("xlsx", "XLSX document (*.xlsx)|*.xlsx")
        End Sub

        Protected Overrides Sub ExportToRTF()
            ExportTo("rtf", "RTF document (*.rtf)|*.rtf")
        End Sub

        Protected Overrides Sub ExportToDOCX()
            ExportTo("docx", "DOCX document (*.docx)|*.docx")
        End Sub

        Protected Overrides Sub ExportToText()
            ExportTo("txt", "Text document (*.txt)|*.txt")
        End Sub

        Protected Overrides Sub PrintPreview()
            If ExportControl IsNot Nothing Then
                If RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm Then
                    ExportControl.ShowRibbonPrintPreview()
                Else
                    ExportControl.ShowPrintPreview()
                End If
            End If
        End Sub
#End Region
    End Class

#Region "MenuManager"
    Public Class VGridRibbonMenuManager
        Inherits RibbonMenuManager

        Private currentVGrid As VGridControlBase = Nothing

        Private bsiViewOptions As BarSubItem

        Public Sub New(ByVal form As RibbonMainForm)
            MyBase.New(form)
            CreateOptionsMenu(form.ReservGroup1, form.Ribbon)
        End Sub

        Private Sub CreateOptionsMenu(ByVal ribbonPageGroup As RibbonPageGroup, ByVal ribbonControl As RibbonControl)
            ribbonPageGroup.Text = "Options"
            bsiViewOptions = New BarSubItem()
            bsiViewOptions.Caption = "View" & Microsoft.VisualBasic.Constants.vbLf & " Options"
            Call MainFormHelper.SetBarButtonImage(bsiViewOptions, "View")
            ribbonControl.Items.Add(bsiViewOptions)
            ribbonPageGroup.ItemLinks.Add(bsiViewOptions)
        End Sub

        Public Sub RefreshOptionsMenu(ByVal vGrid As VGridControlBase)
            currentVGrid = vGrid
            ShowReservGroup1(vGrid IsNot Nothing)
            LookAndFeelMenu.ClearOptionItems(Manager)
            Call LookAndFeelMenu.AddOptionsMenu(bsiViewOptions, ViewOptions, New ItemClickEventHandler(AddressOf miViewOptions_Click), Manager)
        End Sub

        Private ReadOnly Property ViewOptions As Object
            Get
                If currentVGrid Is Nothing Then Return Nothing
                Return currentVGrid.OptionsView
            End Get
        End Property

        Private Sub miViewOptions_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim item As OptionBarItem = TryCast(e.Item, OptionBarItem)
            If currentVGrid IsNot Nothing AndAlso item IsNot Nothing Then
                DevExpress.Utils.SetOptions.SetOptionValueByString(item.Caption, ViewOptions, item.Checked)
                LookAndFeelMenu.InitOptionsMenu(bsiViewOptions, ViewOptions)
            End If
        End Sub
    End Class

#End Region  ' MenuManager
    Public Module LicenseInfo

        Public Sub SetToolTipController(ByVal [module] As TutorialControl, ByVal grid As VGridControl)
            grid.ToolTipController = [module].LicenseToolTipController
            AddHandler [module].LicenseToolTipController.OnLicenseChanged, Sub(s, e) e.Info = GetLicenseInfo(e.Row)
            [module].LicenseToolTipController.UpdateMaskOptions(grid)
        End Sub

        Private Function GetLicenseInfo(ByVal obj As Object) As String
            Dim item = TryCast(obj, VehiclesData.OrderItem)
            If item IsNot Nothing Then Return item.Model.LicenseInfo
            Return Nothing
        End Function
    End Module
End Namespace
