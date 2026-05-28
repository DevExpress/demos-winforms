Imports System
Imports System.Data
Imports System.Drawing
Imports System.Threading
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Internal
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid

Namespace DevExpress.XtraPivotGrid.Demos

    Public Class ViewOptionsChangedEventArgs
        Inherits EventArgs

        Public Sub New(ByVal name As String, ByVal value As Boolean)
            Me.Name = name
            Me.Value = value
        End Sub

        Public Property Name As String

        Public Property Value As Boolean
    End Class

    Public Class PivotGridRibbonMenuManager
        Inherits RibbonMenuManager

        Private currentPivot As PivotGridControl = Nothing

        Private bsiViewOptions As BarSubItem

        Public ReadOnly Property CurrentPivotGrid As PivotGridControl
            Get
                Return currentPivot
            End Get
        End Property

        Public Event ViewOptionsChanged As EventHandler(Of ViewOptionsChangedEventArgs)

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

        Public Sub RefreshOptionsMenu(ByVal pivotGrid As PivotGridControl)
            currentPivot = pivotGrid
            ShowReservGroup1(pivotGrid IsNot Nothing)
            DXperience.Demos.LookAndFeelMenu.ClearOptionItems(Manager)
            DXperience.Demos.LookAndFeelMenu.AddOptionsMenu(bsiViewOptions, ViewOptions, New ItemClickEventHandler(AddressOf miViewOptions_Click), Manager)
        End Sub

        Private ReadOnly Property ViewOptions As Object
            Get
                If currentPivot Is Nothing Then Return Nothing
                Return currentPivot.OptionsView
            End Get
        End Property

        Private Sub miViewOptions_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim item As OptionBarItem = TryCast(e.Item, OptionBarItem)
            If currentPivot IsNot Nothing AndAlso item IsNot Nothing Then
                If currentPivot.OptionsView.RowTotalsLocation = PivotRowTotalsLocation.Tree AndAlso item.Caption.Equals("ShowRowTotals") Then
                    XtraMessageBox.Show("The ShowRowTotals option must be enabled when the 'Tree' row area mode is used.")
                Else
                    SetOptions.SetOptionValueByString(item.Caption, ViewOptions, item.Checked)
                    RaiseViewOptionsChanged(item.Caption, item.Checked)
                End If

                DXperience.Demos.LookAndFeelMenu.InitOptionsMenu(bsiViewOptions, ViewOptions)
            End If
        End Sub

        Private Sub RaiseViewOptionsChanged(ByVal name As String, ByVal value As Boolean)
            RaiseEvent ViewOptionsChanged(Me, New ViewOptionsChangedEventArgs(name, value))
        End Sub
    End Class

    Public Class TutorialControl
        Inherits TutorialControlBase

        Public Shared Function GetIsCSCode(ByVal moduleName As String) As Boolean
            Try
                Return DemoHelper.IsCSharp
            Catch
                Return True
            End Try
        End Function

        Private redColor, greenColor, blueColor As Color

        Private DefaultBlue As Color = Color.FromArgb(39, 63, 133), DefaultRed As Color = Color.FromArgb(169, 7, 7), DefaultGreen As Color = Color.FromArgb(42, 93, 1)

        Private Shared imlCategory As Object = Nothing

        Private Shared imlHeaders As Object = Nothing

        Private Shared CategoryNames As String() = New String() {"Beverages", "Condiments", "Confections", "Dairy Products", "Grains/Cereals", "Meat/Poultry", "Produce", "Seafood"}

        Public Shared Function GetCategoryIndexByName(ByVal name As Object) As Integer
            If name IsNot Nothing Then
                For i As Integer = 0 To CategoryNames.Length - 1
                    If Equals(CategoryNames(i), name.ToString()) Then Return i
                Next
            End If

            Return -1
        End Function

        Public Shared ReadOnly Property CategoryImageList As Object
            Get
                If imlCategory Is Nothing Then
                    Dim _svgImageCollection As SvgImageCollection = New SvgImageCollection()
                    Dim assembly = GetType(TutorialControl).Assembly
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelperCore.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.beverages.svg", assembly)))
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelperCore.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.condiments.svg", assembly)))
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelperCore.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.confections.svg", assembly)))
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelperCore.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.dairyProduct.svg", assembly)))
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelperCore.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.grainsCereals.svg", assembly)))
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelperCore.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.meatPoultry.svg", assembly)))
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelperCore.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.produce.svg", assembly)))
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelperCore.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.seafood.svg", assembly)))
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelperCore.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.sum.svg", assembly)))
                    imlCategory = _svgImageCollection
                End If

                Return imlCategory
            End Get
        End Property

        Public Shared ReadOnly Property HeadersImageList As Object
            Get
                If imlHeaders Is Nothing Then
                    Dim assembly = GetType(TutorialControl).Assembly
                    Dim _svgImageCollection As SvgImageCollection = New SvgImageCollection()
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelperCore.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.user.svg", assembly)))
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelperCore.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.order_id.svg", assembly)))
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelperCore.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.personalID.svg", assembly)))
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelperCore.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.productSales.svg", assembly)))
                    _svgImageCollection.Add(SvgImage.FromStream(ResourceImageHelperCore.FindStream("DevExpress.XtraPivotGrid.Demos.Resources.sum.svg", assembly)))
                    imlHeaders = _svgImageCollection
                End If

                Return imlHeaders
            End Get
        End Property

        Public Sub New()
            Dim [module] As String = [GetType]().Name
            If GetIsCSCode([module]) Then
                TutorialInfo.WhatsThisCodeFile = GetCSCodePath([module])
                TutorialInfo.WhatsThisXMLFile = GetCSXmlPath([module])
            Else
                TutorialInfo.WhatsThisCodeFile = GetVBCodePath([module])
                TutorialInfo.WhatsThisXMLFile = GetVBXmlPath([module])
            End If
        End Sub

        Private Shared Function GetCSXmlPath(ByVal [module] As String) As String
            Return String.Format("DevExpress.XtraPivotGrid.Demos.CodeInfo.{0}.xml", [module])
        End Function

        Private Shared Function GetCSCodePath(ByVal [module] As String) As String
            Return String.Format("CS\PivotGridMainDemo\Modules\{0}.cs", [module])
        End Function

        Private Shared Function GetVBXmlPath(ByVal [module] As String) As String
            Return String.Format("{0}.xml", [module])
        End Function

        Private Shared Function GetVBCodePath(ByVal [module] As String) As String
            Return String.Format("VB\PivotGridMainDemo\Modules\{0}.vb", [module])
        End Function

        Protected Overrides Sub SetControlManager(ByVal ctrl As Control, ByVal manager As BarManager)
            Dim grid As PivotGridControl = TryCast(ctrl, PivotGridControl)
            If grid IsNot Nothing Then grid.MenuManager = manager
            Dim be As BaseEdit = TryCast(ctrl, BaseEdit)
            If be IsNot Nothing Then be.MenuManager = manager
        End Sub

        Public Overridable ReadOnly Property ViewOptionsControl As PivotGridControl
            Get
                Return Nothing
            End Get
        End Property

        Public Overridable ReadOnly Property ShowLookAndFeelMenu As Boolean
            Get
                Return True
            End Get
        End Property

        Public ReadOnly Property Red As Color
            Get
                If redColor.IsEmpty Then
                    If LookAndFeel.ActiveStyle = ActiveLookAndFeelStyle.Skin Then redColor = EditorsSkins.GetSkin(LookAndFeel).Colors.GetColor(EditorsSkins.SkinFilterControlGroupOperatorTextColor)
                    If redColor.IsEmpty OrElse redColor = Color.Black Then redColor = DefaultRed
                End If

                Return redColor
            End Get
        End Property

        Public ReadOnly Property Blue As Color
            Get
                If blueColor.IsEmpty Then
                    If LookAndFeel.ActiveStyle = ActiveLookAndFeelStyle.Skin Then blueColor = EditorsSkins.GetSkin(LookAndFeel).Colors.GetColor(EditorsSkins.SkinFilterControlFieldNameTextColor)
                    If blueColor.IsEmpty OrElse blueColor = Color.Black Then blueColor = DefaultBlue
                End If

                Return blueColor
            End Get
        End Property

        Public ReadOnly Property Green As Color
            Get
                If greenColor.IsEmpty Then
                    If LookAndFeel.ActiveStyle = ActiveLookAndFeelStyle.Skin Then greenColor = EditorsSkins.GetSkin(LookAndFeel).Colors.GetColor(EditorsSkins.SkinFilterControlOperatorTextColor)
                    If greenColor.IsEmpty OrElse greenColor = Color.Black Then greenColor = DefaultGreen
                End If

                Return greenColor
            End Get
        End Property

        Protected Overrides Sub OnStyleChanged()
            MyBase.OnStyleChanged()
            redColor = Color.Empty
            blueColor = Color.Empty
            greenColor = Color.Empty
        End Sub

        Protected Overridable ReadOnly Property HideCustFormWhenSwitchDemo As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides Sub DoHide()
            If HideCustFormWhenSwitchDemo Then FindPivotGridAndHideCustForm(Me)
        End Sub

        Public Shared Sub FindPivotGridAndHideCustForm(ByVal control As Control)
            If control.Controls Is Nothing Then Return
            For Each ctrl As Control In control.Controls
                FindPivotGridAndHideCustForm(ctrl)
                Dim pivot As PivotGridControl = TryCast(ctrl, PivotGridControl)
                If pivot Is Nothing Then Continue For
                pivot.DestroyCustomization()
            Next
        End Sub

        Private Shared nwindDS As DataSet

        Protected Function GetNWindData(ByVal tableName As String) As DataView
            If nwindDS Is Nothing Then
                Dim dbFileName As String = DevAVDataDirectoryHelper.GetFile("nwind.xml")
                If Not String.IsNullOrEmpty(dbFileName) Then
                    SetWaitDialogCaption(String.Format("Loading {0}...", tableName))
                    nwindDS = New DataSet()
                    nwindDS.ReadXml(dbFileName)
                Else
                    Return Nothing
                End If
            End If

            Return nwindDS.Tables(tableName).DefaultView
        End Function

        Protected Sub UpdateListBoxColor(ByVal listBox As BaseListBoxControl)
            If listBox.Parent.BackColor <> Color.Transparent Then
                listBox.BackColor = listBox.Parent.BackColor
            Else
                listBox.Appearance.Options.UseBackColor = False
            End If
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

        Public Overridable ReadOnly Property ExportControl As PivotGridControl
            Get
                Return Nothing
            End Get
        End Property

        Private thread As Thread

        Private [stop] As Boolean

        Protected Overrides Sub ExportToCore(ByVal filename As String, ByVal ext As String)
            If ExportControl Is Nothing Then Return
            [stop] = False
            thread = New Thread(New ThreadStart(AddressOf StartExport))
            thread.Start()
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            Try
                If Equals(ext, "rtf") Then ExportControl.ExportToRtf(filename)
                If Equals(ext, "docx") Then ExportControl.ExportToDocx(filename)
                If Equals(ext, "pdf") Then ExportControl.ExportToPdf(filename)
                If Equals(ext, "mht") Then ExportControl.ExportToMht(filename)
                If Equals(ext, "html") Then ExportControl.ExportToHtml(filename)
                If Equals(ext, "txt") Then ExportControl.ExportToText(filename)
                If Equals(ext, "xls") Then ExportControl.ExportToXls(filename)
                If Equals(ext, "xlsx") Then ExportControl.ExportToXlsx(filename)
            Finally
                EndExport()
                Cursor.Current = currentCursor
            End Try
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

        Private Sub StartExport()
            Thread.Sleep(400)
            If [stop] Then Return
            Dim progressForm As ExportForm = New ExportForm(FindForm())
            progressForm.Show()
            Try
                While Not [stop]
                    Call Application.DoEvents()
                    Thread.Sleep(100)
                End While
            Catch
            End Try

            progressForm.Dispose()
        End Sub

        Private Sub EndExport()
            [stop] = True
            thread.Join()
        End Sub
#End Region
    End Class

    Public Class DemoFormatCondition

        Private ReadOnly fCondition As PivotGridStyleFormatCondition = Nothing

        Public Sub New(ByVal fCondition As PivotGridStyleFormatCondition)
            Me.fCondition = fCondition
        End Sub

        Public ReadOnly Property StyleCondition As PivotGridStyleFormatCondition
            Get
                Return fCondition
            End Get
        End Property

        Public Overrides Function ToString() As String
            If StyleCondition Is Nothing Then Return "Empty condition"
            If StyleCondition.Condition <> FormatConditionEnum.None Then
                If StyleCondition.Condition = FormatConditionEnum.Between OrElse StyleCondition.Condition = FormatConditionEnum.NotBetween Then
                    Return String.Format("{0} {1:c}, {2:c}", StyleCondition.Condition, StyleCondition.Value1, StyleCondition.Value2)
                Else
                    Return String.Format("{0} {1:c}", StyleCondition.Condition, StyleCondition.Value1)
                End If
            End If

            Return String.Format("Condition Item - Index {0}", Index)
        End Function

        Public ReadOnly Property Index As Integer
            Get
                Return StyleCondition.PivotGrid.FormatConditions.IndexOf(StyleCondition)
            End Get
        End Property
    End Class
End Namespace
